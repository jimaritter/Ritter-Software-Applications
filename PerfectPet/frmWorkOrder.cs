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
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Products;
using PerfectPet.Model.Services;
using PerfectPet.Model.Workorders;
using StructureMap;
using Telerik.WinControls.UI;

namespace PerfectPet
{
    public partial class frmWorkOrder : Form
    {
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public IList<Pet> Pets { get; set; }
        private IWorkorder _workorder;
        private Workorder workorder;

        public frmWorkOrder()
        {
            InitializeComponent();
        }

        #region "Class Events"

            private void frmWorkOrder_Load(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Default;
                this.WindowState = FormWindowState.Maximized;
                Pets = new List<Pet>();
                _workorder = ObjectFactory.GetInstance<IWorkorder>();
                workorder = _workorder.Get();
                BindCustomerDropDown();
                BindProductsDropDown();
                BindServicesDropDown();
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
                    var customer = _customer.GetById(PersonId);
                    workorder.Person = customer;
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
                    var address = _address.GetById(AddressId);
                    workorder.Address = address;
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

            private void BindProductsDropDown()
            {
                try
                {
                    var _product = ObjectFactory.GetInstance<IProduct>();
                    var product = _product.GetAll();
                    ddlProductList.DataSource = product;
                    ddlProductList.DisplayMember = "Name";
                    ddlProductList.ValueMember = "Id";
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            private void BindServicesDropDown()
            {
                try
                {
                    var _service = ObjectFactory.GetInstance<IService>();
                    var service = _service.GetAll();
                    ddlServiceList.DataSource = service;
                    ddlServiceList.DisplayMember = "Name";
                    ddlServiceList.ValueMember = "Id";
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

    }
}
