using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Common;
using PerfectPet.Model.Companies;
using PerfectPet.Model.Inventories;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;
using StructureMap;
using Telerik.WinControls.UI;

namespace PerfectPet
{
    public partial class frmInvoice : Form
    {
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public int InvoiceId { get; set; }
        public double PriorBalance { get; set; }
        public double Discount { get; set; }
        public double DiscountTotal { get; set; }
        public double InvoiceTotal { get; set; }
        public double TaxRate { get; set; }
        public double TaxTotal { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
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
                    if(InvoiceId == 0)
                    {
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
                        BindPaymentMehod();
                        BindPaymentTerms();
                    }else
                    {
                        var _lineItems = ObjectFactory.GetInstance<ILineItem>();
                        lineItems = _lineItems.GetAllByInvoiceId(InvoiceId);
                        _invoice = ObjectFactory.GetInstance<IInvoice>();
                        invoice = _invoice.GetById(InvoiceId);
                        Pets = new List<Pet>();
                        _company = ObjectFactory.GetInstance<ICompany>();
                        company = _company.GetById(1002);
                        invoice.Company = company;
                        lblTaxIdNumber.Text = company.TaxNumber;
                        lblInvoiceNumber.Text = invoiceNumber.Number.ToString();
                        BindCustomerDropDown();
                        BindPaymentMehod();
                        BindPaymentTerms();                       
                    }

      
                    BindInventoryList();
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    throw;
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
                    Discount = customer.Discount/100;
                    lblDiscount.Text = customer.Discount.ToString(CultureInfo.InvariantCulture) + "%";
                    var _company = ObjectFactory.GetInstance<ICompany>();
                    var company = _company.GetById(1002);
                    TaxRate = company.TaxRate;
                    Pets = new List<Pet>();
                    listviewHeaderPets.DataSource = null;
                    listviewHeaderPets.Items.Clear();
                    lblHeaderAddress.Text = "";
                    numericQuantity.Text = 0.ToString();
                    txtInventoryCost.Clear();
                    txtInventoryDescription.Clear();
                    txtInventoryName.Clear();
                    txtInventoryRetail.Clear();
                    chkTaxExempt.Checked = false;
                    gridInventory.Rows.Clear();

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

            private void BindInventoryList()
            {
                try
                {
                    var _inventory = ObjectFactory.GetInstance<IInventory>();
                    var inventory = _inventory.GetAll();

                    var query = from inv in inventory
                                where inv.Active == true
                                orderby inv.Name ascending 
                                select new {Id = inv.Id, Item = inv.Name};

                    ddlInventoryList.DataSource = query.ToList();
                    ddlInventoryList.DisplayMember = "Item";
                    ddlInventoryList.ValueMember = "Id";
                }
                catch (Exception)
                {
                    
                    throw;
                }   
            }

            private void BindPaymentMehod()
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(PaymentMethods));
                ddlPaymentMethod.DataSource = bindsrc.DataSource;             
            }

            private void BindPaymentTerms()
            {
                var bindsrc = new BindingSource();
                bindsrc.DataSource = EnumerationParser.GetEnumDescriptions(typeof(PaymentTerms));
                ddlInvoiceTerms.DataSource = bindsrc.DataSource;  
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

            private void GetInventoryItemDetails()
            {
                try
                {
                    var _inventory = ObjectFactory.GetInstance<IInventory>();
                    var inventory = _inventory.GetById((int)ddlInventoryList.SelectedValue);

                    txtInventoryName.Text = inventory.Name;
                    txtInventoryDescription.Text = inventory.Description;
                    txtInventoryCost.Text = inventory.Cost.ToString();
                    txtInventoryRetail.Text = inventory.Retail.ToString();
                    chkTaxExempt.Checked = inventory.TaxExempt;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void AddInventoryItem()
            {
                try
                {
                    var _inventory = ObjectFactory.GetInstance<IInventory>();
                    var inventory = _inventory.GetById((int)ddlInventoryList.SelectedValue);

                    gridInventory.Rows.Add(inventory.Id, inventory.Name, inventory.Description, inventory.Cost,
                                           inventory.Retail, numericQuantity.Text, (inventory.Retail * Convert.ToDouble(numericQuantity.Text)), inventory.Name,inventory.TaxExempt);
                    CalculateInventoryTotal();

                }
                catch (Exception)
                {

                    throw;
                }                
            }

        private void CalculateInventoryTotal()
        {
            try
            {
                double total = 0;
                double taxtotal = 0;

                foreach (var row in gridInventory.Rows)
                {
                    total = (total + Convert.ToDouble(row.Cells["Subtotal"].Value));
                    if (Convert.ToBoolean(row.Cells["TaxExempt"].Value) == false)
                    {
                        taxtotal = taxtotal + Convert.ToDouble(row.Cells["Subtotal"].Value);
                    }
                }

                taxtotal = Math.Round(taxtotal*TaxRate);
                TaxTotal = taxtotal;
                lblTaxTotal.Text = TaxTotal.ToString();

                if(chkIncludeBalance.Checked == true)
                {
                    total = total - (total * Discount) + PriorBalance + taxtotal;
                }
                else
                {
                    total = (total - (total * Discount)) + taxtotal;
                }

                lblInvoiceDiscount.Text = Math.Round(total * Discount,2).ToString(CultureInfo.InvariantCulture);
                InvoiceTotal = Math.Round(total,2);
                lblInvoiceTotal.Text = InvoiceTotal.ToString(CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion


        private void AddProductLineItem(GridViewRowInfo row)
        {
            try
            {
                var _lineitem = ObjectFactory.GetInstance<ILineItem>();
                var lineitem = _lineitem.Get();
                lineitem.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                var _product = ObjectFactory.GetInstance<IInventory>();
                var product = _product.GetById(Convert.ToInt32(row.Cells["Inventory"].Value));
                lineitem.Inventory = product;
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

        private void AddServiceLineItem(GridViewRowInfo row)
        {
            try
            {
                var _lineitem = ObjectFactory.GetInstance<ILineItem>();
                var lineitem = _lineitem.Get();
                lineitem.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.GetById(Convert.ToInt32(row.Cells["Service"].Value));
                lineitem.Service = service;
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

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            var dlgresult = DialogResult;
            if(MessageBox.Show("This will finalize this invoice and generate a new invoice number. Continue?","Save Invoice", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SaveNewInvoice();
                btnSaveInvoice.Enabled = false;
            }                
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


                //Fill Invoice Data
                invoice = _invoice.Get();
                invoice.Number = invoiceNumber.Number.ToString(CultureInfo.InvariantCulture);
                invoice.InvoiceDate = Convert.ToDateTime(dateInvoiceDate.Text);
                invoice.Person = customer;
                invoice.InvoiceAddress = address;
                invoice.Company = company;
                invoice.DeliveryDate = DateTime.Now;
                invoice.Description = txtInvoiceDescription.Text;
                invoice.CreatedDate = DateTime.Now;
                invoice.TaxRate = TaxRate;
                invoice.Tax = TaxTotal;
                invoice.Discount = DiscountTotal;
                invoice.DiscountRate = Discount;
                invoice.PriorBalance = PriorBalance;
                invoice.InvoiceTotal = InvoiceTotal;
                _invoice.Save(invoice);


                //Save Invoice Line Items
                foreach (var item in lineItems)
                {
                    item.Invoice = invoice;
                    _lineitems.Save(item);
                }
                InvoiceId = invoice.InvoiceId;
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
                lblHeaderAddress.Text = "";
                lblHeaderCustomer.Text = "";
                lblInvoiceSaved.Visible = false;
                chkIncludeBalance.Checked = false;
                numericQuantity.Text = 0.ToString();
                txtInventoryCost.Clear();
                txtInventoryDescription.Clear();
                txtInventoryName.Clear();
                txtInventoryRetail.Clear();
                chkTaxExempt.Checked = false;
                gridInventory.Rows.Clear();
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
                formInvoiceReport.InvoiceId = InvoiceId;
                formInvoiceReport.CompanyId = 1002;
                formInvoiceReport.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnSelectInventoryItem_Click(object sender, EventArgs e)
        {
            numericQuantity.Text = 0.ToString();
            GetInventoryItemDetails();
        }

        private void btnAddInventoryItem_Click(object sender, EventArgs e)
        {            
            AddInventoryItem();
        }

        private void btnDeleteInventoryItem_Click(object sender, EventArgs e)
        {
            try
            {
                gridInventory.Rows.Remove(gridInventory.CurrentRow);
                CalculateInventoryTotal();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double Num;
            bool isNum = double.TryParse(txtPayment.Text, out Num);
            if(isNum)
            {
                var balance = Math.Round(InvoiceTotal - Convert.ToDouble(txtPayment.Text),2);
                Balance = balance;
                Payment = Convert.ToDouble(txtPayment.Text);
                lblInvoiceBalance.Text = balance.ToString();
            }
        }

    }
}
