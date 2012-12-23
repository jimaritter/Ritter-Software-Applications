using System.Collections.Generic;
using System.IO;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Companies;
using PerfectPet.Model.Sales;
using StructureMap;

namespace PerfectPet
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for InvoiceReport.
    /// </summary>
    public partial class InvoiceReport : Telerik.Reporting.Report, INotifyPropertyChanged
    {
     
        private Company _company;
        private Invoice _invoice;
        private IList<LineItem> _lineItems;

        public InvoiceReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            FillCompanyInformation();
        }

        public InvoiceReport(Company company, Invoice invoice, IList<LineItem> lineItems)
        {
            InitializeComponent();
            _company = company;
            _invoice = invoice;
            _lineItems = lineItems;
            FillCompanyInformation();
            FillInvoiceHeader();
            this.ReportParameters["invoiceid"].Value = _invoice.InvoiceId;
            //FillInvoiceDetails(); 
        }

        private void FillInvoiceHeader()
        {
            try
            {
                var _address = ObjectFactory.GetInstance<IAddress>();
                var person = Invoice.Person;
                var address = Invoice.InvoiceAddress;
                txtBillToName.Value = person.FirstName + " " + person.LastName;
                txtBillToAddress.Value = address.Street + " " + address.City + " " + address.State + " " + address.Zip;
                txtBillToPhone.Value = person.Phone;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FillCompanyInformation()
        {
            try
            {
                MemoryStream stmBLOBData = new MemoryStream(Company.Logo);
                picLogo.Value = Image.FromStream(stmBLOBData);
                txtCompany.Value = Company.CompanyName;
                txtAddress.Value = Company.Street + " " + Company.City + " " + Company.State + " " + Company.Zip;
                txtPhone.Value = Company.Phone;
                txtWeb.Value = Company.Web;
                txtTax.Value = Company.TaxRate.ToString();
                txtTaxNumber.Value = Company.TaxNumber;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FillInvoiceDetails()
        {
            try
            {
                foreach (var item in LineItems)
                {
                    txtItem.Value = item.Product.Name;
                    txtRetail.Value = item.UnitPrice.ToString();
                    txtQuantity.Value = item.Quantity.ToString();
                    txtSubTotal.Value = item.LineTotal.ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Company Company
        {
            get { return this._company; }
            set
            {
                if (this._company != value)
                {
                    this._company = value;
                    OnPropertyChanged("Company");
                }
            }
        }

        public Invoice Invoice
        {
            get { return this._invoice; }
            set
            {
                if (this._invoice != value)
                {
                    this._invoice = value;
                    OnPropertyChanged("Invoice");
                }
            }
        }        
        
        public IList<LineItem> LineItems
        {
            get { return this._lineItems; }
            set
            {
                if(this._lineItems != value)
                {
                    this._lineItems = value;
                    OnPropertyChanged("LineItems");
                }
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}