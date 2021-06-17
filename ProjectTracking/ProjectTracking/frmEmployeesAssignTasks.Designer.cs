namespace ProjectTracking
{
    partial class frmEmployeesAssignTasks
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
            System.Windows.Forms.Label workIDLabel;
            System.Windows.Forms.Label workDateLabel;
            System.Windows.Forms.Label workTimeLabel;
            System.Windows.Forms.Label taskIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeesAssignTasks));
            this.sbdProjectsDataSet = new ProjectTracking.sbdProjectsDataSet();
            this.workTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTimeTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter();
            this.tableAdapterManager = new ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.EmployeesTableAdapter();
            this.tasksTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.TasksTableAdapter();
            this.workTimeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.workTimeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workIDTextBox = new System.Windows.Forms.TextBox();
            this.workDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.taskIDComboBox = new System.Windows.Forms.ComboBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            workIDLabel = new System.Windows.Forms.Label();
            workDateLabel = new System.Windows.Forms.Label();
            workTimeLabel = new System.Windows.Forms.Label();
            taskIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeBindingNavigator)).BeginInit();
            this.workTimeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workIDLabel
            // 
            workIDLabel.AutoSize = true;
            workIDLabel.Location = new System.Drawing.Point(12, 39);
            workIDLabel.Name = "workIDLabel";
            workIDLabel.Size = new System.Drawing.Size(50, 13);
            workIDLabel.TabIndex = 1;
            workIDLabel.Text = "Work ID:";
            // 
            // workDateLabel
            // 
            workDateLabel.AutoSize = true;
            workDateLabel.Location = new System.Drawing.Point(12, 118);
            workDateLabel.Name = "workDateLabel";
            workDateLabel.Size = new System.Drawing.Size(62, 13);
            workDateLabel.TabIndex = 7;
            workDateLabel.Text = "Work Date:";
            // 
            // workTimeLabel
            // 
            workTimeLabel.AutoSize = true;
            workTimeLabel.Location = new System.Drawing.Point(12, 142);
            workTimeLabel.Name = "workTimeLabel";
            workTimeLabel.Size = new System.Drawing.Size(62, 13);
            workTimeLabel.TabIndex = 12;
            workTimeLabel.Text = "Work Time:";
            // 
            // taskIDLabel
            // 
            taskIDLabel.AutoSize = true;
            taskIDLabel.Location = new System.Drawing.Point(12, 90);
            taskIDLabel.Name = "taskIDLabel";
            taskIDLabel.Size = new System.Drawing.Size(48, 13);
            taskIDLabel.TabIndex = 13;
            taskIDLabel.Text = "Task ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(12, 63);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 14;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // sbdProjectsDataSet
            // 
            this.sbdProjectsDataSet.DataSetName = "sbdProjectsDataSet";
            this.sbdProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workTimeBindingSource
            // 
            this.workTimeBindingSource.DataMember = "WorkTime";
            this.workTimeBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // workTimeTableAdapter
            // 
            this.workTimeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTimeTableAdapter = this.workTimeTableAdapter;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // workTimeBindingNavigator
            // 
            this.workTimeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workTimeBindingNavigator.BindingSource = this.workTimeBindingSource;
            this.workTimeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workTimeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workTimeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.workTimeBindingNavigatorSaveItem});
            this.workTimeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workTimeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workTimeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workTimeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workTimeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workTimeBindingNavigator.Name = "workTimeBindingNavigator";
            this.workTimeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workTimeBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.workTimeBindingNavigator.TabIndex = 0;
            this.workTimeBindingNavigator.Text = "bindingNavigator1";
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
            // workTimeBindingNavigatorSaveItem
            // 
            this.workTimeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workTimeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workTimeBindingNavigatorSaveItem.Image")));
            this.workTimeBindingNavigatorSaveItem.Name = "workTimeBindingNavigatorSaveItem";
            this.workTimeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.workTimeBindingNavigatorSaveItem.Text = "Save Data";
            this.workTimeBindingNavigatorSaveItem.Click += new System.EventHandler(this.workTimeBindingNavigatorSaveItem_Click);
            // 
            // workIDTextBox
            // 
            this.workIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workTimeBindingSource, "WorkID", true));
            this.workIDTextBox.Location = new System.Drawing.Point(88, 36);
            this.workIDTextBox.Name = "workIDTextBox";
            this.workIDTextBox.ReadOnly = true;
            this.workIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.workIDTextBox.TabIndex = 2;
            // 
            // workDateDateTimePicker
            // 
            this.workDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workTimeBindingSource, "WorkDate", true));
            this.workDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.workDateDateTimePicker.Location = new System.Drawing.Point(88, 114);
            this.workDateDateTimePicker.Name = "workDateDateTimePicker";
            this.workDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workDateDateTimePicker.TabIndex = 8;
            // 
            // workTimeNumericUpDown
            // 
            this.workTimeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workTimeBindingSource, "WorkTime", true));
            this.workTimeNumericUpDown.DecimalPlaces = 2;
            this.workTimeNumericUpDown.Location = new System.Drawing.Point(88, 140);
            this.workTimeNumericUpDown.Name = "workTimeNumericUpDown";
            this.workTimeNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.workTimeNumericUpDown.TabIndex = 13;
            // 
            // taskIDComboBox
            // 
            this.taskIDComboBox.CausesValidation = false;
            this.taskIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workTimeBindingSource, "TaskID", true));
            this.taskIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sbdProjectsDataSet, "Tasks.TaskID", true));
            this.taskIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workTimeBindingSource, "TaskID", true));
            this.taskIDComboBox.DataSource = this.sbdProjectsDataSet;
            this.taskIDComboBox.DisplayMember = "Tasks.TaskID";
            this.taskIDComboBox.FormattingEnabled = true;
            this.taskIDComboBox.Location = new System.Drawing.Point(88, 87);
            this.taskIDComboBox.Name = "taskIDComboBox";
            this.taskIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.taskIDComboBox.TabIndex = 14;
            this.taskIDComboBox.ValueMember = "Tasks.TaskID";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.CausesValidation = false;
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workTimeBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workTimeBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.workTimeBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataSource = this.sbdProjectsDataSet;
            this.employeeIDComboBox.DisplayMember = "Employees.EmployeeID";
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(88, 60);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeIDComboBox.TabIndex = 15;
            this.employeeIDComboBox.ValueMember = "Employees.EmployeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // frmEmployeesAssignTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 180);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(taskIDLabel);
            this.Controls.Add(this.taskIDComboBox);
            this.Controls.Add(workTimeLabel);
            this.Controls.Add(this.workTimeNumericUpDown);
            this.Controls.Add(workIDLabel);
            this.Controls.Add(this.workIDTextBox);
            this.Controls.Add(workDateLabel);
            this.Controls.Add(this.workDateDateTimePicker);
            this.Controls.Add(this.workTimeBindingNavigator);
            this.Name = "frmEmployeesAssignTasks";
            this.Text = "Assign Tasks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmployeesAssignTasks_FormClosed);
            this.Load += new System.EventHandler(this.frmEmployeesAssignTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeBindingNavigator)).EndInit();
            this.workTimeBindingNavigator.ResumeLayout(false);
            this.workTimeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sbdProjectsDataSet sbdProjectsDataSet;
        private System.Windows.Forms.BindingSource workTimeBindingSource;
        private sbdProjectsDataSetTableAdapters.WorkTimeTableAdapter workTimeTableAdapter;
        private sbdProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workTimeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton workTimeBindingNavigatorSaveItem;
        private sbdProjectsDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.TextBox workIDTextBox;
        private System.Windows.Forms.DateTimePicker workDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown workTimeNumericUpDown;
        private System.Windows.Forms.ComboBox taskIDComboBox;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private sbdProjectsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}