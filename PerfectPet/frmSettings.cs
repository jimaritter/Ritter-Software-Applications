using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Common;
using PerfectPet.Model.Companies;
using PerfectPet.Model.Products;
using PerfectPet.Model.Services;
using StructureMap;

namespace PerfectPet
{
    public partial class frmSettings : Form
    {

        private bool _isDirty;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.Default;
                tabParent.SelectedPage = tabCompany;
                BindStateList();
                if(Program.CompanyId != 0)
                {
                    GetCompanyInformation();
                    tabProducts.Enabled = true;
                    tabServices.Enabled = true;
                    BindProductGrid();
                }
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;               
                throw;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCompanyName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter in a company name.");
                    return;
                }
                SaveCompanyInformation();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindStateList()
        {
            this.ddlStates.DataSource = EnumerationParser.GetEnumDescriptions(typeof(States)); 
        }

        private void GetCompanyInformation()
        {
            try
            {
                Company company;
                var _company = ObjectFactory.GetInstance<ICompany>();
                company = _company.GetById(Program.CompanyId);
                txtCompanyName.Text = company.CompanyName;
                txtDescription.Text = company.Description;
                txtTaxRate.Text = company.TaxRate.ToString();
                txtStreet.Text = company.Street;
                txtCity.Text = company.City;
                ddlStates.SelectedValue = company.State;
                txtZip.Text = company.Zip;
                txtPhone.Text = company.Phone;
                txtFax.Text = company.Fax;
                txtCell.Text = company.Cell;
                txtWebSite.Text = company.Web;
                txtEmail.Text = company.Email;
                txtTaxIdNumber.Text = company.TaxNumber;
                if(company.Logo != null)
                {
                    MemoryStream stmBLOBData = new MemoryStream(company.Logo);
                    picLogo.Image = Image.FromStream(stmBLOBData);
                }
            }
            catch (Exception)
            {
                
                throw;
            }           
        }

        private void SaveCompanyInformation()
        {
            try
            {
                Company company;
                var _company = ObjectFactory.GetInstance<ICompany>();

                if (Program.CompanyId != 0)
                {
                  company = _company.GetById(Program.CompanyId);  
                }else
                {
                    company = _company.Get();
                }

                company.CompanyName = txtCompanyName.Text;
                company.Description = txtDescription.Text;
                company.TaxRate = Convert.ToDouble(txtTaxRate.Text);
                company.Street = txtStreet.Text;
                company.City = txtCity.Text;
                company.State = ddlStates.SelectedValue.ToString();
                company.Zip = txtZip.Text;
                company.Phone = txtPhone.Text;
                company.Fax = txtFax.Text;
                company.Cell = txtCell.Text;
                company.Web = txtWebSite.Text;
                company.Email = txtEmail.Text;
                company.TaxNumber = txtTaxIdNumber.Text;
                if (picLogo.Image != null)
                {
                    company.Logo = ImageTool.ConvertImageToByteArray(picLogo.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                _company.Save(company);
                Program.CompanyExists = true;
                Program.CompanyId = company.Id;
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
                var _product = ObjectFactory.GetInstance<IProduct>();
                var product = _product.GetAll();
                var bindsrc = new BindingSource();
                bindsrc.DataSource = product;
                gridProducts.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridProducts_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void gridProducts_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                var _product = ObjectFactory.GetInstance<IProduct>();
                var product = _product.Get();
                product.Name = (string) e.Row.Cells[1].Value;
                product.Description = (string)e.Row.Cells[2].Value;
                product.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                product.Retail = Convert.ToDouble(e.Row.Cells[4].Value);
                if (e.Row.Cells[5].Value == null)
                {
                    product.Active = false;
                }else
                {
                    product.Active = (bool)e.Row.Cells[5].Value;
                }

                if (e.Row.Cells[6].Value == null)
                {
                    product.TaxExempt = false;
                }
                else
                {
                    product.TaxExempt = (bool)e.Row.Cells[6].Value;
                }               
                
                product.CreatedDate = DateTime.Now;
                _product.Save(product);
                _isDirty = false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridProducts_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Row.Index == -1)
                {
                    return;
                }
                _isDirty = true;
                var _product = ObjectFactory.GetInstance<IProduct>();
                var product = _product.GetById((int) e.Row.Cells[0].Value);
                product.Name = (string)e.Row.Cells[1].Value;
                product.Description = (string)e.Row.Cells[2].Value;
                product.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                product.Retail = Convert.ToDouble(e.Row.Cells[4].Value);
                if (e.Row.Cells[5].Value == null)
                {
                    product.Active = false;
                }else
                {
                    product.Active = (bool)e.Row.Cells[5].Value;    
                }

                if (e.Row.Cells[6].Value == null)
                {
                    product.TaxExempt = false;
                }
                else
                {
                    product.TaxExempt = (bool)e.Row.Cells[6].Value;
                }
                
                _product.Save(product);
                _isDirty = false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridServices_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if(e.Row.Index == -1)
                {
                    return;
                }
                _isDirty = true;
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.GetById((int)e.Row.Cells[0].Value);
                service.Name = (string)e.Row.Cells[1].Value;
                service.Description = (string)e.Row.Cells[2].Value;
                service.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                service.Retail = Convert.ToDouble(e.Row.Cells[4].Value);
                if (e.Row.Cells[5].Value == null)
                {
                    service.Active = false;
                }
                else
                {
                    service.Active = (bool)e.Row.Cells[5].Value;
                }

                if (e.Row.Cells[6].Value == null)
                {
                    service.TaxExempt = false;
                }
                else
                {
                    service.TaxExempt = (bool)e.Row.Cells[6].Value;
                }
                _service.Save(service);
                _isDirty = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridServices_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                _isDirty = true;
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.Get();
                service.Name = (string)e.Row.Cells[1].Value;
                service.Description = (string)e.Row.Cells[2].Value;
                service.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                service.Retail = Convert.ToDouble(e.Row.Cells[4].Value);

                if (e.Row.Cells[5].Value == null)
                {
                    service.Active = false;              
                }else
                {
                    service.Active = (bool)e.Row.Cells[5].Value;  
                }

                if (e.Row.Cells[6].Value == null)
                {
                    service.TaxExempt = false;  
                }else
                {
                    service.TaxExempt = (bool)e.Row.Cells[6].Value;                  
                }

                service.CreatedDate = DateTime.Now;
                _service.Save(service);
                _isDirty = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void linklblChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "JPG Image of Pet";
                dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.picLogo.Image = new Bitmap(dlg.OpenFile());
                }
                dlg.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
