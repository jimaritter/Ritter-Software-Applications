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
using PerfectPet.Model.Pets;

namespace PerfectPet
{
    public partial class frmEditPet : Form
    {
        private frmAddMedication addMedication;
        private IPet _pet;
        private Pet pet;
        private IEnumerable<Pet> pets;
        private Medication medication;
        private IMedication _medication;
        private IEnumerable<Medication> medications;
        private Person person;
        private IPerson _person;
        private IDogBreed _dogBreed;
        private IList<DogBreed> dogBreeds;
        private DogBreed dogBreed;
        private ICatBreed _catBreed;
        private IList<CatBreed> catBreeds;
        private CatBreed catBreed;
        public int PersonId { get; set; }
        public int PetId { get; set; }

        public frmEditPet()
        {
            InitializeComponent();
        }

        private void frmEditPet_Load(object sender, EventArgs e)
        {
            try
            {             
                _pet = new Pet();
                pet = new Pet();
                dogBreed = new DogBreed();
                _dogBreed = new DogBreed();
                catBreed = new CatBreed();
                _catBreed = new CatBreed();
                GetSpeciesList();
                GetSizeList();
                GetTempermentList();
                GetPetDetails();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region

        private void GetSizeList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(PetSize));
                ddlSize.DataSource = bindsrc.DataSource;
            }
            catch (Exception exception)
            {

            }
        }

        private void GetTempermentList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(Temperment));
                ddlTemperment.DataSource = bindsrc.DataSource;
            }
            catch (Exception exception)
            {

            }
        }

        private void BindFelineBreedList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = _catBreed.GetAll();
                ddlBreedList.DataSource = bindsrc.DataSource;
                ddlBreedList.ValueMember = "Name";
                ddlBreedList.DataMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindDogBreedList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = _dogBreed.GetAll();
                ddlBreedList.DataSource = bindsrc.DataSource;
                ddlBreedList.ValueMember = "Name";
                ddlBreedList.DataMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetPetDetails()
        {
            try
            {
                pet = _pet.GetById(PetId);
                txtName.Text = pet.Name;
                txtAge.Text = pet.Age.ToString();
                txtColor.Text = pet.Color;
                txtDiet.Text = pet.Diet;
                ddlSize.SelectedValue = pet.Size;
                txtWeight.Text = pet.Weight;
                txtNotes.Text = pet.Notes;
                ddlBreedList.SelectedValue = pet.Breed;
                ddlSpecies.SelectedValue = pet.Species;
                ddlTemperment.SelectedValue = pet.Temperment;
                chkBiter.Checked = pet.Biter;
                chkDeceased.Checked = pet.Deceased;
                chkVaccinated.Checked = pet.Vaccintated;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetSpeciesList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(Species));
                ddlSpecies.DataSource = bindsrc.DataSource;
                ddlSpecies.SelectedValue = Species.Canine;
            }
            catch (Exception exception)
            {

            }
        }

        private void SavePet()
        {
            int Age;
            bool result = Int32.TryParse(txtAge.Text, out Age);
            pet = _pet.GetById(PetId);
            person = new Person();
            _person = new Person();
            person = _person.GetById(PersonId);
            pet.Name = txtName.Text;
            pet.Age = Age;
            pet.Color = txtColor.Text;
            pet.Size = ddlSize.SelectedValue.ToString();
            pet.Weight = txtWeight.Text;
            pet.Species = ddlSpecies.SelectedValue.ToString();
            pet.Biter = chkBiter.Checked;
            pet.Breed = ddlBreedList.SelectedValue.ToString();
            pet.Temperment = ddlTemperment.SelectedValue.ToString();
            pet.Deceased = chkDeceased.Checked;
            pet.CreatedDate = DateTime.Now;
            pet.Diet = txtDiet.Text;
            pet.Notes = txtNotes.Text;
            pet.Person = person;
            _pet.Save(pet);
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SavePet();
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ddlSpecies_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var row = ddlSpecies.SelectedValue.ToString();
            if (row == Species.Canine.ToString())
            {
                BindDogBreedList();
            }
            if (row == Species.Feline.ToString())
            {
                BindFelineBreedList();
            }
        }
    }
}
