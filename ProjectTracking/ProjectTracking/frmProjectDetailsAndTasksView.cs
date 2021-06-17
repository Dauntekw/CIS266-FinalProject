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
    public partial class frmProjectDetailsAndTasksView : Form
    {
        public frmProjectDetailsAndTasksView()
        {
            InitializeComponent();
        }

        //Flag to verify that form and dataset is fully loaded. Default is false
        bool formIsLoaded = false;

        //Run parent form's SetReady method to change text displayed on status label
        private void SetReadyLabel(string message)
        {
            //Treat MainForm as parent
            MainForm mainForm = (MainForm)MdiParent;

            //Display passed message in parent form's status label
            mainForm.SetReady(message);
        }

        private void frmProjectTasks_Load(object sender, EventArgs e)
        {
            //Attempt to fill form's table adapters with relevent entries in dataset
            try
            {
                //Fill the form's employeeTableAdapter with Employees table entries
                this.employeesTableAdapter.Fill(this.sbdProjectsDataSet.Employees);

                //Fill the form's statusTableAdapter with Status table entries
                this.statusTableAdapter.Fill(this.sbdProjectsDataSet.Status);

                //Fill the form's tasksTableAdapter with Tasks table entries
                this.tasksTableAdapter.Fill(this.sbdProjectsDataSet.Tasks);

                //Fill the form's projectsTableAdapter with Projects table entries
                this.projectsTableAdapter.Fill(this.sbdProjectsDataSet.Projects);

                //Set formIsLoaded bool to true
                formIsLoaded = true;

                //Run GetStatus method to display long form Status associated with project's Status ID
                GetStatus();

                //Run GetManager method to display full name of assigned project manager
                GetManager();

                //Set parent form status label to confirm form data loaded successfully
                SetReadyLabel("Project Details And Tasks View Ready.");
            }
            catch (Exception ex)
            {
                //An error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        //Changes the Text property of txtStatus to display the Status column entry associated with current project's Status ID
        private void GetStatus()
        {
            if(formIsLoaded == true)
            {
                try
                {
                    //If the form is loaded, store the current project's Status ID as an int
                    int statusID = (int)txtStatus.Tag;

                    foreach (sbdProjectsDataSet.StatusRow statusRow in this.sbdProjectsDataSet.Status)
                    {
                        //For each row in the Status table, check if the StatusID column entry matches stored Status ID
                        if (statusRow.StatusID == statusID)
                        {
                            //StatusID and stored Status ID match, display actual Status in txtStatus textbox
                            txtStatus.Text = statusRow.Status;

                            //Exit the loop
                            break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    //An error has occured, display error message
                    MessageBox.Show(ex.Message, "ERROR");
                    SetReadyLabel(ex.Message);
                }

            }
        }

        //Changes the Text property of txtManager to display the assigned manager's Full Name
        private void GetManager()
        {
            if (formIsLoaded == true)
            {
                try
                {
                    //If the form is loaded, store the current project manager's employee id as an int
                    int employeeID = (int)txtManager.Tag;

                    foreach (sbdProjectsDataSet.EmployeesRow employee in this.sbdProjectsDataSet.Employees)
                    {
                        //For each row in the Employees table, check if the EmployeeID entry matches stored employeeID
                        if (employee.EmployeeID == employeeID)
                        {
                            //EmployeeID and stored employeeID match, combine FirstName and LastName entries into a full name via string format
                            string fullName = String.Format("{0} {1}", employee.FirstName, employee.LastName);

                            //Display Manager's full name in txtManager textbox
                            txtManager.Text = fullName;

                            //Exit the loop
                            break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    //An error has occured, display error message
                    MessageBox.Show(ex.Message, "ERROR");
                    SetReadyLabel(ex.Message);
                }
            }
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            //Run GetStatus method to display long form Status associated with project's Status ID
            GetStatus();

            //Run GetManager method to display full name of assigned project manager
            GetManager();
        }

        private void frmProjectDetailsAndTasksView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Display form closure confirmation message on parent form's status label
            SetReadyLabel("Project Details And Tasks View Closed Successfully.");
        }
    }
}
