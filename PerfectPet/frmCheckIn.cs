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
                BindResourceList();
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                throw;
            }

        }

        #region

        private void BindResourceList()
        {
            try
            {
                var _resource = ObjectFactory.GetInstance<IResources>();
                var resource = _resource.GetAll();
                var query = from i in resource
                            orderby i.Name ascending
                            select new {Id = i.Id, Name = i.Name};
                ddlResource.DataSource = query.ToList();
                ddlResource.DisplayMember = "Name";
                ddlResource.ValueMember = "Id";
            }
            catch (Exception)
            {
                
                throw;
            }
        }

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
                var _resource = ObjectFactory.GetInstance<IResources>();
                var resource = _resource.GetById((int)ddlResource.SelectedValue);
                var _appointment = ObjectFactory.GetInstance<IAppointments>();
                var appointment = _appointment.Get();

                var checkindate = Convert.ToDateTime(dateCheckInDate.Text).ToShortDateString() + " " +
                                  Convert.ToDateTime(dateCheckInTime.Value).ToShortTimeString();

                var checkoutdate = Convert.ToDateTime(dateCheckOutDate.Text).ToShortDateString() + " " +
                  Convert.ToDateTime(dateCheckOutTime.Value).ToShortTimeString();

                //Save the check in values to the ArrivalDeparture object
                checkin.Pet = pet;
                checkin.Name = pet.Name;
                checkin.ArriveDate = Convert.ToDateTime(dateCheckInDate.Text).ToShortDateString();
                checkin.DepartureDate = Convert.ToDateTime(dateCheckOutDate.Text).ToShortDateString();
                checkin.ArriveTime = Convert.ToDateTime(dateCheckInTime.Value).ToShortTimeString();
                checkin.DepartureTime = Convert.ToDateTime(dateCheckOutTime.Value).ToShortTimeString();
                checkin.Notes = txtNotes.Text;
                checkin.CheckedIn = true;
                checkin.Resources = resource;
                
                //Set the Checked in bool value in Pet Object
                pet.IsCheckedIn = true;

                //Save the appointment info to the Appointment object
                appointment.Start = Convert.ToDateTime(checkindate);
                appointment.EndDate = Convert.ToDateTime(checkoutdate);
                appointment.Resource = resource;
                appointment.Summary = txtNotes.Text;
                _appointment.Save(appointment);

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
