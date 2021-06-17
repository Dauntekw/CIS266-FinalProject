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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //myProjects = new sbdProjectsDataSet();
            //GetData();
        }

        //private sbdProjectsDataSet myProjects;

        /*public sbdProjectsDataSet MyProjects
        {
            get { return myProjects; }
        }*/

        //Parent and Display passed forms
        public void ShowForm(Form form)
        {
            //SetReady(form.Text);
            form.MdiParent = this;
            form.Show();
        }

        //Allow child forms to alter message on status label
        public void SetReady(string message)
        {
            //Pass message parameter to text property of Ready label
            stsReadyLabel.Text = message;
        }

        /*private void GetData()
        {
            sbdProjectsDataSetTableAdapters.EmployeesTableAdapter taEmployees = new sbdProjectsDataSetTableAdapters.EmployeesTableAdapter();
            sbdProjectsDataSetTableAdapters.ProjectsTableAdapter taProjects = new sbdProjectsDataSetTableAdapters.ProjectsTableAdapter();
            sbdProjectsDataSetTableAdapters.StatusTableAdapter taStatus = new sbdProjectsDataSetTableAdapters.StatusTableAdapter();
            sbdProjectsDataSetTableAdapters.TasksTableAdapter taTasks = new sbdProjectsDataSetTableAdapters.TasksTableAdapter();
            sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter taWorkTime = new sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter();
            try
            {
                taEmployees.Fill(myProjects.Employees);
                taProjects.Fill(myProjects.Projects);
                taStatus.Fill(myProjects.Status);
                taTasks.Fill(myProjects.Tasks);
                taWorkTime.Fill(myProjects.WorkTime);
            }
            catch (Exception ex)
            {
                //Error has occured, display error in message box
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        public void SaveData()
        {
            sbdProjectsDataSetTableAdapters.EmployeesTableAdapter taEmployees = new sbdProjectsDataSetTableAdapters.EmployeesTableAdapter();
            sbdProjectsDataSetTableAdapters.ProjectsTableAdapter taProjects = new sbdProjectsDataSetTableAdapters.ProjectsTableAdapter();
            sbdProjectsDataSetTableAdapters.StatusTableAdapter taStatus = new sbdProjectsDataSetTableAdapters.StatusTableAdapter();
            sbdProjectsDataSetTableAdapters.TasksTableAdapter taTasks = new sbdProjectsDataSetTableAdapters.TasksTableAdapter();
            sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter taWorkTime = new sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter();

            sbdProjectsDataSetTableAdapters.TableAdapterManager taManager = new sbdProjectsDataSetTableAdapters.TableAdapterManager();

            taManager.EmployeesTableAdapter = taEmployees;
            taManager.ProjectsTableAdapter = taProjects;
            taManager.StatusTableAdapter = taStatus;
            taManager.TasksTableAdapter = taTasks;
            taManager.WorkTimeTableAdapter = taWorkTime;
            try
            {
                taManager.UpdateAll(myProjects);
            }
            catch(Exception ex)
            {
                //Error has occured, display error in message box
                MessageBox.Show(ex.Message, "ERROR");
            }
        }*/


        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close all open child form windows inside the MDI container
            foreach (Form childForm in this.MdiChildren)
            {
                //Close currently selected child form
                childForm.Close();
            }
        }

        /*WINDOW*/
        //Cascade all open Mdi Child Forms
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Tile all open Mdi Child Forms Horizontally
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //Tile all open Mdi Child Forms Vertically
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //Create and Display a new instance of frmProjectDetailsAndTasksView form
        private void detailsAndTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjectDetailsAndTasksView form = new frmProjectDetailsAndTasksView();
            ShowForm(form);
        }

        //Close Application and All associated forms
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Create and Display a new instance of frmEmployeesDatabase form
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeesDatabase form = new frmEmployeesDatabase();
            ShowForm(form);
        }

        //Create and Display a new instance of frmProjectDatabase form
        private void projectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjectDatabase form = new frmProjectDatabase();
            ShowForm(form);
        }

        //Create and Display a new instance of frmTasksDatabase form
        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTasksDatabase form = new frmTasksDatabase();
            ShowForm(form);
        }

        //Create and Display a new instance of frmEmployeesWorkTimeView form
        private void workTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeesWorkTimeView form = new frmEmployeesWorkTimeView();
            ShowForm(form);
        }

        //Create and Display a new instance of frmEmployeesAssignTasks form
        private void assignedTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeesAssignTasks form = new frmEmployeesAssignTasks();
            ShowForm(form);
        }
    }
}
