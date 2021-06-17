using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//CIS 266 Term Project Daunte Williamson 06/20/2020
namespace ProjectTracking
{
    public partial class frmTasksDatabase : Form
    {
        public frmTasksDatabase()
        {
            InitializeComponent();
        }

        //Run parent form's SetReady method to change text displayed on status label
        private void SetReadyLabel(string message)
        {
            //Treat MainForm as parent
            MainForm mainForm = (MainForm)MdiParent;
            mainForm.SetReady(message);
        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Attempt to update database
            try
            {
                this.Validate();
                this.tasksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sbdProjectsDataSet);
                //Display save confirmation message on parent form's status label
                SetReadyLabel("Changes Saved Successfully.");
            }
            catch(Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
            
        }

        private void frmTasksDatabase_Load(object sender, EventArgs e)
        {
            //Attempt to load database
            try
            {
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.sbdProjectsDataSet.Tasks);

                //Display form load confirmation message on parent form's status label
                SetReadyLabel("Tasks Database Ready.");
            }
            catch(Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        private void frmTasksDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Display form closure confirmation message on parent form's status label
            SetReadyLabel("Tasks Database Closed Successfully.");
        }
    }
}
