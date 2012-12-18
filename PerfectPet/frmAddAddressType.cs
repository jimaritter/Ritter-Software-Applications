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

namespace PerfectPet
{
    public partial class frmAddAddressType : Form
    {
        private IAddressType _addressType;
        private AddressType addressType;

        public frmAddAddressType()
        {
            InitializeComponent();
        }

        #region
        private void BindAddressTypeList(IAddressType type)
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = type.GetAll();
                listAddressTypes.DataSource = bindsrc.DataSource;
                listAddressTypes.DataMember = "Id";
                listAddressTypes.ValueMember = "Name";
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
        #endregion

        private void frmAddAddressType_Load(object sender, EventArgs e)
        {
            try
            {
                _addressType = new AddressType();
                addressType = new AddressType();
                BindAddressTypeList(_addressType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnAddPersonType_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewAddressType();
                BindAddressTypeList(_addressType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
