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

namespace PerfectPet
{
    public partial class frmEditAddress : Form
    {
        private IAddress _address;
        private Address address;
        private Person person;
        private IPerson _person;
        public int AddressId { get; set; }
        public int PersonId { get; set; }

        #region
        private void GetAddressDetails()
        {
            address = _address.GetById(AddressId);
            txtCity.Text = address.City;
            txtStreet.Text = address.Street;
            txtZip.Text = address.Zip;
            ddlAddressType.SelectedText = address.Type;
            ddlState.SelectedText = address.State;
        }

        private Person GetPerson(int personid)
        {
            try
            {
                person = new Person();
                _person = new Person();
                person = _person.GetById(personid);
                return person;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        private void SaveAddress()
        {
            try
            {
                address.Street = txtStreet.Text;
                address.City = txtCity.Text;
                address.CreatedDate = DateTime.Now;
                address.State = Enum.GetName(typeof(States), ddlState.SelectedValue);
                address.Zip = txtZip.Text;
                address.Type = Enum.GetName(typeof(AddressTypeList), ddlAddressType.SelectedValue);
                address.Person = GetPerson(PersonId);
                _address.Save(address);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        public frmEditAddress()
        {
            InitializeComponent();
        }

        private void frmEditAddress_Load(object sender, EventArgs e)
        {
            _address = new Address();
            address = new Address();
            BindStateList();
            BindAddressTypeList();
            GetAddressDetails();
        }

        private void BindAddressTypeList()
        {
            try
            {
                ddlAddressType.DataSource = Enum.GetValues(typeof(AddressTypeList));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindStateList()
        {
            ddlState.DataSource = Enum.GetValues(typeof(States));
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAddress();
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
