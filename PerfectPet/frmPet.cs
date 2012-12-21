using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet
{
    public partial class frmPet : Form
    {
        private bool _isNew;
        public int PersonId { get; set; }
        public int PetId { get; set; }

        public frmPet()
        {
            InitializeComponent();
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.Default;
                BindCustomerList();
                GetTempermentList();
                GetSizeList();
                GetSpeciesList();
                GetSexList();
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                throw;
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if (ddlCustomer.SelectedIndex == -1)
            {
                return;
            }
            BindPetListView();
        }

        #region

            private void BindCustomerList()
            {
                ddlCustomer.Text = "";
                var person = ObjectFactory.GetInstance<IPerson>();
                var people = person.CustomerList("Customer");
                var query = from i in people
                            select new { Id = i.Id, Name = i.Number + " - " + i.LastName + ", " + i.FirstName };
                ddlCustomer.DataSource = query.ToList();
                ddlCustomer.DisplayMember = "Name";
                ddlCustomer.ValueMember = "Id";
            }

            private void BindPetListView()
            {
                try
                {
                    PersonId = (int) ddlCustomer.SelectedValue;
                    var _pets = ObjectFactory.GetInstance<IPet>();
                    var pets = _pets.GetByPersonId((int)ddlCustomer.SelectedValue);
                    var query = from i in pets
                                select new { Id = i.PetId, Name = i.Name };
                    listPets.DataSource = query.ToList();
                    listPets.DisplayMember = "Name";
                    listPets.ValueMember = "Id";
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

        private void BindMedicationDetails()
        {
            try
            {
                if(listPets.SelectedItem.Value == null)
                {
                    return;
                }
                var _medication = ObjectFactory.GetInstance<IMedication>();
                var medication = _medication.GetByPetId(PetId);
                listMedications.DataSource = medication;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindPetDetails()
        {
            try
            {
                if(listPets.SelectedItem.Value == null)
                {
                    return;
                }
                var _pet = ObjectFactory.GetInstance<IPet>();
                var pet = _pet.GetById((int) listPets.SelectedItem.Value);
                if(pet == null)
                {
                    return;
                }

                PetId = pet.PetId;

                txtName.Text = pet.Name;
                txtAge.Text = pet.Age.ToString();
                txtNotes.Text = pet.Notes;
                txtDiet.Text = pet.Diet;
                txtColor.Text = pet.Color;
                txtWeight.Text = pet.Weight;
                ddlPetSex.Text = pet.Sex ?? "";
                ddlSize.Text = pet.Size ?? "";
                ddlTemperment.Text = pet.Temperment ?? "";
                ddlSpecies.Text = pet.Species ?? "";
                ddlBreedList.Text = pet.Breed ?? "";
                chkBiter.Checked = pet.Biter;
                chkDeceased.Checked = pet.Deceased;
                chkMedications.Checked = pet.HasMedications;
                chkVaccinated.Checked = pet.Vaccintated;
                if (pet.Picture != null)
                {
                    MemoryStream stmBLOBData = new MemoryStream(pet.Picture);
                    picPet.Image = Image.FromStream(stmBLOBData);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SavePetDetails()
        {
            try
            {
                var _pet = ObjectFactory.GetInstance<IPet>();
                Pet pet;
                if(_isNew)
                {
                    pet = _pet.Get();
                }else
                {
                    pet = _pet.GetById((int)listPets.SelectedItem.Value);  
                }
                
                if (pet == null)
                {
                    return;
                }

                var _person = ObjectFactory.GetInstance<IPerson>();
                var person = _person.GetById(PersonId);

                pet.Name = txtName.Text;
                pet.Age = Convert.ToInt32(txtAge.Text);
                pet.Notes = txtNotes.Text;
                pet.Diet = txtDiet.Text;
                pet.Color = txtColor.Text;
                pet.Weight = txtWeight.Text;
                pet.Sex = (string) ddlPetSex.Text;
                pet.Size = (string)ddlSize.Text;
                pet.Temperment = (string)ddlTemperment.Text;
                pet.Species = (string)ddlSpecies.Text;
                pet.Breed = (string)ddlBreedList.Text;
                pet.Biter = chkBiter.Checked;
                pet.Deceased = chkDeceased.Checked;
                pet.HasMedications = chkMedications.Checked;
                pet.Vaccintated = chkVaccinated.Checked;
                pet.Person = person;

                if (picPet.Image != null)
                {
                    pet.Picture = ImageTool.ConvertImageToByteArray(picPet.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                _pet.Save(pet);
                BindPetListView();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ClearPetDetails()
        {
            try
            {
                txtName.Clear();
                txtAge.Clear();
                txtNotes.Clear();
                txtDiet.Clear();
                txtColor.Clear();
                txtWeight.Clear();
                ddlPetSex.SelectedIndex = 1;
                ddlSize.SelectedIndex = 1;
                ddlTemperment.SelectedIndex = 1;
                ddlSpecies.SelectedIndex = 1;
                ddlBreedList.SelectedIndex = 1;
                chkBiter.Checked = false;
                chkDeceased.Checked = false;
                chkMedications.Checked = false;
                chkVaccinated.Checked = false;
                picPet.Image = null;
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
                var item = ObjectFactory.GetInstance<IDogBreed>();
                var bindsrc = new BindingSource();
                bindsrc.DataSource = item.GetAll();
                ddlBreedList.DataSource = bindsrc.DataSource;
                ddlBreedList.ValueMember = "Name";
                ddlBreedList.DataMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindFelineBreedList()
        {
            try
            {
                var item = ObjectFactory.GetInstance<ICatBreed>();
                var bindsrc = new BindingSource();
                bindsrc.DataSource = item.GetAll();
                ddlBreedList.DataSource = bindsrc.DataSource;
                ddlBreedList.ValueMember = "Name";
                ddlBreedList.DataMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetSexList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(PetSexes));
                ddlPetSex.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
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

        private void GetSpeciesList()
        {
            try
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = Enum.GetValues(typeof(Species));
                ddlSpecies.DataSource = bindsrc.DataSource;
            }
            catch (Exception exception)
            {

            }
        }
        #endregion

            private void listPets_SelectedItemChanged(object sender, EventArgs e)
            {
                BindPetDetails();
            }



        private void listPets_ItemMouseClick(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            this.picPet.Image = null;
            _isNew = false;
            ClearPetDetails();
            BindPetDetails();
            BindMedicationDetails();
        }

        private void ddlSpecies_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSavePet_Click(object sender, EventArgs e)
        {
            SavePetDetails();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isNew = true;
            PersonId = (int)ddlCustomer.SelectedValue;
            ClearPetDetails();
        }

        private void listMedications_ItemMouseClick(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {

        }
    }
}
