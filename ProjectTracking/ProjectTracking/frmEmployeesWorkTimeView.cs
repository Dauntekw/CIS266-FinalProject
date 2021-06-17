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
    public partial class frmEmployeesWorkTimeView : Form
    {
        public frmEmployeesWorkTimeView()
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

        private void frmEmployeesWorkTime_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.sbdProjectsDataSet.Employees);
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.WorkTime' table. You can move, or remove it, as needed.
                this.workTimeTableAdapter.Fill(this.sbdProjectsDataSet.WorkTime);

                //Set formIsLoaded bool to true
                formIsLoaded = true;

                //Run the GetHoursCount method to change the lblHoursCount text to display total hours worked
                GetHoursCount();

                //Set parent form status label to confirm form data loaded successfully
                SetReadyLabel("Employee Work Time View Ready.");
            }
            catch(Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        //Changes the Text property of lblHoursCount to display the total hours worked by employee
        private void GetHoursCount()
        {
            //Initialize counter decimal
            decimal count = 0;

            if (formIsLoaded == true)
            {
                try
                {
                    //If the form is loaded, store the current project's Status ID as an int
                    int empID = (int)employeeIDTextBox.Tag;

                    foreach (sbdProjectsDataSet.WorkTimeRow workTime in this.sbdProjectsDataSet.WorkTime)
                    {
                        //For each row in the WorkTime table, check if the EmployeeID column entry matches stored Employee ID
                        if (workTime.EmployeeID == empID)
                        {
                            //Current EmployeeID matches stored Employee ID, add WorkTime to counter
                            count += workTime.WorkTime;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Error has occured, display error message
                    MessageBox.Show(ex.Message, "ERROR");
                    SetReadyLabel(ex.Message);
                }

                //Display total hours count as string in lblHoursCount label
                lblHoursCount.Text = count.ToString();
            }
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            //Run the GetHoursCount method to change the lblHoursCount text to display total hours worked
            GetHoursCount();
        }

        private void frmEmployeesWorkTimeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Display form closure confirmation message on parent form's status label
            SetReadyLabel("Employee Work Time View Closed Successfully.");
        }
    }
}
