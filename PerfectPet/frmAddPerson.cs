using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;

namespace PerfectPet
{
    public partial class frmAddPerson : Form
    {
        private IPersonType _personType;
        private IPerson _person;
        private Person person;
        private PersonType personType;

        private bool IsNewPerson;

        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            GetPersonTypeList();
        }

        #region "Class Methods"
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

        private void GetPersonTypeList()
        {
            try
            {
                _personType = new PersonType();
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(PersonTypeList));
                ddlPersonType.DataSource = bindsrc.DataSource;
                //ddlPersonType.DisplayMember = "Name";
                //ddlPersonType.ValueMember = "Id";
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
                person = new Person();
                personType = _personType.GetById((int)ddlPersonType.SelectedValue);
                person.FirstName = txtFirstName.Text;
                person.MiddleName = txtMiddleName.Text;
                person.LastName = txtLastName.Text;
                person.Active = chkActive.Checked;
                person.Email = txtEmail.Text;
                person.CreatedDate = DateTime.Now;
                //personType = _personType.GetById((int)ddlPersonType.SelectedValue);
                person.Type = ddlPersonType.SelectedValue.ToString();
                person.Save(person);
                ResetPersonFields();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion



        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for the first and last name before adding");
                    return;
                }
                SavePerson();
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
