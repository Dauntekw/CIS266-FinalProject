namespace ProjectTracking
{
    partial class frmProjectDetailsAndTasksView
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
            System.Windows.Forms.Label projectIDLabel;
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label projectDescriptionLabel;
            System.Windows.Forms.Label projectStatusLabel;
            System.Windows.Forms.Label projectStartLabel;
            System.Windows.Forms.Label projectEndLabel;
            System.Windows.Forms.Label projectManagerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDetailsAndTasksView));
            this.sbdProjectsDataSet = new ProjectTracking.sbdProjectsDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.EmployeesTableAdapter();
            this.statusTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.StatusTableAdapter();
            this.tasksTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.TasksTableAdapter();
            this.projectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.taskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            projectIDLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            projectDescriptionLabel = new System.Windows.Forms.Label();
            projectStatusLabel = new System.Windows.Forms.Label();
            projectStartLabel = new System.Windows.Forms.Label();
            projectEndLabel = new System.Windows.Forms.Label();
            projectManagerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingNavigator)).BeginInit();
            this.projectsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.Location = new System.Drawing.Point(469, 36);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(21, 13);
            projectIDLabel.TabIndex = 15;
            projectIDLabel.Text = "ID:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(31, 36);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(38, 13);
            projectNameLabel.TabIndex = 17;
            projectNameLabel.Text = "Name:";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.AutoSize = true;
            projectDescriptionLabel.Location = new System.Drawing.Point(6, 119);
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            projectDescriptionLabel.TabIndex = 19;
            projectDescriptionLabel.Text = "Description:";
            // 
            // projectStatusLabel
            // 
            projectStatusLabel.AutoSize = true;
            projectStatusLabel.Location = new System.Drawing.Point(450, 65);
            projectStatusLabel.Name = "projectStatusLabel";
            projectStatusLabel.Size = new System.Drawing.Size(40, 13);
            projectStatusLabel.TabIndex = 21;
            projectStatusLabel.Text = "Status:";
            // 
            // projectStartLabel
            // 
            projectStartLabel.AutoSize = true;
            projectStartLabel.Location = new System.Drawing.Point(11, 94);
            projectStartLabel.Name = "projectStartLabel";
            projectStartLabel.Size = new System.Drawing.Size(58, 13);
            projectStartLabel.TabIndex = 23;
            projectStartLabel.Text = "Start Date:";
            // 
            // projectEndLabel
            // 
            projectEndLabel.AutoSize = true;
            projectEndLabel.Location = new System.Drawing.Point(222, 94);
            projectEndLabel.Name = "projectEndLabel";
            projectEndLabel.Size = new System.Drawing.Size(55, 13);
            projectEndLabel.TabIndex = 25;
            projectEndLabel.Text = "End Date:";
            // 
            // projectManagerLabel
            // 
            projectManagerLabel.AutoSize = true;
            projectManagerLabel.Location = new System.Drawing.Point(17, 65);
            projectManagerLabel.Name = "projectManagerLabel";
            projectManagerLabel.Size = new System.Drawing.Size(52, 13);
            projectManagerLabel.TabIndex = 29;
            projectManagerLabel.Text = "Manager:";
            // 
            // sbdProjectsDataSet
            // 
            this.sbdProjectsDataSet.DataSetName = "sbdProjectsDataSet";
            this.sbdProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTimeTableAdapter = null;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // projectsBindingNavigator
            // 
            this.projectsBindingNavigator.AddNewItem = null;
            this.projectsBindingNavigator.BindingSource = this.projectsBindingSource;
            this.projectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projectsBindingNavigator.DeleteItem = null;
            this.projectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.projectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.projectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projectsBindingNavigator.Name = "projectsBindingNavigator";
            this.projectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projectsBindingNavigator.Size = new System.Drawing.Size(830, 25);
            this.projectsBindingNavigator.TabIndex = 0;
            this.projectsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
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
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataSource = this.projectsBindingSource;
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AllowUserToAddRows = false;
            this.tasksDataGridView.AllowUserToDeleteRows = false;
            this.tasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksDataGridView.AutoGenerateColumns = false;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIDDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskDescriptionDataGridViewTextBoxColumn,
            this.taskStartDataGridViewTextBoxColumn,
            this.taskEndDataGridViewTextBoxColumn,
            this.taskStatusDataGridViewTextBoxColumn});
            this.tasksDataGridView.DataMember = "FK_Tasks_Projects";
            this.tasksDataGridView.DataSource = this.projectsBindingSource;
            this.tasksDataGridView.Location = new System.Drawing.Point(9, 188);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.Size = new System.Drawing.Size(809, 182);
            this.tasksDataGridView.TabIndex = 15;
            // 
            // taskIDDataGridViewTextBoxColumn
            // 
            this.taskIDDataGridViewTextBoxColumn.DataPropertyName = "TaskID";
            this.taskIDDataGridViewTextBoxColumn.HeaderText = "Task ID";
            this.taskIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.taskIDDataGridViewTextBoxColumn.Name = "taskIDDataGridViewTextBoxColumn";
            this.taskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 25;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // taskDescriptionDataGridViewTextBoxColumn
            // 
            this.taskDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TaskDescription";
            this.taskDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.taskDescriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.taskDescriptionDataGridViewTextBoxColumn.Name = "taskDescriptionDataGridViewTextBoxColumn";
            this.taskDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskDescriptionDataGridViewTextBoxColumn.Width = 260;
            // 
            // taskStartDataGridViewTextBoxColumn
            // 
            this.taskStartDataGridViewTextBoxColumn.DataPropertyName = "TaskStart";
            this.taskStartDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.taskStartDataGridViewTextBoxColumn.Name = "taskStartDataGridViewTextBoxColumn";
            this.taskStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskEndDataGridViewTextBoxColumn
            // 
            this.taskEndDataGridViewTextBoxColumn.DataPropertyName = "TaskEnd";
            this.taskEndDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.taskEndDataGridViewTextBoxColumn.Name = "taskEndDataGridViewTextBoxColumn";
            this.taskEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskStatusDataGridViewTextBoxColumn
            // 
            this.taskStatusDataGridViewTextBoxColumn.DataPropertyName = "TaskStatus";
            this.taskStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.taskStatusDataGridViewTextBoxColumn.Name = "taskStatusDataGridViewTextBoxColumn";
            this.taskStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectID", true));
            this.projectIDTextBox.Location = new System.Drawing.Point(496, 33);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.ReadOnly = true;
            this.projectIDTextBox.Size = new System.Drawing.Size(322, 20);
            this.projectIDTextBox.TabIndex = 16;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(75, 33);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.ReadOnly = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(322, 20);
            this.projectNameTextBox.TabIndex = 18;
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectDescription", true));
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(75, 116);
            this.projectDescriptionTextBox.Multiline = true;
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.ReadOnly = true;
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(743, 66);
            this.projectDescriptionTextBox.TabIndex = 20;
            // 
            // projectStartDateTimePicker
            // 
            this.projectStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectsBindingSource, "ProjectStart", true));
            this.projectStartDateTimePicker.Enabled = false;
            this.projectStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectStartDateTimePicker.Location = new System.Drawing.Point(75, 90);
            this.projectStartDateTimePicker.Name = "projectStartDateTimePicker";
            this.projectStartDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.projectStartDateTimePicker.TabIndex = 24;
            // 
            // projectEndDateTimePicker
            // 
            this.projectEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectsBindingSource, "ProjectEnd", true));
            this.projectEndDateTimePicker.Enabled = false;
            this.projectEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectEndDateTimePicker.Location = new System.Drawing.Point(283, 90);
            this.projectEndDateTimePicker.Name = "projectEndDateTimePicker";
            this.projectEndDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.projectEndDateTimePicker.TabIndex = 26;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.sbdProjectsDataSet;
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.projectsBindingSource, "ProjectStatus", true));
            this.txtStatus.Location = new System.Drawing.Point(496, 62);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(322, 20);
            this.txtStatus.TabIndex = 29;
            // 
            // txtManager
            // 
            this.txtManager.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.projectsBindingSource, "ProjectManager", true));
            this.txtManager.Location = new System.Drawing.Point(75, 62);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(322, 20);
            this.txtManager.TabIndex = 30;
            // 
            // frmProjectDetailsAndTasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 380);
            this.Controls.Add(projectManagerLabel);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.projectIDTextBox);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(projectDescriptionLabel);
            this.Controls.Add(this.projectDescriptionTextBox);
            this.Controls.Add(projectStatusLabel);
            this.Controls.Add(projectStartLabel);
            this.Controls.Add(this.projectStartDateTimePicker);
            this.Controls.Add(projectEndLabel);
            this.Controls.Add(this.projectEndDateTimePicker);
            this.Controls.Add(this.tasksDataGridView);
            this.Controls.Add(this.projectsBindingNavigator);
            this.Name = "frmProjectDetailsAndTasksView";
            this.Text = "Projects - Details and Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProjectDetailsAndTasksView_FormClosing);
            this.Load += new System.EventHandler(this.frmProjectTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingNavigator)).EndInit();
            this.projectsBindingNavigator.ResumeLayout(false);
            this.projectsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sbdProjectsDataSet sbdProjectsDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private sbdProjectsDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private sbdProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator projectsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private sbdProjectsDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private sbdProjectsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker projectStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker projectEndDateTimePicker;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private sbdProjectsDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStatusDataGridViewTextBoxColumn;
    }
}