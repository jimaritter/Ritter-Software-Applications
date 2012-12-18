using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Phones;

namespace PerfectPet
{
    public partial class frmAddPhoneType : Form
    {
        private IPhoneType _phoneType;
        private PhoneType phoneType;
        public frmAddPhoneType()
        {
            InitializeComponent();
        }

        private void frmAddPhoneType_Load(object sender, EventArgs e)
        {
            try
            {
                _phoneType = new PhoneType();
                phoneType = new PhoneType();
                BindPhoneTypeList(_phoneType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region
        private void BindPhoneTypeList(IPhoneType phoneType)
        {
            try
            {
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

        private void btnAddPersonType_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewPhoneType();
                BindPhoneTypeList(_phoneType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
