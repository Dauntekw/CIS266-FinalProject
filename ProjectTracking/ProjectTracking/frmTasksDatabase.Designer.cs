namespace ProjectTracking
{
    partial class frmTasksDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label taskIDLabel;
            System.Windows.Forms.Label taskNameLabel;
            System.Windows.Forms.Label taskDescriptionLabel;
            System.Windows.Forms.Label taskStartLabel;
            System.Windows.Forms.Label taskEndLabel;
            System.Windows.Forms.Label taskStatusLabel;
            System.Windows.Forms.Label projectLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTasksDatabase));
            this.sbdProjectsDataSet = new ProjectTracking.sbdProjectsDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.TasksTableAdapter();
            this.tableAdapterManager = new ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager();
            this.tasksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.taskIDTextBox = new System.Windows.Forms.TextBox();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.taskStatusTextBox = new System.Windows.Forms.TextBox();
            taskIDLabel = new System.Windows.Forms.Label();
            taskNameLabel = new System.Windows.Forms.Label();
            taskDescriptionLabel = new System.Windows.Forms.Label();
            taskStartLabel = new System.Windows.Forms.Label();
            taskEndLabel = new System.Windows.Forms.Label();
            taskStatusLabel = new System.Windows.Forms.Label();
            projectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingNavigator)).BeginInit();
            this.tasksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskIDLabel
            // 
            taskIDLabel.AutoSize = true;
            taskIDLabel.Location = new System.Drawing.Point(12, 37);
            taskIDLabel.Name = "taskIDLabel";
            taskIDLabel.Size = new System.Drawing.Size(48, 13);
            taskIDLabel.TabIndex = 1;
            taskIDLabel.Text = "Task ID:";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new System.Drawing.Point(12, 63);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new System.Drawing.Size(65, 13);
            taskNameLabel.TabIndex = 3;
            taskNameLabel.Text = "Task Name:";
            // 
            // taskDescriptionLabel
            // 
            taskDescriptionLabel.AutoSize = true;
            taskDescriptionLabel.Location = new System.Drawing.Point(12, 89);
            taskDescriptionLabel.Name = "taskDescriptionLabel";
            taskDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            taskDescriptionLabel.TabIndex = 5;
            taskDescriptionLabel.Text = "Description:";
            // 
            // taskStartLabel
            // 
            taskStartLabel.AutoSize = true;
            taskStartLabel.Location = new System.Drawing.Point(12, 116);
            taskStartLabel.Name = "taskStartLabel";
            taskStartLabel.Size = new System.Drawing.Size(59, 13);
            taskStartLabel.TabIndex = 7;
            taskStartLabel.Text = "Task Start:";
            // 
            // taskEndLabel
            // 
            taskEndLabel.AutoSize = true;
            taskEndLabel.Location = new System.Drawing.Point(12, 142);
            taskEndLabel.Name = "taskEndLabel";
            taskEndLabel.Size = new System.Drawing.Size(56, 13);
            taskEndLabel.TabIndex = 9;
            taskEndLabel.Text = "Task End:";
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Location = new System.Drawing.Point(12, 167);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new System.Drawing.Size(67, 13);
            taskStatusLabel.TabIndex = 11;
            taskStatusLabel.Text = "Task Status:";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Location = new System.Drawing.Point(12, 193);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new System.Drawing.Size(57, 13);
            projectLabel.TabIndex = 13;
            projectLabel.Text = "Project ID:";
            // 
            // sbdProjectsDataSet
            // 
            this.sbdProjectsDataSet.DataSetName = "sbdProjectsDataSet";
            this.sbdProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTimeTableAdapter = null;
            // 
            // tasksBindingNavigator
            // 
            this.tasksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tasksBindingNavigator.BindingSource = this.tasksBindingSource;
            this.tasksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tasksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tasksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tasksBindingNavigatorSaveItem});
            this.tasksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tasksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tasksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tasksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tasksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tasksBindingNavigator.Name = "tasksBindingNavigator";
            this.tasksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tasksBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.tasksBindingNavigator.TabIndex = 0;
            this.tasksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tasksBindingNavigatorSaveItem
            // 
            this.tasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tasksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tasksBindingNavigatorSaveItem.Image")));
            this.tasksBindingNavigatorSaveItem.Name = "tasksBindingNavigatorSaveItem";
            this.tasksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tasksBindingNavigatorSaveItem.Text = "Save Data";
            this.tasksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tasksBindingNavigatorSaveItem_Click);
            // 
            // taskIDTextBox
            // 
            this.taskIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "TaskID", true));
            this.taskIDTextBox.Location = new System.Drawing.Point(108, 34);
            this.taskIDTextBox.Name = "taskIDTextBox";
            this.taskIDTextBox.ReadOnly = true;
            this.taskIDTextBox.Size = new System.Drawing.Size(355, 20);
            this.taskIDTextBox.TabIndex = 2;
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "TaskName", true));
            this.taskNameTextBox.Location = new System.Drawing.Point(108, 60);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(355, 20);
            this.taskNameTextBox.TabIndex = 4;
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "TaskDescription", true));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(108, 86);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(355, 20);
            this.taskDescriptionTextBox.TabIndex = 6;
            // 
            // taskStartDateTimePicker
            // 
            this.taskStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tasksBindingSource, "TaskStart", true));
            this.taskStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskStartDateTimePicker.Location = new System.Drawing.Point(108, 112);
            this.taskStartDateTimePicker.Name = "taskStartDateTimePicker";
            this.taskStartDateTimePicker.Size = new System.Drawing.Size(355, 20);
            this.taskStartDateTimePicker.TabIndex = 8;
            // 
            // taskEndDateTimePicker
            // 
            this.taskEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tasksBindingSource, "TaskEnd", true));
            this.taskEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskEndDateTimePicker.Location = new System.Drawing.Point(108, 138);
            this.taskEndDateTimePicker.Name = "taskEndDateTimePicker";
            this.taskEndDateTimePicker.Size = new System.Drawing.Size(355, 20);
            this.taskEndDateTimePicker.TabIndex = 10;
            // 
            // projectTextBox
            // 
            this.projectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Project", true));
            this.projectTextBox.Location = new System.Drawing.Point(108, 190);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(355, 20);
            this.projectTextBox.TabIndex = 14;
            // 
            // taskStatusTextBox
            // 
            this.taskStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "TaskStatus", true));
            this.taskStatusTextBox.Location = new System.Drawing.Point(108, 164);
            this.taskStatusTextBox.Name = "taskStatusTextBox";
            this.taskStatusTextBox.Size = new System.Drawing.Size(355, 20);
            this.taskStatusTextBox.TabIndex = 12;
            // 
            // frmTasksDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 221);
            this.Controls.Add(taskIDLabel);
            this.Controls.Add(this.taskIDTextBox);
            this.Controls.Add(taskNameLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(taskDescriptionLabel);
            this.Controls.Add(this.taskDescriptionTextBox);
            this.Controls.Add(taskStartLabel);
            this.Controls.Add(this.taskStartDateTimePicker);
            this.Controls.Add(taskEndLabel);
            this.Controls.Add(this.taskEndDateTimePicker);
            this.Controls.Add(taskStatusLabel);
            this.Controls.Add(this.taskStatusTextBox);
            this.Controls.Add(projectLabel);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.tasksBindingNavigator);
            this.Name = "frmTasksDatabase";
            this.Text = "Tasks Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTasksDatabase_FormClosed);
            this.Load += new System.EventHandler(this.frmTasksDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingNavigator)).EndInit();
            this.tasksBindingNavigator.ResumeLayout(false);
            this.tasksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sbdProjectsDataSet sbdProjectsDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private sbdProjectsDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private sbdProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tasksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tasksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox taskIDTextBox;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker taskStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker taskEndDateTimePicker;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.TextBox taskStatusTextBox;
    }
}