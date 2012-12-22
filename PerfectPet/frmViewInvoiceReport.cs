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
    public partial class frmViewInvoiceReport : Form
    {
        public int CompanyId { get; set; }
        public int InvoiceId { get; set; }
 
        public frmViewInvoiceReport()
        {
            InitializeComponent();
        }

        private void frmViewInvoiceReport_Load(object sender, EventArgs e)
        {
            var _company = ObjectFactory.GetInstance<ICompany>();
            var company = _company.GetById(CompanyId);
            var _invoice = ObjectFactory.GetInstance<IInvoice>();
            var invoice = _invoice.GetById(InvoiceId);
            var _lineitems = ObjectFactory.GetInstance<ILineItem>();
            var lineitems = _lineitems.GetAllByInvoiceId(InvoiceId);


            var rpt = new InvoiceReport(company, invoice, lineitems);
            this.invoiceReportViewer.ReportSource = rpt;
            this.invoiceReportViewer.RefreshReport();
        }
    }
}
