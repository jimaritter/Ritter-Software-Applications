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
    public partial class frmEditPerson : Form
    {
        private IPersonType _personType;
        private IPerson _person;
        private Person person;
        private PersonType personType;

        public int PersonId { get; set; }

        public frmEditPerson()
        {
            InitializeComponent();
        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {
            GetPersonTypeList();
            BindPersonDetails();
        }

        #region "Class Methods"
        private void BindPersonDetails()
        {
            try
            {
                person = new Person();
                _person = new Person();
                person = _person.GetById(PersonId);
                txtFirstName.Text = person.FirstName;
                txtMiddleName.Text = person.MiddleName;
                txtLastName.Text = person.LastName;
                chkActive.Checked = person.Active;
                txtEmail.Text = person.Email;
                ddlPersonType.SelectedValue = person.Type;
            }
            catch (Exception)
            {

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
                if (person == null)
                {
                    person = new Person();
                }
                _personType = new PersonType();
                _person = new Person();
                personType = _personType.GetById(PersonId);
                person.FirstName = txtFirstName.Text;
                person.MiddleName = txtMiddleName.Text;
                person.LastName = txtLastName.Text;
                person.Active = chkActive.Checked;
                person.Email = txtEmail.Text;
                person.CreatedDate = DateTime.Now;
                person.Type = ddlPersonType.SelectedValue.ToString();
                person.Save(person);
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
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    txtFirstName.Focus();
                    MessageBox.Show("You must enter in a first and last name before saving");
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
