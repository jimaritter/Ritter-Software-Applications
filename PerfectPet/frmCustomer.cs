using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Repository;
using StructureMap;
using Telerik.WinControls.UI;

namespace PerfectPet
{
    public partial class frmCustomer : Form
    {
        protected ISession _session = null;

        private IPerson _person;
        private Person person;
        private IEnumerable<Person> people; 
        private IAddress _address;
        private Address address;
        private IList<Address> addresses;
        private IPet _pet;
        private IEnumerable<Pet> pets;
        private Pet pet;
        private IDogBreed _dogBreed;
        private IList<DogBreed> dogBreeds;
        private DogBreed dogBreed;
        private ICatBreed _catBreed;
        private IList<CatBreed> catBreeds;
        private CatBreed catBreed;
        private Phone phone;
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public int PetId { get; set; }
        public bool IsNewCustomer { get; set; }
        public bool IsNewAddress { get; set; }


        private static readonly IEnumerable<CodeValuePair> PhoneListTypes =
            EnumerationParser.EnumerateAsCodeValuePairs<PhoneTypeList>(true, "Select a phone type...");

        public frmCustomer()
        {
            try
            {
                InitializeComponent();
                this.Text = Program.AppTitle + " - " + "Customers and Pets";
                tabPerson.Enabled = false;
                tabAddresses.Enabled = false;
                BindPersonTypeList();
                BindCustomerList();
                BindAddressTypeList();
                BindStateList();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                throw;
            }

        }

        #region


        private void SetStatusBarText(string statustext)
        {
            StripStatus.Text = statustext;
        }

        private void GetAddressList(int personid)
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = GetAddresses();
                gridAddresses.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindAddressTypeList()
        {
            try
            {
                ddlAddressType.DataSource = EnumerationParser.GetEnumDescriptions(typeof(AddressTypeList));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindAddressGrid()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = GetAddresses();
                gridAddresses.DataSource = bindsrc.DataSource;
                if (gridAddresses.RowCount == 0)
                {
                    btnDeleteAddress.Enabled = false;
                    btnEditAddress.Enabled = false;
                }
                else
                {
                    btnDeleteAddress.Enabled = true;
                    btnEditAddress.Enabled = true;
                }
                //foreach (var i in gridAddresses.Rows)
                //{

                //    i.Cells[1].Value = Enum.GetName(typeof(AddressTypeList), i.Cells[1].);
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        IEnumerable<Address> GetAddresses()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IAddress>();
                return item.GetByPersonId(PersonId);
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void GetAddressDetails(int addressid)
        {
            var item = ObjectFactory.GetInstance<IAddress>();
            var addressobj = item.GetById(addressid);
            txtCity.Text = addressobj.City;
            txtStreet.Text = addressobj.Street;
            txtZip.Text = addressobj.Zip;
            ddlAddressType.SelectedValue = addressobj.Type;
            ddlState.SelectedValue = addressobj.State;
        }

        private void SavePerson()
        {
            try
            {
                SetStatusBarText("Saving Person...");
                if (IsNewCustomer)
                {
                    person = ObjectFactory.GetInstance<IPerson>() as Person;
                }else
                {
                    var item = ObjectFactory.GetInstance<IPerson>();
                    person = item.GetById(PersonId);
                }
                person.Salutation = ddlSalutation.SelectedValue.ToString();
                person.FirstName = txtFirstName.Text;
                person.MiddleName = txtMiddleName.Text;
                person.LastName = txtLastName.Text;
                person.Active = chkActive.Checked;
                person.Email = txtEmail.Text;
                person.CreatedDate = DateTime.Now;
                person.Number = txtCustomerNumber.Text;
                person.Notes = txtCustomerNotes.Text;
                person.Discount = Convert.ToDouble(txtDiscount.Text);
                person.Balance = Convert.ToDouble(txtBalance.Text);
                person.Type = ddlPersonType.SelectedValue.ToString();
                person.Phone = txtPhone.Text;
                person.Mobile = txtMobile.Text;
                person.Fax = txtFax.Text;
                person.Save(person);
                SetStatusBarText("Person Saved");
            }
            catch (Exception)
            {
                SetStatusBarText("");
                throw;
            }
        }

        private void BindCustomerList()
        {
            try
            {
                SetStatusBarText("Fetching Customers...");
                cboCustomerList.Text = "";
                var personitem = ObjectFactory.GetInstance<IPerson>();
                people = new List<Person>();
                people = personitem.CustomerList("Customer");
                BindSalutationList();
                var query = from i in people
                            select new { Id = i.Id, Name = i.Number + " - " + i.LastName + ", " + i.FirstName };

                var bindsrc = new BindingSource();
                bindsrc.DataSource = query;
                cboCustomerList.DataSource = bindsrc.DataSource;
                if(people == null)
                {
                    tabPerson.Enabled = true;
                    IsNewCustomer = true;
                }
                SetSelectedPersonType("Customer");
                SetStatusBarText("Retrieved Customers Complete");
            }
            catch (Exception)
            {
                SetStatusBarText("");
                throw;
            }

        }

        private void BindEmployeeList()
        {
            try
            {
                SetStatusBarText("Fetching Eployees...");
                cboCustomerList.Text = "";
                var personitem = ObjectFactory.GetInstance<IPerson>();
                people = new List<Person>();
                people = personitem.CustomerList("Employee");
                BindSalutationList();
                var query = from i in people
                            select new { Id = i.Id, Name = i.Number + " - " + i.LastName + ", " + i.FirstName };

                var bindsrc = new BindingSource();
                bindsrc.DataSource = query;
                cboCustomerList.DataSource = bindsrc.DataSource;
                if (people == null)
                {
                    tabPerson.Enabled = true;
                    IsNewCustomer = true;
                }
                SetSelectedPersonType("Employee");
                SetStatusBarText("Retrieved Employees Complete");
            }
            catch (Exception)
            {
                SetStatusBarText("");
                throw;
            }

        }

        private void BindSalutationList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof (Salutation));
                ddlSalutation.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ResetPersonFields()
        {
            try
            {
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                chkActive.Checked = false;
                txtEmail.Clear();
                txtCustomerNumber.Clear();
                txtCustomerNotes.Clear();
                txtPhone.Clear();
                txtMobile.Clear();
                txtFax.Clear();
                txtFirstName.Focus();
                txtDiscount.Text = 0.ToString();
                txtBalance.Text = 0.ToString();
                tabPerson.Enabled = false;
                tabAddresses.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ResetAddressFields()
        {
            try
            {
                txtStreet.Clear();
                txtCity.Clear();
                txtZip.Clear();
            }
            catch (Exception)
            {
                
                throw;
            }    
        }


        private void GetPersonDetails()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IPerson>();
                var personobj = item.GetById(PersonId);
                txtFirstName.Text = personobj.FirstName;
                txtMiddleName.Text = personobj.MiddleName;
                txtLastName.Text = personobj.LastName;
                chkActive.Checked = personobj.Active;
                txtEmail.Text = personobj.Email;
                txtCustomerNumber.Text = personobj.Number;
                txtCustomerNotes.Text = personobj.Notes;
                txtDiscount.Text = personobj.Discount.ToString();
                txtBalance.Text = personobj.Balance.ToString();
                txtPhone.Text = personobj.Phone;
                txtMobile.Text = personobj.Mobile;
                txtFax.Text = personobj.Fax;
                tabPerson.Enabled = true;
                tabAddresses.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void BindStateList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(States));
                ddlState.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetSelectedPersonType(string selectpersontype)
        {
            ddlPersonType.SelectedItem = selectpersontype;
        }

        private void BindPersonTypeList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(PersonTypeList));
                ddlPersonType.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveAddress()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IAddress>();
                if(AddressId == 0)
                {
                   address = item.Get();
                }else
                {
                   address = item.GetById(AddressId);
                }
                address.Street = txtStreet.Text;
                address.City = txtCity.Text;
                address.CreatedDate = DateTime.Now;
                address.State = ddlState.SelectedValue.ToString();
                address.Zip = txtZip.Text;
                address.Type = ddlAddressType.SelectedValue.ToString();
                address.Person = GetPerson(PersonId);
                item.Save(address);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Person GetPerson(int personid)
        {
            try
            {
                var item = ObjectFactory.GetInstance<IPerson>();
                var personobj = item.GetById(personid);
                return personobj;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        #endregion

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please enter in a customer name before saving.");
                return;
            }
            SavePerson();
            BindCustomerList();
            ResetAddressFields();
            ResetPersonFields();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            IsNewCustomer = true;
            IsNewAddress = true;
            ResetPersonFields();
            ResetAddressFields();
            txtFirstName.Focus();
            tabPerson.Enabled = true;
            tabAddresses.Enabled = true;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please enter in a customer name before saving.");
                return;
            }
            switch (tabParent.SelectedPage.TabIndex)
            {
                case 0:
                    SavePerson();
                        BindCustomerList();
                    break;
                case 1:
                    SaveAddress();
                    BindAddressGrid();
                    break;
                default:
                    break;
            }            
            ResetPersonFields();
            ResetAddressFields();
            PersonId = 0;
            AddressId = 0;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picViewCustomer_Click(object sender, EventArgs e)
        {
            if(cboCustomerList.EditorControl.CurrentRow == null)
            {
                IsNewCustomer = true;
                ResetPersonFields();
                ResetAddressFields();
                txtFirstName.Focus();
                tabPerson.Enabled = true;
                tabAddresses.Enabled = true;
                return;
            }
            var row = cboCustomerList.EditorControl.CurrentRow;
            PersonId = (int)row.Cells[0].Value;
            IsNewCustomer = false;
            GetPersonDetails();
            BindAddressGrid();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if(txtStreet.Text == string.Empty || txtCity.Text == string.Empty || txtZip.Text == string.Empty)
            {
                MessageBox.Show("You must enter data in the address fields before saving.");
                return;
            }
            SaveAddress();
            BindAddressGrid();
            ResetAddressFields();
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if(gridAddresses.CurrentRow == null)
                {
                    return;
                }
                AddressId= (int)gridAddresses.CurrentRow.Cells[0].Value;
                IsNewAddress = false;
                GetAddressDetails(AddressId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void linkCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lblPersonTypeList.Text = "Customer List";
                ResetPersonFields();
                ResetAddressFields();
                BindCustomerList();
            }catch
            {
                lblPersonTypeList.Text = "";
                throw;
            }
        }

        private void linkEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lblPersonTypeList.Text = "Employee List";
                ResetPersonFields();
                ResetAddressFields();
                BindEmployeeList();
            }catch
            {
                lblPersonTypeList.Text = "";
                throw;
            }
        }
  
    }
}
