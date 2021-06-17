using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//CIS 266 Term Project Daunte Williamson 06/20/2020
namespace ProjectTracking
{
    public partial class frmEmployeesDatabase : Form
    {
        public frmEmployeesDatabase()
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

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Attempt to update database
            try
            {
                //Run table validation and use tableAdapterManager to update all effected tables
                this.Validate();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sbdProjectsDataSet);

                //Display save confirmation message on parent form's status label
                SetReadyLabel("Changes Saved Successfully.");
            }
            catch (Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        private void frmEmployeesDatabase_Load(object sender, EventArgs e)
        {
            //Attempt to load database
            try
            {
                // TODO: This line of code loads data into the 'sbdProjectsDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.sbdProjectsDataSet.Employees);

                //Display form load confirmation message on parent form's status label
                SetReadyLabel("Employee Database Ready.");
            }
            catch (Exception ex)
            {
                //Error has occured, display error message
                MessageBox.Show(ex.Message, "ERROR");
                SetReadyLabel(ex.Message);
            }
        }

        //Display Employee with First Name, Full Name, or Employee ID that contains all typed characters
        private void tsbSearchButton_Click(object sender, EventArgs e)
        {
            //Initialize storage string for First Name
            string firstName = "";

            //Initialize storage string for Last Name
            string lastName = "";

            //Initialize storage strings for search text
            string searchText = "";

            //Regular expression to test if search text does not contain any digits (pass = check First / Full Name, fail = check employeeID)
            Regex regex = new Regex("[^0-9]");

            if (tstSearchBox.Text != "")
            {
                //If search box is not empty, store searchBox text in searchText string
                searchText = tstSearchBox.Text;

                //Check if searchText matches Regular Expression
                if (regex.IsMatch(searchText))
                {
                    //Check if searchText contains a space
                    if (searchText.Contains(' '))
                    {
                        //searchText contains a space, split the text and store in array
                        string[] splitText = searchText.Split(' ');

                        //Store the first item in splitText array as firstName
                        firstName = splitText[0];

                        //Store the second item in splitText array as lastName
                        lastName = splitText[1];

                        foreach (sbdProjectsDataSet.EmployeesRow employee in this.sbdProjectsDataSet.Employees)
                        {
                            //For each row in the Employees table, check if FirstName and LastName contain the stored first and last names
                            if (employee.FirstName.Contains(firstName) && employee.LastName.Contains(lastName))
                            {
                                //Match has been found, set the BindingSource position to display matching employee (position = EmployeeID - 1)
                                this.employeesBindingSource.Position = employee.EmployeeID - 1;

                                //Exit the loop
                                break;
                            }
                        }
                    }
                    else
                    {
                        //searchText does not contain a space, Check for only FirstName
                        foreach (sbdProjectsDataSet.EmployeesRow employee in this.sbdProjectsDataSet.Employees)
                        {
                            //For each row in Employees table, check if FirstName contains the stored searchText
                            if (employee.FirstName.Contains(searchText))
                            {
                                //Match has been found, set the BindingSource position to display matching employee (position = EmployeeID - 1)
                                this.employeesBindingSource.Position = employee.EmployeeID - 1;

                                //Exit the loop
                                break;
                            }
                        }
                    }
                }
                else
                {
                    //searchText does not match regular expression, attempt to check for EmployeeID
                    try
                    {
                        //Convert searchText into an integer and store it as searchEmpID
                        int searchEmpID = Convert.ToInt16(searchText);

                        foreach (sbdProjectsDataSet.EmployeesRow employee in this.sbdProjectsDataSet.Employees)
                        {
                            //For each row in Employees table, check if EmployeeID matches the stored searchEmpID
                            if (employee.EmployeeID == searchEmpID)
                            {
                                //Match has been found, set the BindingSource position to display matching employee (position = EmployeeID - 1)
                                this.employeesBindingSource.Position = employee.EmployeeID - 1;

                                //Exit the loop
                                break;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        //Error has occured, display error message
                        MessageBox.Show(ex.Message, "ERROR");
                    }
                }
            }
            else
            {
                //Search Box is empty, display instructions
                MessageBox.Show("Unable to search. Please enter an employee's First Name, Full Name, or Employee ID.", "Search Error: Missing Entry");
            }
        }

        private void frmEmployeesDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Display form closure confirmation message on parent form's status label
            SetReadyLabel("Employee Database Closed Successfully.");
        }
    }
}
