using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Companies;
using StructureMap;

namespace PerfectPet
{
    public partial class frmHome : Form
    {
        private frmCustomer formCustomer;
        private frmResources _formResources;
        private frmBooking formBooking;
        private frmSettings formSettings;
        private frmInvoice formInvoice;
        private frmInvoice _formInvoice;
        private frmCheckIn _formCheckIn;
        private frmCheckOut _formCheckOut;
        private frmPet _formPet;
        private frmViewInvoiceReport formInvoiceReport;
        private frmProductServices formProductsServices;
        private frmArrivalDeparture formArrivalDeparture;

        public frmHome()
        {
            InitializeComponent();
            this.Text = Program.AppTitle + " - " + "Home";
            this.lblTodaysDate.Text = DateTime.Now.ToLongDateString();
            this.lblApplicationVersion.Text = "ver: " + Application.ProductVersion;
            var _company = ObjectFactory.GetInstance<ICompany>();
            var company = _company.GetAll();
            
            if(company.Count == 0)
            {
                Program.CompanyExists = false;
            }else
            {
                Program.CompanyId = company[0].Id;
                Program.CompanyExists = true;
            }

            if(Program.CompanyExists == false)
            {
                if (MessageBox.Show("Your company information has not been setup. \n In order to continue you must provide your company information. \n Setup now?", "Setup Company", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    formSettings = new frmSettings();
                    formSettings.ShowDialog(this);
                }else
                {
                    linkCustomerAndPets.Enabled = false;
                    linkBookings.Enabled = false;
                    linkResources.Enabled = false;
                }
            }
            // 
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void linkBookings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formBooking = new frmBooking();
            formBooking.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkResources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formResources = new frmResources();
            _formResources.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkCustomerAndPets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formCustomer = new frmCustomer();
            formCustomer.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void lblInvoicing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formInvoice = new frmInvoice();
            formInvoice.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkNewWorkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formInvoice = new frmInvoice();
            _formInvoice.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkCheckIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formCheckIn = new frmCheckIn();
            _formCheckIn.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkCheckOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formCheckOut = new frmCheckOut();
            _formCheckOut.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkPets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formPet = new frmPet();
            _formPet.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formInvoiceReport = new frmViewInvoiceReport();
            formInvoiceReport.Show();
        }

        private void linkCompanyInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formSettings = new frmSettings();
            formSettings.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkProductsServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formProductsServices = new frmProductServices();
            formProductsServices.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void linkArrivalsDepartures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            formArrivalDeparture = new frmArrivalDeparture();
            formArrivalDeparture.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }
    }
}
