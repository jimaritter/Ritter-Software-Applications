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
using PerfectPet.Model.Common;
using PerfectPet.Model.Kennels;
using StructureMap;
using Telerik.WinControls.UI;

namespace PerfectPet
{
    public partial class frmResources : Form
    {
        private Resources resource;
        private IResources _resource;
        private IList<IResources> resources; 

        public frmResources()
        {
            InitializeComponent();
        }

        #region

        private void BindResourceGrid()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IResources>();
                //var query = from a in kennels
                //            from b in Enum.GetValues(typeof (PetSize))
                //            select new {Id = a.Id, Name = a.Name, Description = a.Description, Size = b};


                var bindsrc = new BindingSource();
                bindsrc.DataSource = item.GetAll();
                gridResources.DataSource = bindsrc.DataSource;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void DeleteResourceRow()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IResources>();
                resource = item.GetById((int)gridResources.CurrentRow.Cells[0].Value);
                resource.Name = gridResources.CurrentRow.Cells[1].Value.ToString();
                resource.Size = gridResources.CurrentRow.Cells[3].Value.ToString();
                resource.Description = gridResources.CurrentRow.Cells[2].Value.ToString();
                _resource.Delete(resource);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveResourceRow()
        {
            try
            {
                var item = ObjectFactory.GetInstance<IResources>();
                resource = item.GetById((int)gridResources.CurrentRow.Cells[0].Value);
                resource.Name = gridResources.CurrentRow.Cells[1].Value.ToString();
                resource.Size = gridResources.CurrentRow.Cells[3].Value.ToString();
                resource.Description = gridResources.CurrentRow.Cells[2].Value.ToString();
                item.Save(resource);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveResource()
        {
            try
            {
                if(txtName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value for the resource name.");
                    txtName.Focus();
                    return;

                }
                var item = ObjectFactory.GetInstance<IResources>();
                resource = new Resources();
                resource = item.Get();
                resource.Name = txtName.Text;
                resource.Description = txtDescription.Text;
                item.Save(resource);
                BindResourceGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


        private void frmResources_Load(object sender, EventArgs e)
        {
            BindResourceGrid();
        }

        private void gridResources_CellEndEdit(object sender, GridViewCellEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveResource();
        }

    }
}
