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
using PerfectPet.Model.Sales;
using StructureMap;

namespace PerfectPet
{
    public partial class frmInvoiceLookup : Form
    {
        private frmViewInvoiceReport formInvoiceReport;

        public frmInvoiceLookup()
        {
            InitializeComponent();
        }

        private void frmInvoiceLookup_Load(object sender, EventArgs e)
        {
            BindInvoiceGrid();
        }

        private void BindInvoiceGrid()
        {
            try
            {
                var _invoices = ObjectFactory.GetInstance<IInvoice>();
                var invoices = _invoices.GetAll();
                var query = from inv in invoices
                            select
                                new
                                    {
                                        InvoiceId = inv.InvoiceId,
                                        Number = inv.Number,
                                        InvoiceDate = inv.InvoiceDate.ToShortDateString(),
                                        Customer = inv.Person.LastName + ", " + inv.Person.FirstName
                                    };

                gridInvoices.DataSource = query;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var _invoice = ObjectFactory.GetInstance<IInvoice>();
                var invoice = _invoice.GetById((int)gridInvoices.CurrentRow.Cells[0].Value);

                var _company = ObjectFactory.GetInstance<ICompany>();
                var company = _company.GetById(1002);

                var _lineitems = ObjectFactory.GetInstance<ILineItem>();
                var lineitem = _lineitems.GetAllByInvoiceId((int) gridInvoices.CurrentRow.Cells[0].Value);

                formInvoiceReport = new frmViewInvoiceReport();
                formInvoiceReport.InvoiceId = (int) gridInvoices.CurrentRow.Cells[0].Value;
                formInvoiceReport.CompanyId = 1002;
                formInvoiceReport.ShowDialog(this);

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
