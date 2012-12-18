using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CherishedPetBoarding.Model.Common;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Schedules;
using NHibernate;

namespace cpb
{
    public partial class frmMain : Form
    {
        private ISchedule _schedule;
        private IPerson _person;
        private IPersonType _personType;
        protected ISession _session = null;
        private IList<PersonType> _personTypes; 

        public frmMain()
        {
            InitializeComponent();
            this.radStatusStrip1.Text = DateTime.Now.ToLongDateString();
            this.lblDate.Text = DateTime.Now.ToLongDateString();

            if(_session == null)
            {
                _session = SessionManager.OpenSession();
            }
        }

        private void radMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        void BindPersonTypeList()
        {
            //EnumerationParser.EnumHelper.ToList(typeof(PersonType))
        }

        void ClearPersonForm()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            chkActive.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radPageView1.Visible = true;
            BindPersonTypeList();
            RebindPersonTypeList();
            BindPersonGrid();
        }

        private void btnAddPersonType_Click_1(object sender, EventArgs e)
        {
            AddNewPersonType();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddNewPerson();
            BindPersonGrid();
        }

        private void BindPersonGrid()
        {
            try
            {
                if(_person == null)
                {
                    _person = new Person();
                }
                var person = _person.GetAll();
                var bind = new BindingSource();
                bind.DataSource = person;
                gridPersonList.DataSource = bind.DataSource;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void RebindPersonTypeList()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    if (_personType == null)
                    {
                        _personType = new PersonType();      
                    }
                    _personTypes = _personType.GetAll();
                    var t = new BindingSource();
                    t.DataSource = _personTypes;
                    ddlPersonType.DataSource = t.DataSource;
                    ddlPersonType.DisplayMember = "Name";
                    ddlPersonType.ValueMember = "Id";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        #region "Class Methods"
        private void AddNewPerson()
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Enter data to save a new person.");
                return;
            }
            btnAddNewPerson.Enabled = false;
            _person = new Person();
            var person = _person.Get();
            person.FirstName = txtFirstName.Text;
            person.MiddleName = txtMiddleName.Text;
            person.LastName = txtLastName.Text;
            person.Active = chkActive.Checked;
            person.CreatedDate = DateTime.Now;
            person.Type = (int)ddlPersonType.SelectedValue;
            _person.Save(person);
            ClearPersonForm();
            btnAddNewPerson.Enabled = true;
        }

        private void AddNewPersonType()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    if (txtPersonType.Text == "")
                    {
                        MessageBox.Show("Person Type cannot be empty.");
                        return;
                    }
                    if (_personType == null)
                    {
                        _personType = new PersonType();
                    }
                    repository.BeginTransaction();
                    var t = repository.ToList<PersonType>();
                    var persontype = _personType.Get();
                    persontype.CreatedDate = DateTime.Now;
                    persontype.Name = txtPersonType.Text;
                    repository.Save(persontype);
                    repository.CommitTransaction();
                    RebindPersonTypeList();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }
        #endregion
    }
}
