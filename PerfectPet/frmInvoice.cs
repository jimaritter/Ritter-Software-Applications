using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Companies;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Products;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;
using PerfectPet.Model.Workorders;
using StructureMap;
using Telerik.WinControls.UI;

namespace PerfectPet
{
    public partial class frmInvoice : Form
    {
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public IList<Pet> Pets { get; set; }
        private ICompany _company;
        private Company company;
        private IInvoice _invoice;
        private Invoice invoice;
        private IList<LineItem> lineItems; 
        private Person customer;
        private Address address;
        private IInvoiceNumber _invoiceNumber;
        private InvoiceNumber invoiceNumber;
        private GridViewComboBoxColumn productcombo;
        private GridViewComboBoxColumn servicecombo;
        private frmViewInvoiceReport formInvoiceReport;

        public frmInvoice()
        {
            InitializeComponent();
        }

        #region "Class Events"

            private void frmInvoice_Load(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.Default;
                    this.WindowState = FormWindowState.Maximized;
                    gridProducts.CellEditorInitialized += new GridViewCellEventHandler(gridProducts_CellEditorInitialized);
                    lineItems = new List<LineItem>();
                    Pets = new List<Pet>();
                    _company = ObjectFactory.GetInstance<ICompany>();
                    company = _company.GetById(1002);
                    _invoice = ObjectFactory.GetInstance<IInvoice>();
                    invoice = _invoice.Get();
                    _invoiceNumber = ObjectFactory.GetInstance<IInvoiceNumber>();
                    invoiceNumber = _invoiceNumber.GetById(1);
                    invoice.Company = company;
                    lblTaxIdNumber.Text = company.TaxNumber;
                    lblInvoiceNumber.Text = invoiceNumber.Number.ToString();
                    BindCustomerDropDown();
                    BindProductGrid();
                    BindServiceGrid();
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    throw;
                }
            }

        private void gridProducts_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Row is GridViewNewRowInfo)
            {

                var editor = e.ActiveEditor as RadDropDownListEditor;

                if (editor != null)
                {

                    editor.ValueChanged -= new EventHandler(editor_ValueChanged);

                    editor.ValueChanged += new EventHandler(editor_ValueChanged);

                }

            }
        }

        private void editor_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType().ToString());
            //gridProducts.EndEdit();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
            {
                try
                {
                    PersonId = (int) ddlCustomerList.SelectedValue;
                    BindPetListView();
                    BindAddressListView();
                    GetCustomerHeader();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void btnAddPets_Click(object sender, EventArgs e)
            {
                try
                {
                    AddPetsToHeaderListView();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void btnAddAddress_Click(object sender, EventArgs e)
            {
                try
                {
                    AddressId = (int)listViewAddresses.SelectedItem.Value;
                    if (AddressId != null)
                    {
                        GetAddressHeader();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        #endregion

        #region "Class Methods"
        
            private void GetCustomerHeader()
            {
                try
                {
                    var _customer = ObjectFactory.GetInstance<IPerson>();
                    customer = _customer.GetById(PersonId);
                    invoice.Person = customer;
                    lblHeaderCustomer.Text = customer.Number + " - " + customer.FirstName + " " + customer.LastName;
                    Pets = new List<Pet>();
                    listviewHeaderPets.DataSource = null;
                    listviewHeaderPets.Items.Clear();
                    lblHeaderAddress.Text = "";

                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void GetAddressHeader()
            {
                try
                {
                    var _address = ObjectFactory.GetInstance<IAddress>();
                    address = _address.GetById(AddressId);
                    invoice.InvoiceAddress = address;
                    if(address != null)
                    {
                        lblHeaderAddress.Text = address.Street + " " + address.City + " " + address.State + ", " +
                                                address.Zip;
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }        
            }

            private void BindProductGrid()
            {
                try
                {
                    var _products = ObjectFactory.GetInstance<IProduct>();
                    var products = _products.GetAll();

                    var query = from product in products
                                select new {Id = product.Id, Product = product.Name};

                    productcombo = (GridViewComboBoxColumn)gridProducts.Columns[1];
                    productcombo.DataSource = query;
                    productcombo.DisplayMember = "Product";
                    productcombo.ValueMember = "Id";
                }
                catch (Exception)
                {
                    
                    throw;
                }        
            }

            private void BindServiceGrid()
            {
                try
                {
                    var _services = ObjectFactory.GetInstance<IService>();
                    var services = _services.GetAll();

                    var query = from service in services
                                select new { Id = service.Id, Service = service.Name };

                    servicecombo = (GridViewComboBoxColumn)gridServices.Columns[1];
                    servicecombo.DataSource = query;
                    servicecombo.DisplayMember = "Service";
                    servicecombo.ValueMember = "Id";
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void BindCustomerDropDown()
            {
                try
                {
                    var _customers = ObjectFactory.GetInstance<IPerson>();
                    var customers = _customers.CustomerList("Customer");
                    var query = from o in customers
                                select new {Id = o.Id, Name = o.Number + " - " + o.LastName + ", " + o.FirstName};

                    var bindsrc = new BindingSource();
                    bindsrc.DataSource = query;

                    ddlCustomerList.DataSource = bindsrc.DataSource;
                    ddlCustomerList.ValueMember = "Id";
                    ddlCustomerList.DisplayMember = "Name";
                }
                catch (Exception)
                {
                
                    throw;
                }
            }

            private void BindPetListView()
            {
                try
                {
                    var _pets = ObjectFactory.GetInstance<IPet>();
                    var pets = _pets.GetByPersonId(PersonId);                
                    listviewPets.DataSource = pets;
                    listviewPets.ValueMember = "PetId";
                    listviewPets.DisplayMember = "Name";
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void BindAddressListView()
            {
                try
                {
                    var _addresses = ObjectFactory.GetInstance<IAddress>();
                    var addresses = _addresses.GetByPersonId(PersonId);
                    var query = from address in addresses
                                select
                                    new
                                        {
                                            Id = address.Id,
                                            Name = address.Street + " " + address.City + " " + address.State
                                        };
                    listViewAddresses.DataSource = query;
                    listViewAddresses.ValueMember = "Id";
                    listViewAddresses.DisplayMember = "Name";
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void BindPetHeaderListView()
            {
                try
                {
                    var query = from o in Pets
                                select
                                    new
                                    {
                                        Id = o.PetId,
                                        Name = o.Name
                                    };
                    listviewHeaderPets.DataSource = query;
                    listviewHeaderPets.ValueMember = "Id";
                    listviewHeaderPets.DisplayMember = "Name";
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void AddPetsToHeaderListView()
            {
                try
                {
                    //listviewHeaderPets.DataSource = listviewPets.SelectedItems;
                    foreach (var item in listviewPets.CheckedItems)
                    {
                        if(item.Value != null)
                        {
                            var _pet = ObjectFactory.GetInstance<IPet>();
                            var pet = _pet.GetById((int) item.Value);
                            if (!Pets.Contains(pet))
                            {
                                Pets.Add(pet);
                            }
                        }

                        Console.WriteLine(item.Value);
                        //listviewHeaderPets.Items.Add(item.Text);
                    }
                    BindPetHeaderListView();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        #endregion

            private void MasterTemplate_CellValueChanged(object sender, GridViewCellEventArgs e)
            {
                try
                {
                    if (e.Column is GridViewComboBoxColumn)
                    {
                        var _product = ObjectFactory.GetInstance<IProduct>();
                        var product = _product.GetById((int) gridProducts.CurrentRow.Cells["Product"].Value);
                        gridProducts.CurrentRow.Cells["Description"].Value = product.Description;
                        gridProducts.CurrentRow.Cells["Cost"].Value = product.Cost;
                        gridProducts.CurrentRow.Cells["Retail"].Value = product.Retail;
                        gridProducts.CurrentRow.Cells["Name"].Value = product.Name;
                    }
                    if (e.Column.Name == "Quantity")
                    {
                        gridProducts.CurrentRow.Cells["Subtotal"].Value = (decimal)gridProducts.CurrentRow.Cells["Retail"].Value *
                                                                          (decimal)gridProducts.CurrentRow.Cells["Quantity"].
                                                                                       Value;                        
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void MasterTemplate_UserAddedRow(object sender, GridViewRowEventArgs e)
            {
                decimal calc = 0;
                foreach (var row in gridProducts.Rows)
                {
                    if(row.Cells["Subtotal"].Value != null)
                    {
                        var total = (decimal)row.Cells["Subtotal"].Value + calc;
                        calc = total;
                    }
                }
                AddProductLineItem(gridProducts.CurrentRow);
                txtProductTotal.Text = calc.ToString();
            }

            private void AddProductLineItem(GridViewRowInfo row)
        {
            try
            {
                var _lineitem = ObjectFactory.GetInstance<ILineItem>();
                var lineitem = _lineitem.Get();
                lineitem.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                var _product = ObjectFactory.GetInstance<IProduct>();
                var product = _product.GetById(Convert.ToInt32(row.Cells["Product"].Value));
                lineitem.Product = product;
                lineitem.LineTotal = Convert.ToDouble(row.Cells["Subtotal"].Value);
                lineitem.UnitPrice = Convert.ToDouble(row.Cells["Retail"].Value);
                lineitem.Name = row.Cells["Name"].Value.ToString();
                lineitem.CreatedDate = DateTime.Now;
                lineitem.Description = row.Cells["Description"].Value.ToString();
                lineItems.Add(lineitem);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridServices_CellValueChanged(object sender, GridViewCellEventArgs e)
            {
                try
                {
                    if (e.Column is GridViewComboBoxColumn)
                    {
                        var _service = ObjectFactory.GetInstance<IService>();
                        var service = _service.GetById((int)gridServices.CurrentRow.Cells["Service"].Value);
                        gridServices.CurrentRow.Cells["Description"].Value = service.Description;
                        gridServices.CurrentRow.Cells["Cost"].Value = service.Cost;
                        gridServices.CurrentRow.Cells["Retail"].Value = service.Retail;
                    }
                    if (e.Column.Name == "Quantity")
                    {
                        gridServices.CurrentRow.Cells["Subtotal"].Value = (decimal)gridServices.CurrentRow.Cells["Retail"].Value *
                                                                          (decimal)gridServices.CurrentRow.Cells["Quantity"].
                                                                                       Value;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void gridServices_UserAddedRow(object sender, GridViewRowEventArgs e)
            {
                decimal calc = 0;
                foreach (var row in gridServices.Rows)
                {
                    if (row.Cells["Subtotal"].Value != null)
                    {
                        var total = (decimal)row.Cells["Subtotal"].Value + calc;
                        calc = total;
                    }
                }
                gridServices.CurrentRow.Cells["Subtotal"].Value = calc;
                txtServiceTotal.Text = calc.ToString();
            }

            private void btnSaveInvoice_Click(object sender, EventArgs e)
            {
                SaveNewInvoice();
            }

        private void SaveNewInvoice()
        {
            try
            {
                _invoice = ObjectFactory.GetInstance<IInvoice>();

                //Increment Invoice Number
                if(_invoiceNumber == null)
                {
                    _invoiceNumber = ObjectFactory.GetInstance<IInvoiceNumber>();
                }
                var tempinvnumber = _invoiceNumber.GetById(1);
                tempinvnumber.Number = invoiceNumber.Number + 1;
                _invoiceNumber.Save(tempinvnumber);

                var _lineitems = ObjectFactory.GetInstance<ILineItem>();
                var _invoicetopet = ObjectFactory.GetInstance<IInvoiceToPet>();
                var invoicetopet = _invoicetopet.Get();

                //Fill Invoice Data
                invoice = _invoice.Get();
                invoice.Number = invoiceNumber.ToString();
                invoice.InvoiceDate = Convert.ToDateTime(dateInvoiceDate.Text);
                invoice.Person = customer;
                invoice.InvoiceAddress = address;
                invoice.Company = company;
                invoice.DeliveryDate = DateTime.Now;
                invoice.Description = txtInvoiceDescription.Text;
                invoice.CreatedDate = DateTime.Now;          
                _invoice.Save(invoice);

                //Save Invoice To Pet Table Data
                foreach (var pet in Pets)
                {
                    invoicetopet.Pet = pet;
                    invoicetopet.Invoice = invoice;
                    _invoicetopet.Save(invoicetopet);
                }

                //Save Invoice Line Items
                foreach (var item in lineItems)
                {
                    item.Invoice = invoice;
                    _lineitems.Save(item);
                }
                btnPrintInvoice.Enabled = true;
                lblInvoiceSaved.Visible = true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ResetInvoiceForm()
        {
            try
            {
                listviewPets.DataSource = null;
                listViewAddresses.DataSource = null;
                listviewHeaderPets.DataSource = null;
                txtInvoiceDescription.Clear();
                txtProductTotal.Clear();
                txtServiceTotal.Clear();
                lblHeaderAddress.Text = "";
                lblHeaderCustomer.Text = "";
                lblInvoiceSaved.Visible = false;
                chkIncludeBalance.Checked = false;
                gridProducts.Rows.Clear();
                gridServices.Rows.Clear();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            ResetInvoiceForm();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                formInvoiceReport = new frmViewInvoiceReport();
                formInvoiceReport.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
