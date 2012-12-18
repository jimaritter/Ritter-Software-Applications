using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;

namespace PerfectPet
{
    public partial class frmPeopleTools : Form
    {
        private frmAddPerson addPerson;
        private frmEditPerson editPerson;
        private frmAddPersonType _addPersonType;
        private frmAddAddressType addAddressType;
        private frmAddPhoneType addPhoneType;
        private frmAddAddress addAddress;
        private frmEditAddress editAddress;
        private frmAddPet addPet;
        private frmEditPet editPet;
        private IPersonType _personType;
        private IPerson _person;
        private Person person;
        private PersonType personType;
        private IList<Person> people;
        private IList<Address> addresses;
        private IAddress _address;
        private Address address;
        private Pet pet;
        private IPet _pet;
        private IEnumerable<Pet> pets; 
        private int personid;
        private int addressid;
        private int petid;
        
        public frmPeopleTools()
        {
            InitializeComponent();
        }

        private void frmPeopleTools_Load(object sender, EventArgs e)
        {
            try
            {
                _person = new Person();
                person = new Person();
                people = new List<Person>();
                addresses = new List<Address>();
                _address = new Address();
                address = new Address();
                BindPersonList();
                var row = ddlPeople.EditorControl.CurrentRow;
                if (row == null)
                {
                    btnAddPet.Enabled = false;
                    btnEditPet.Enabled = false;
                    return;
                }
                personid = (int) row.Cells[0].Value;            
                BindPersonDetails(personid);
                BindAddressGrid(personid);
                BindPetGrid();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        #region "Class Methods"

        private void GetAddressList(int personid)
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = GetAddresses(person.Id);
                gridAddresses.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindPersonDetails(int personid)
        {
            try
            {
                //person = new Person();
                //_person = new Person();
                btnAddPet.Enabled = true;
                btnEditPet.Enabled = true;
                person = _person.GetById(personid);
                lblFirstName.Text = person.FirstName;
                lblMiddleName.Text = person.MiddleName;
                lblLastName.Text = person.LastName;
                lblActive.Text = person.Active.ToString();
                lblEmail.Text = person.Email;
                lblType.Text = Enum.GetName(typeof(PersonTypeList),person.Type);

            }
            catch (Exception)
            {

            }
        }

        private void BindPersonList()
        {
            //_person = new Person();
            //people = new List<Person>();
            people = _person.GetAll();

            var query = from i in people
                        select new { Id = i.Id, Name = i.LastName + ", " + i.FirstName };

            var bindsrc = new BindingSource();
            bindsrc.DataSource = query;
            ddlPeople.DataSource = bindsrc.DataSource;
            if (people.Count == 0)
            {
                btnAddAddress.Enabled = false;
                btnEditAddress.Enabled = false;
                btnDeleteAddress.Enabled = false;
            }else
            {
                btnAddAddress.Enabled = true;
                btnEditAddress.Enabled = true;
                btnDeleteAddress.Enabled = true;
            }
        }

        private void BindAddressGrid(int personid)
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = GetAddresses(person.Id);
                gridAddresses.DataSource = bindsrc.DataSource;
                if(gridAddresses.RowCount == 0)
                {
                    btnDeleteAddress.Enabled = false;
                    btnEditAddress.Enabled = false;
                }else
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

        private void BindPetGrid()
        {
            try
            {
                pet = new Pet();
                _pet = new Pet();
                pets = _pet.GetByPersonId(personid);
                var bindsrc = new BindingSource();
                bindsrc.DataSource = pets;
                gridPets.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        IEnumerable<Address> GetAddresses(int personid)
        {
            try
            {
                _address = new Address();
                return _address.GetByPersonId(personid);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ddlPeople.EditorControl.CurrentRow;
                if (row == null) { return; }
                editPerson = new frmEditPerson();
                editPerson.PersonId = (int)row.Cells[0].Value;
                editPerson.ShowDialog(this);
                BindPersonList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                addPerson = new frmAddPerson();
                addPerson.ShowDialog(this);
                BindPersonList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ddlPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var row = ddlPeople.EditorControl.CurrentRow;
                if (row == null) { return; }
                personid = (int) row.Cells[0].Value;
                BindPersonDetails((int)row.Cells[0].Value);
                BindAddressGrid(personid);
                BindPetGrid();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void menuPersonTypes_Click(object sender, EventArgs e)
        {
            try
            {
                _addPersonType = new frmAddPersonType();
                _addPersonType.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuAddressTypes_Click(object sender, EventArgs e)
        {
            try
            {
                addAddressType = new frmAddAddressType();
                addAddressType.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuPhoneTypes_Click(object sender, EventArgs e)
        {
            try
            {
                addPhoneType = new frmAddPhoneType();
                addPhoneType.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                addAddress = new frmAddAddress();
                addAddress.PersonId = personid;
                addAddress.ShowDialog(this);
                BindAddressGrid(personid);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridAddresses_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            if(gridAddresses.CurrentRow == null)
            {
                MessageBox.Show("Please select an address before deleting.");
                return;
            }
            DeleteAddress((int)gridAddresses.CurrentRow.Cells[0].Value);
        }

        private void DeleteAddress(int value)
        {
            try
            {
                address = _address.GetById(value);
                _address.Delete(address);
                BindAddressGrid(personid);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            try
            {
                var row = gridAddresses.CurrentRow;
                if(row == null)
                {
                    return;
                }
                editAddress = new frmEditAddress();
                editAddress.AddressId = (int) row.Cells[0].Value;
                editAddress.PersonId = personid;
                editAddress.ShowDialog(this);
                BindAddressGrid(personid);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            addPet = new frmAddPet();
            addPet.PersonId = personid;
            addPet.ShowDialog(this);
            BindPetGrid();
        }

        private void btnEditPet_Click(object sender, EventArgs e)
        {
            editPet = new frmEditPet();
            editPet.PetId = petid;
            editPet.PersonId = personid;
            editPet.ShowDialog(this);
            BindPetGrid();
        }

        private void gridPets_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = gridPets.CurrentRow.Cells[0].Value;
                pet = _pet.GetById((int) row);
                petid = pet.PetId;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
