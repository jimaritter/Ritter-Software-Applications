using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectPet.Model.Tasks;
using StructureMap;

namespace PerfectPet
{
    public partial class frmTasks : Form
    {
        public frmTasks()
        {
            InitializeComponent();
        }

        private void frmTasks_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.Default;
                BindTasksGrid();
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                throw;
            }
        }

        private void BindTasksGrid()
        {
            try
            {
                var _task = ObjectFactory.GetInstance<ITask>();
                var task = _task.GetAll();
                gridTasks.DataSource = task;

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
