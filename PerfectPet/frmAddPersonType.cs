using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.People;

namespace PerfectPet
{
    public partial class frmAddPersonType : Form
    {
        private IPersonType _personType;
        private IPerson _person;
        private Person person;
        private PersonType personType;

        public frmAddPersonType()
        {
            InitializeComponent();
        }

        #region
        private void BindPersonTypeList()
        {
            var bindsrc = new BindingSource();
            bindsrc.DataSource = _personType.GetAll();
            listPeopleTypes.DataSource = bindsrc.DataSource;
            listPeopleTypes.DataMember = "Id";
            listPeopleTypes.ValueMember = "Name";
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
        #endregion

        private void frmAddPersonType_Load(object sender, EventArgs e)
        {
            _personType = new PersonType();
            personType = new PersonType();
            BindPersonTypeList();

        }

        private void btnAddPersonType_Click(object sender, EventArgs e)
        {
            try
            {
                AddPersonType();
                BindPersonTypeList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
