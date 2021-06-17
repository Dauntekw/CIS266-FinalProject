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
    public partial class frmEmployeesAssignTasks : Form
    {
        public frmEmployeesAssignTasks()
        {
            InitializeComponent();
        }

        //Run parent form's SetReady method to change text displayed on status label
        private void SetReadyLabel(string message)
        {
            //Treat MainForm as parent
            MainForm mainForm = (MainForm)MdiParent;

            //Display passed message in parent form's status label
            mainForm.SetReady(message);
        }

        private void workTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Attempt to update database
            try
            {
                //Run table validation and use tableAdapterManager to update all effected tables
                this.Validate();
                this.workTimeBindingSource.EndEdit();
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

        private void frmEmployeesAssignTasks_Load(object sender, EventArgs e)
        {
            //Attempt to load database
            try
            {
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.sbdProjectsDataSet.Employees);
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.sbdProjectsDataSet.Tasks);
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.WorkTime' table. You can move, or remove it, as needed.
                this.workTimeTableAdapter.Fill(this.sbdProjectsDataSet.WorkTime);

                //Display form load confirmation message on parent form's status label
                SetReadyLabel("Assign Tasks Ready.");
            }
            catch(Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        private void frmEmployeesAssignTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Display form closure confirmation message on parent form's status label
            SetReadyLabel("Assign Tasks Form Closed Successfully.");
        }
    }
}
