namespace Project
{
    partial class Lecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.txtLectName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtTeachingHrs = new System.Windows.Forms.TextBox();
            this.txtReqHrs = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timetableseDataSet = new Project.timetableseDataSet();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new Project.timetableseDataSetTableAdapters.lecturerTableAdapter();
            this.dataGridViewLect = new System.Windows.Forms.DataGridView();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableDBLect = new Project.TimeTableDBLect();
            this.lecturerTableAdapter1 = new Project.TimeTableDBLectTableAdapters.lecturerTableAdapter();
            this.idLecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerRequiredHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerTaughtHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearGroupWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDBLect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 55);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 502);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 55);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(470, 502);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 55);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 55);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpGroup
            // 
            this.grpGroup.Controls.Add(this.txtLectName);
            this.grpGroup.Controls.Add(this.lblName);
            this.grpGroup.Controls.Add(this.lblHours);
            this.grpGroup.Controls.Add(this.txtTeachingHrs);
            this.grpGroup.Controls.Add(this.txtReqHrs);
            this.grpGroup.Controls.Add(this.lblID);
            this.grpGroup.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGroup.Location = new System.Drawing.Point(12, 232);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(513, 251);
            this.grpGroup.TabIndex = 20;
            this.grpGroup.TabStop = false;
            this.grpGroup.Text = "Lecturer Input";
            // 
            // txtLectName
            // 
            this.txtLectName.Location = new System.Drawing.Point(275, 39);
            this.txtLectName.Name = "txtLectName";
            this.txtLectName.Size = new System.Drawing.Size(182, 26);
            this.txtLectName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(28, 193);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(101, 18);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Teaching Hours";
            // 
            // txtTeachingHrs
            // 
            this.txtTeachingHrs.Location = new System.Drawing.Point(275, 190);
            this.txtTeachingHrs.Name = "txtTeachingHrs";
            this.txtTeachingHrs.Size = new System.Drawing.Size(182, 26);
            this.txtTeachingHrs.TabIndex = 5;
            // 
            // txtReqHrs
            // 
            this.txtReqHrs.Location = new System.Drawing.Point(275, 112);
            this.txtReqHrs.Name = "txtReqHrs";
            this.txtReqHrs.Size = new System.Drawing.Size(182, 26);
            this.txtReqHrs.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(28, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(159, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Requied Teaching Hours ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(140, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.searchToolStripMenuItem.Text = "User Guide";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(128, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // timetableseDataSet
            // 
            this.timetableseDataSet.DataSetName = "timetableseDataSet";
            this.timetableseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "lecturer";
            this.lecturerBindingSource.DataSource = this.timetableseDataSet;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewLect
            // 
            this.dataGridViewLect.AllowUserToAddRows = false;
            this.dataGridViewLect.AutoGenerateColumns = false;
            this.dataGridViewLect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLecturerDataGridViewTextBoxColumn,
            this.lecturerNameDataGridViewTextBoxColumn,
            this.lecturerRequiredHoursDataGridViewTextBoxColumn,
            this.lecturerTaughtHoursDataGridViewTextBoxColumn});
            this.dataGridViewLect.DataSource = this.lecturerBindingSource1;
            this.dataGridViewLect.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewLect.MultiSelect = false;
            this.dataGridViewLect.Name = "dataGridViewLect";
            this.dataGridViewLect.ReadOnly = true;
            this.dataGridViewLect.Size = new System.Drawing.Size(513, 182);
            this.dataGridViewLect.TabIndex = 23;
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataMember = "lecturer";
            this.lecturerBindingSource1.DataSource = this.timeTableDBLect;
            // 
            // timeTableDBLect
            // 
            this.timeTableDBLect.DataSetName = "TimeTableDBLect";
            this.timeTableDBLect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerTableAdapter1
            // 
            this.lecturerTableAdapter1.ClearBeforeFill = true;
            // 
            // idLecturerDataGridViewTextBoxColumn
            // 
            this.idLecturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idLecturerDataGridViewTextBoxColumn.DataPropertyName = "idLecturer";
            this.idLecturerDataGridViewTextBoxColumn.HeaderText = "Lecture ID";
            this.idLecturerDataGridViewTextBoxColumn.Name = "idLecturerDataGridViewTextBoxColumn";
            this.idLecturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLecturerDataGridViewTextBoxColumn.Width = 86;
            // 
            // lecturerNameDataGridViewTextBoxColumn
            // 
            this.lecturerNameDataGridViewTextBoxColumn.DataPropertyName = "lecturerName";
            this.lecturerNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.lecturerNameDataGridViewTextBoxColumn.Name = "lecturerNameDataGridViewTextBoxColumn";
            this.lecturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturerRequiredHoursDataGridViewTextBoxColumn
            // 
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.DataPropertyName = "lecturerRequiredHours";
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.HeaderText = "Required Hours";
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.Name = "lecturerRequiredHoursDataGridViewTextBoxColumn";
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.lecturerRequiredHoursDataGridViewTextBoxColumn.Width = 107;
            // 
            // lecturerTaughtHoursDataGridViewTextBoxColumn
            // 
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.DataPropertyName = "lecturerTaughtHours";
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.HeaderText = "Taught Hours";
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.Name = "lecturerTaughtHoursDataGridViewTextBoxColumn";
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.lecturerTaughtHoursDataGridViewTextBoxColumn.Width = 96;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleWindowToolStripMenuItem,
            this.yearGroupWindowToolStripMenuItem,
            this.roomWindowToolStripMenuItem,
            this.lessonWindowToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // moduleWindowToolStripMenuItem
            // 
            this.moduleWindowToolStripMenuItem.Name = "moduleWindowToolStripMenuItem";
            this.moduleWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moduleWindowToolStripMenuItem.Text = "Module Window";
            this.moduleWindowToolStripMenuItem.Click += new System.EventHandler(this.moduleWindowToolStripMenuItem_Click);
            // 
            // yearGroupWindowToolStripMenuItem
            // 
            this.yearGroupWindowToolStripMenuItem.Name = "yearGroupWindowToolStripMenuItem";
            this.yearGroupWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yearGroupWindowToolStripMenuItem.Text = "Year Group Window";
            this.yearGroupWindowToolStripMenuItem.Click += new System.EventHandler(this.yearGroupWindowToolStripMenuItem_Click);
            // 
            // roomWindowToolStripMenuItem
            // 
            this.roomWindowToolStripMenuItem.Name = "roomWindowToolStripMenuItem";
            this.roomWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomWindowToolStripMenuItem.Text = "Room Window";
            this.roomWindowToolStripMenuItem.Click += new System.EventHandler(this.roomWindowToolStripMenuItem_Click);
            // 
            // lessonWindowToolStripMenuItem
            // 
            this.lessonWindowToolStripMenuItem.Name = "lessonWindowToolStripMenuItem";
            this.lessonWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lessonWindowToolStripMenuItem.Text = "Lesson Window";
            this.lessonWindowToolStripMenuItem.Click += new System.EventHandler(this.lessonWindowToolStripMenuItem_Click);
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(537, 569);
            this.Controls.Add(this.dataGridViewLect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpGroup);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDBLect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.TextBox txtLectName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtTeachingHrs;
        private System.Windows.Forms.TextBox txtReqHrs;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private timetableseDataSet timetableseDataSet;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private timetableseDataSetTableAdapters.lecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewLect;
        private TimeTableDBLect timeTableDBLect;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private TimeTableDBLectTableAdapters.lecturerTableAdapter lecturerTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearGroupWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonWindowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerRequiredHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerTaughtHoursDataGridViewTextBoxColumn;

    }
}