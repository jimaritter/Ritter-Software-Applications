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
    public partial class frmAddAddress : Form
    {

        public int PersonId { get; set; }
        private Address address;
        private IAddress _address;
        private IAddressType _addressType;
        private AddressType addressType;
        private IPerson _person;
        private Person person;

        public frmAddAddress()
        {
            InitializeComponent();
        }

        private void frmAddAddress_Load(object sender, EventArgs e)
        {
            try
            {
                _address = new Address();
                address = new Address();
                _addressType = new AddressType();
                addressType = new AddressType();
                BindAddressTypeList(_addressType);
                BindStateList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region

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

        private void AddAddress()
        {
            try
            {
                address.Street = txtStreet.Text;
                address.City = txtCity.Text;
                address.CreatedDate = DateTime.Now;
                address.State = Enum.GetName(typeof(States),ddlState.SelectedValue);
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

        private void BindAddressTypeList(IAddressType type)
        {
            try
            {
                if (type == null)
                {
                    type = new AddressType();
                }
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(AddressTypeList));
                ddlAddressType.DataSource = bindsrc.DataSource;
                //ddlAddressType.DataMember = "Id";
                //ddlAddressType.ValueMember = "Name";

            }
            catch (Exception)
            {

                throw;
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

        private void ClearAddressFields()
        {
            txtCity.Clear();
            txtStreet.Clear();
            txtZip.Clear();
        }
        #endregion

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                AddAddress();
                ClearAddressFields();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
