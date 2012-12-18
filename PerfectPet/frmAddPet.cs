using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;

namespace PerfectPet
{
    public partial class frmAddPet : Form
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
        private int PetId { get; set; }
        public frmAddPet()
        {
            InitializeComponent();
        }

        private void frmAddPet_Load(object sender, EventArgs e)
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
            txtName.Focus();
        }

        #region "Class Methods"

        private void SavePet()
        {
            //Console.WriteLine(ddlSize.SelectedValue.ToString());
            //Console.WriteLine(ddlSize.SelectedText);
            //Console.WriteLine(ddlSize.SelectedItem.ToString());
            int Age;
            bool result = Int32.TryParse(txtAge.Text, out Age);
            person = new Person();
            _person = new Person();
            person = _person.GetById(PersonId);
            pet.Name = txtName.Text;
            pet.Age = Age;
            pet.Weight = txtWeight.Text;
            pet.Color = txtColor.Text;
            pet.Size = ddlSize.SelectedItem.ToString();
            pet.Species = ddlSpecies.SelectedItem.ToString();
            pet.Biter = chkBiter.Checked;
            pet.Breed = ddlBreedList.SelectedItem.ToString();
            pet.Temperment = ddlTemperment.SelectedItem.ToString();
            pet.Deceased = chkDeceased.Checked;
            pet.CreatedDate = DateTime.Now;
            pet.Diet = txtDiet.Text;
            pet.Notes = txtNotes.Text;
            pet.Person = person;
            if(picPet.Image != null)
            {
                pet.Picture = ImageTool.ConvertImageToByteArray(picPet.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            _pet.Save(pet);
        }

        private void GetSpeciesList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(Species));
                ddlSpecies.DataSource = bindsrc.DataSource;
            }catch(Exception exception)
            {
                
            }
        }

        private void GetSizeList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(PetSize));
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

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            try
            {
                addMedication = new frmAddMedication();
                addMedication.PetId = PetId;
                addMedication.ShowDialog(this);
             }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ddlSpecies_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var row  = ddlSpecies.SelectedValue.ToString();
            if (row == Species.Canine.ToString())
            {
                BindDogBreedList();
            }
            if (row == Species.Feline.ToString())
            {
                BindFelineBreedList();
            }
        }

        private void linklblChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "JPG Image of Pet";
                dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (dlg.ShowDialog() == DialogResult.OK)
                 {
                          this.picPet.Image = new Bitmap(dlg.OpenFile());
                  }
                dlg.Dispose();
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
