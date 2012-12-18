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
using PerfectPet.Model.Phones;

namespace PerfectPet
{
    public partial class frmManagePeople : Form
    {

        private IPersonType _personType;
        private IList<PersonType> _personTypes;
        private IPerson _person;
        private IAddress _address;
        private IPet _pet;
        private IPhone _phone;
        private IAddressType _addressType;
        private IPhoneType _phoneType;
        private int _personid;
        private Person person;
        private PersonType personType;
        private AddressType addressType;
        private PhoneType phoneType;
        private IList<Address> addresses;
        private bool IsNewPerson;

        private frmAddPerson addPerson;
        private frmEditPerson editPerson;

        public frmManagePeople()
        {
            InitializeComponent();
            this.Text = Program.AppTitle + " - " + "Manage People";
        }
        
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            try
            {
                BindPersonCbo();
                BindPersonTypeList();
                BindPersonGrid();
                GetPersonTypeCboList();
                BindStateList();
                BindAddressTypeList(_addressType);
                BindPhoneTypeList(_phoneType);
            }
            catch (Exception exception)
            {

            }
        }

        #region "Class Events"
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            IsNewPerson = false;
            var row = multicboPersonList.EditorControl.CurrentRow;
            if (row == null) { return; }
            editPerson = new frmEditPerson();
            editPerson.PersonId = (int) row.Cells[1].Value;
            editPerson.ShowDialog(this);
            BindPersonCbo();
            BindPersonDetails((int)row.Cells[1].Value);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            addPerson = new frmAddPerson();
            addPerson.ShowDialog(this);
            BindPersonCbo();
            ResetPersonFields();
        }

        private void btnSavePersonType_Click(object sender, EventArgs e)
        {
            if (txtPersonType.Text == string.Empty)
            {
                MessageBox.Show("Please enter in a type before saving.");
                return;
            }
            AddPersonType();
            txtPersonType.Text = "";
            BindPersonTypeList();
        }

        private void multicboPersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void gridAddresses_SelectionChanged(object sender, EventArgs e)
        {
            BindAddressFields((int)gridAddresses.SelectedRows[0].Cells[0].Value);
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    txtFirstName.Focus();
                    MessageBox.Show("You must enter in a first and last name before saving");
                    return;
                }
                SavePerson();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            try
            {
                ResetAddressForm();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindPhoneTypeList(IPhoneType phoneType)
        {
            try
            {
                if (phoneType == null)
                {
                    phoneType = new PhoneType();
                }
                var bindsrc = new BindingSource();
                bindsrc.DataSource = phoneType.GetAll();
                listPhoneTypes.DataSource = bindsrc.DataSource;
                listPhoneTypes.DataMember = "Id";
                listPhoneTypes.ValueMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSaveAddessType_Click(object sender, EventArgs e)
        {
            AddNewAddressType();
        }

        private void btnSavePhoneType_Click(object sender, EventArgs e)
        {
            AddNewPhoneType();
        }
        #endregion

        //void GetAddressList(int personid)
        //{
        //    _address = new Address();
        //    var addresses = _address.GetByPersonId(personid);
        //    var bind = new BindingSource();
        //    bind.DataSource = addresses;
        //    gridAddresses.DataSource = bind.DataSource;           
        //}

        #region "Class Methods"

            private void ClearAddressFields()
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

            private void BindAddressTypeList(IAddressType type)
            {
                try
                {
                    if (type == null)
                    {
                        type = new AddressType();
                    }
                    var bindsrc = new BindingSource();
                    bindsrc.DataSource = type.GetAll();
                    listAddressTypes.DataSource = bindsrc.DataSource;
                    listAddressTypes.DataMember = "Id";
                    listAddressTypes.ValueMember = "Name";

                    ddlAddressType.DataSource = bindsrc.DataSource;
                    ddlAddressType.DataMember = "Id";
                    ddlAddressType.ValueMember = "Name";

                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void AddNewAddressType()
        {
            try
            {
                if (txtAddressType.Text == string.Empty)
                {
                    MessageBox.Show("Please enter an address value before saving.");
                    txtAddressType.Focus();
                    return;
                }
                if (_addressType == null)
                {
                    _addressType = new AddressType();
                }
                addressType = new AddressType();
                addressType.Name = txtAddressType.Text;
                addressType.CreatedDate = DateTime.Now;
                _addressType.Save(addressType);
                txtAddressType.Clear();
                BindAddressTypeList(_addressType);
            }
            catch (Exception)
            {

                throw;
            }
        }

            private void BindAddressFields(int value)
        {
            try
            {
                _address = new Address();
                var address = _address.GetById(value);
                txtStreet.Text = address.Street;
                txtCity.Text = address.City;
                ddlState.SelectedValue = address.State;
                txtZip.Text = address.Zip;
            }
            catch (Exception)
            {

                throw;
            }
        }

            private void ResetAddressForm()
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

            private void GetPetList(int personid)
            {
                try
                {
                    _pet = new Pet();
                    var bindsrc = new BindingSource();
                    bindsrc.DataSource = _pet.GetByPersonId(personid);
                    gridPets.DataSource = bindsrc.DataSource;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void GetPhoneList(int personid)
            {
                try
                {
                    _phone = new Phone();
                    var bindsrc = new BindingSource();
                    bindsrc.DataSource = _phone.GetAllByPersonId(personid);
                    gridPhones.DataSource = bindsrc.DataSource;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void GetPersonTypeCboList()
            {
                try
                {
                    _personType = new PersonType();
                    var bindsrc = new BindingSource();
                    bindsrc.DataSource = _personType.GetAll();
                    ddlPersonType.DataSource = bindsrc.DataSource;
                    ddlPersonType.DisplayMember = "Name";
                    ddlPersonType.ValueMember = "Id";
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
                    person = _person.GetById(personid);
                    lblPersonHeader.Text = person.FirstName + " " + person.LastName;
                    txtFirstName.Text = person.FirstName;
                    txtMiddleName.Text = person.MiddleName;
                    txtLastName.Text = person.LastName;
                    chkActive.Checked = person.Active;
                    txtEmail.Text = person.Email;
                    GetPetList(personid);
                    GetAddressList(personid);
                    ddlPersonType.SelectedValue = person.Type;
                }
                catch (Exception)
                {

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
                    txtFirstName.Focus();
                    IsNewPerson = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void SavePerson()
            {
                try
                {
                    _personType = new PersonType();
                    _person = new Person();
                    personType = _personType.GetById((int)ddlPersonType.SelectedValue);

                    if (!IsNewPerson)
                    {
                        var row = multicboPersonList.EditorControl.CurrentRow;
                        person = _person.GetById((int)row.Cells[1].Value);
                    }
                    else
                    {
                        person = new Person();
                    }

                    person.FirstName = txtFirstName.Text;
                    person.MiddleName = txtMiddleName.Text;
                    person.LastName = txtLastName.Text;
                    person.Active = chkActive.Checked;
                    person.Email = txtEmail.Text;
                    person.CreatedDate = DateTime.Now;
                    //personType = _personType.GetById((int)ddlPersonType.SelectedValue);
                    person.Type = ddlPersonType.SelectedValue.ToString();
                    person.Save(person);
                    BindPersonCbo();
                    ResetPersonFields();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void BindPersonGrid()
            {
                _person = new Person();
                var bindsrc = new BindingSource();
                bindsrc.DataSource = _person.GetAll();

            }

            private void BindPersonTypeList()
            {
                var bindsrc = new BindingSource();
                _personType = new PersonType();
                bindsrc.DataSource = _personType.GetAll();
                listPeopleTypes.DataSource = bindsrc.DataSource;
                listPeopleTypes.DataMember = "Id";
                listPeopleTypes.ValueMember = "Name";
            }

            private void BindPersonCbo()
            {
                var bindsrc = new BindingSource();
                _person = new Person();
                var people = _person.GetAll();

                var query = from person in people
                            select new { Id = person.Id, Name = person.LastName + ", " + person.FirstName };

                bindsrc.DataSource = query;
                multicboPersonList.DataSource = bindsrc.DataSource;
            }

            private void AddPersonType()
            {
                try
                {
                    if (_personType == null)
                    {
                        _personType = new PersonType();
                    }
                    var persontype = _personType.Get();
                    persontype.CreatedDate = DateTime.Now;
                    persontype.Name = txtPersonType.Text;
                    persontype.Save(persontype);
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
                    bindsrc.DataSource = Enum.GetValues(typeof(States));
                    ddlState.DataSource = bindsrc.DataSource;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void AddNewPhoneType()
            {
                try
                {
                    if (txtPhoneType.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a value for the Phone type.");
                        txtPhoneType.Focus();
                        return;
                    }

                    if (_phoneType == null)
                    {
                        _phoneType = new PhoneType();
                    }
                    phoneType = new PhoneType();
                    phoneType.Name = txtPhoneType.Text;
                    phoneType.CreatedDate = DateTime.Now;
                    _phoneType.Save(phoneType);
                    txtPhoneType.Clear();
                    BindPhoneTypeList(_phoneType);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        #endregion
    }
}
