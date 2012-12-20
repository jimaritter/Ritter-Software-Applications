using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet
{
    public partial class frmCheckIn : Form
    {

        public int PersonId { get; set; }
        public int PetId { get; set; }

        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.Default;
                BindCustomerDropDownList();
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                throw;
            }

        }

        #region

        private void BindCustomerDropDownList()
        {
            try
            {
                var _person = ObjectFactory.GetInstance<IPerson>();
                var person = _person.CustomerList("Customer");
                var query = from i in person
                            select new { Id = i.Id, Name = i.Number + " - " + i.LastName + ", " + i.FirstName };
                ddlCustomerDropDownList.DataSource = query;
                ddlCustomerDropDownList.DisplayMember = "Name";
                ddlCustomerDropDownList.ValueMember = "Id";
            }
            catch (Exception)
            {
                
                throw;
            }    
        }

        private void BindPetDropDownList()
        {
            try
            {
                var _pet = ObjectFactory.GetInstance<IPet>();
                var pet = _pet.GetByPersonId(PersonId);
         
                if(pet.Count() != 0)
                {
                    var query = from item in pet
                                select new { Id = item.PetId, Name = item.Name };

                    ddlPet.DataSource = query;
                    ddlPet.DisplayMember = "Name";
                    ddlPet.ValueMember = "Id";
                    ddlPet.Enabled = true;
                    btnSelectPet.Enabled = true;


                }else
                {
                    lblCustomer.Text = "";
                    ddlPet.Enabled = false;
                    btnSelectPet.Enabled = false;
                    tabCheckIn.Enabled = false;
                }

             }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if((int)ddlCustomerDropDownList.SelectedIndex != -1)
                {
                    PersonId = (int) ddlCustomerDropDownList.SelectedValue;
                    ddlPet.Text = "";
                    ddlPet.DataSource = null;
                    BindPetDropDownList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnSelectPet_Click(object sender, EventArgs e)
        {
            try
            {
                if(ddlPet.SelectedIndex != -1)
                {
                    var _person = ObjectFactory.GetInstance<IPerson>();
                    var person = _person.GetById(PersonId);
                    tabCheckIn.Enabled = true;
                    PetId = (int) ddlPet.SelectedValue;
                    lblCustomer.Text = person.FirstName + " " + person.LastName;
                    lblPet.Text = ddlPet.Text;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var _checkin = ObjectFactory.GetInstance<IArrivalDeparture>();
                var checkin = _checkin.Get();
                var _pet = ObjectFactory.GetInstance<IPet>();
                var pet = _pet.GetById(PetId);
                checkin.Pet = pet;
                checkin.Name = pet.Name;
                checkin.ArriveDate = Convert.ToDateTime(dateCheckIn.Text);
                checkin.DepartureDate = Convert.ToDateTime(dateCheckOut.Text);
                checkin.Notes = txtNotes.Text;
                checkin.CheckedIn = true;
                pet.IsCheckedIn = true;
                _checkin.Save(checkin);
                _pet.Save(pet);
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
