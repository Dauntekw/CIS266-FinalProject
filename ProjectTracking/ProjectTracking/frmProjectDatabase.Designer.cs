namespace ProjectTracking
{
    partial class frmProjectDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDatabase));
            this.sbdProjectsDataSet = new ProjectTracking.sbdProjectsDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new ProjectTracking.sbdProjectsDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager();
            this.projectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.projectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectStatusTextBox = new System.Windows.Forms.TextBox();
            this.projectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectManagerTextBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.Location = new System.Drawing.Point(12, 35);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(57, 13);
            projectIDLabel.TabIndex = 1;
            projectIDLabel.Text = "Project ID:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(12, 61);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 3;
            projectNameLabel.Text = "Project Name:";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.AutoSize = true;
            projectDescriptionLabel.Location = new System.Drawing.Point(12, 87);
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(99, 13);
            projectDescriptionLabel.TabIndex = 5;
            projectDescriptionLabel.Text = "Project Description:";
            // 
            // projectStatusLabel
            // 
            projectStatusLabel.AutoSize = true;
            projectStatusLabel.Location = new System.Drawing.Point(12, 113);
            projectStatusLabel.Name = "projectStatusLabel";
            projectStatusLabel.Size = new System.Drawing.Size(76, 13);
            projectStatusLabel.TabIndex = 7;
            projectStatusLabel.Text = "Project Status:";
            // 
            // projectStartLabel
            // 
            projectStartLabel.AutoSize = true;
            projectStartLabel.Location = new System.Drawing.Point(12, 140);
            projectStartLabel.Name = "projectStartLabel";
            projectStartLabel.Size = new System.Drawing.Size(68, 13);
            projectStartLabel.TabIndex = 9;
            projectStartLabel.Text = "Project Start:";
            // 
            // projectEndLabel
            // 
            projectEndLabel.AutoSize = true;
            projectEndLabel.Location = new System.Drawing.Point(12, 166);
            projectEndLabel.Name = "projectEndLabel";
            projectEndLabel.Size = new System.Drawing.Size(65, 13);
            projectEndLabel.TabIndex = 11;
            projectEndLabel.Text = "Project End:";
            // 
            // projectManagerLabel
            // 
            projectManagerLabel.AutoSize = true;
            projectManagerLabel.Location = new System.Drawing.Point(12, 191);
            projectManagerLabel.Name = "projectManagerLabel";
            projectManagerLabel.Size = new System.Drawing.Size(88, 13);
            projectManagerLabel.TabIndex = 13;
            projectManagerLabel.Text = "Project Manager:";
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
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectTracking.sbdProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTimeTableAdapter = null;
            // 
            // projectsBindingNavigator
            // 
            this.projectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.projectsBindingNavigator.BindingSource = this.projectsBindingSource;
            this.projectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.projectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.projectsBindingNavigatorSaveItem});
            this.projectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.projectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projectsBindingNavigator.Name = "projectsBindingNavigator";
            this.projectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projectsBindingNavigator.Size = new System.Drawing.Size(325, 25);
            this.projectsBindingNavigator.TabIndex = 0;
            this.projectsBindingNavigator.Text = "bindingNavigator1";
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
            // projectsBindingNavigatorSaveItem
            // 
            this.projectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projectsBindingNavigatorSaveItem.Image")));
            this.projectsBindingNavigatorSaveItem.Name = "projectsBindingNavigatorSaveItem";
            this.projectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.projectsBindingNavigatorSaveItem.Text = "Save Data";
            this.projectsBindingNavigatorSaveItem.Click += new System.EventHandler(this.projectsBindingNavigatorSaveItem_Click);
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectID", true));
            this.projectIDTextBox.Location = new System.Drawing.Point(117, 32);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.ReadOnly = true;
            this.projectIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectIDTextBox.TabIndex = 2;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(117, 58);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectNameTextBox.TabIndex = 4;
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectDescription", true));
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(117, 84);
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectDescriptionTextBox.TabIndex = 6;
            // 
            // projectStatusTextBox
            // 
            this.projectStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectStatus", true));
            this.projectStatusTextBox.Location = new System.Drawing.Point(117, 110);
            this.projectStatusTextBox.Name = "projectStatusTextBox";
            this.projectStatusTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectStatusTextBox.TabIndex = 8;
            // 
            // projectStartDateTimePicker
            // 
            this.projectStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectsBindingSource, "ProjectStart", true));
            this.projectStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectStartDateTimePicker.Location = new System.Drawing.Point(117, 136);
            this.projectStartDateTimePicker.Name = "projectStartDateTimePicker";
            this.projectStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.projectStartDateTimePicker.TabIndex = 10;
            // 
            // projectEndDateTimePicker
            // 
            this.projectEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectsBindingSource, "ProjectEnd", true));
            this.projectEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectEndDateTimePicker.Location = new System.Drawing.Point(117, 162);
            this.projectEndDateTimePicker.Name = "projectEndDateTimePicker";
            this.projectEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.projectEndDateTimePicker.TabIndex = 12;
            // 
            // projectManagerTextBox
            // 
            this.projectManagerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectManager", true));
            this.projectManagerTextBox.Location = new System.Drawing.Point(117, 188);
            this.projectManagerTextBox.Name = "projectManagerTextBox";
            this.projectManagerTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectManagerTextBox.TabIndex = 14;
            // 
            // frmProjectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 223);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.projectIDTextBox);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(projectDescriptionLabel);
            this.Controls.Add(this.projectDescriptionTextBox);
            this.Controls.Add(projectStatusLabel);
            this.Controls.Add(this.projectStatusTextBox);
            this.Controls.Add(projectStartLabel);
            this.Controls.Add(this.projectStartDateTimePicker);
            this.Controls.Add(projectEndLabel);
            this.Controls.Add(this.projectEndDateTimePicker);
            this.Controls.Add(projectManagerLabel);
            this.Controls.Add(this.projectManagerTextBox);
            this.Controls.Add(this.projectsBindingNavigator);
            this.Name = "frmProjectDatabase";
            this.Text = "Project Details Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProjectDatabase_FormClosed);
            this.Load += new System.EventHandler(this.frmProjectDetailsDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbdProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingNavigator)).EndInit();
            this.projectsBindingNavigator.ResumeLayout(false);
            this.projectsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sbdProjectsDataSet sbdProjectsDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private sbdProjectsDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private sbdProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator projectsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton projectsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.TextBox projectStatusTextBox;
        private System.Windows.Forms.DateTimePicker projectStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker projectEndDateTimePicker;
        private System.Windows.Forms.TextBox projectManagerTextBox;
    }
}