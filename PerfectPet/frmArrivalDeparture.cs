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
using StructureMap;

namespace PerfectPet
{
    public partial class frmArrivalDeparture : Form
    {
        public frmArrivalDeparture()
        {
            InitializeComponent();
        }

        private void frmArrivalDeparture_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            tabParent.SelectedPage = tabArrivals;
            BindArrivalGrid();
            BindDepartureGrid();
        }

        private void BindArrivalGrid()
        {
            try
            {
                var _arrival = ObjectFactory.GetInstance<IArrivalDeparture>();
                var arrival = _arrival.GetAll();
                var query = from item in arrival
                            where item.ArriveDate == DateTime.Now.ToShortDateString()
                            select item;
                gridArrivals.DataSource = query.ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindDepartureGrid()
        {
            try
            {
                var _arrival = ObjectFactory.GetInstance<IArrivalDeparture>();
                var arrival = _arrival.GetAll();
                var query = from item in arrival
                            where item.DepartureDate == DateTime.Now.ToShortDateString()
                            select item;
                gridDepartures.DataSource = query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
