using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Inventories;
using PerfectPet.Model.Services;
using StructureMap;

namespace PerfectPet
{
    public partial class frmProductServices : Form
    {
        private bool _isDirty;

        public frmProductServices()
        {
            InitializeComponent();
        }

        private void frmProductServices_Load(object sender, EventArgs e)
        {
            BindProductGrid();
            tabParent.SelectedPage = tabProducts;
        }

        #region

        private void BindProductGrid()
        {
            try
            {
                var _product = ObjectFactory.GetInstance<IInventory>();
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

        #endregion

        private void gridProducts_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Row.Index == -1)
                {
                    return;
                }
                _isDirty = true;
                var _product = ObjectFactory.GetInstance<IInventory>();
                var product = _product.GetById((int) e.Row.Cells[0].Value);
                product.Name = (string) e.Row.Cells[1].Value;
                product.Description = (string) e.Row.Cells[2].Value;
                product.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                product.Retail = Convert.ToDouble(e.Row.Cells[4].Value);
                if (e.Row.Cells[5].Value == null)
                {
                    product.Active = false;
                }
                else
                {
                    product.Active = (bool) e.Row.Cells[5].Value;
                }

                if (e.Row.Cells[6].Value == null)
                {
                    product.TaxExempt = false;
                }
                else
                {
                    product.TaxExempt = (bool) e.Row.Cells[6].Value;
                }

                _product.Save(product);
                _isDirty = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridProducts_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                var _product = ObjectFactory.GetInstance<IInventory>();
                var product = _product.Get();
                product.Name = (string) e.Row.Cells[1].Value;
                product.Description = (string) e.Row.Cells[2].Value;
                product.Cost = Convert.ToDouble(e.Row.Cells[3].Value);
                product.Retail = Convert.ToDouble(e.Row.Cells[4].Value);
                if (e.Row.Cells[5].Value == null)
                {
                    product.Active = false;
                }
                else
                {
                    product.Active = (bool) e.Row.Cells[5].Value;
                }

                if (e.Row.Cells[6].Value == null)
                {
                    product.TaxExempt = false;
                }
                else
                {
                    product.TaxExempt = (bool) e.Row.Cells[6].Value;
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
    }
}
