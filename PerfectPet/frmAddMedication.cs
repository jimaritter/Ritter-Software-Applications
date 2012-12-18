using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Pets;

namespace PerfectPet
{
    public partial class frmAddMedication : Form
    {

        private Medication medication;
        private IMedication _medication;
        private Pet pet;
        private IPet _pet;
        public int PetId { get; set; }

        public frmAddMedication()
        {
            InitializeComponent();
        }

        private void frmAddMedication_Load(object sender, EventArgs e)
        {
            medication = new Medication();
            _medication = new Medication();
            pet = new Pet();
            _pet = new Pet();
        }

        #region
        private void AddMedication()
        {
            try
            {
                pet = _pet.GetById(PetId);
                medication.Name = txtName.Text;
                medication.Quantity = txtQuantity.Text;
                medication.Description = txtDescription.Text;
                medication.Directions = txtDirections.Text;
                medication.CreatedDate = DateTime.Now;
                medication.Pet = pet;
                _medication.Save(medication);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            try
            {
                AddMedication();
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
