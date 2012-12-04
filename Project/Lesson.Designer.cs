namespace Project
{
    partial class Lesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lesson));
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearGroupOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.yeargroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableseDS = new Project.timetableseDS();
            this.cmbMod = new System.Windows.Forms.ComboBox();
            this.moduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labEndTime = new System.Windows.Forms.Label();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmblect = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMod = new System.Windows.Forms.Label();
            this.lblYG = new System.Windows.Forms.Label();
            this.lblLect = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Project.timetableseDSTableAdapters.lessonTableAdapter();
            this.lecturerTableAdapter = new Project.timetableseDSTableAdapters.lecturerTableAdapter();
            this.moduleTableAdapter = new Project.timetableseDSTableAdapters.moduleTableAdapter();
            this.roomTableAdapter = new Project.timetableseDSTableAdapters.roomTableAdapter();
            this.yeargroupTableAdapter = new Project.timetableseDSTableAdapters.yeargroupTableAdapter();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.bntDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeargroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lectureOptionsToolStripMenuItem,
            this.moduleOptionsToolStripMenuItem,
            this.yearGroupOptionsToolStripMenuItem,
            this.roomOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // lectureOptionsToolStripMenuItem
            // 
            this.lectureOptionsToolStripMenuItem.Name = "lectureOptionsToolStripMenuItem";
            this.lectureOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lectureOptionsToolStripMenuItem.Text = "Lecturer Window";
            this.lectureOptionsToolStripMenuItem.Click += new System.EventHandler(this.lectureOptionsToolStripMenuItem_Click);
            // 
            // moduleOptionsToolStripMenuItem
            // 
            this.moduleOptionsToolStripMenuItem.Name = "moduleOptionsToolStripMenuItem";
            this.moduleOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moduleOptionsToolStripMenuItem.Text = "Module Window";
            this.moduleOptionsToolStripMenuItem.Click += new System.EventHandler(this.moduleOptionsToolStripMenuItem_Click);
            // 
            // yearGroupOptionsToolStripMenuItem
            // 
            this.yearGroupOptionsToolStripMenuItem.Name = "yearGroupOptionsToolStripMenuItem";
            this.yearGroupOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yearGroupOptionsToolStripMenuItem.Text = "Year Group Window";
            this.yearGroupOptionsToolStripMenuItem.Click += new System.EventHandler(this.yearGroupOptionsToolStripMenuItem_Click);
            // 
            // roomOptionsToolStripMenuItem
            // 
            this.roomOptionsToolStripMenuItem.Name = "roomOptionsToolStripMenuItem";
            this.roomOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomOptionsToolStripMenuItem.Text = "Room Window";
            this.roomOptionsToolStripMenuItem.Click += new System.EventHandler(this.roomOptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.yeargroupBindingSource;
            this.cmbGroup.DisplayMember = "yearGroupName";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(16, 144);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(166, 23);
            this.cmbGroup.TabIndex = 3;
            this.cmbGroup.ValueMember = "yearGroupName";
            // 
            // yeargroupBindingSource
            // 
            this.yeargroupBindingSource.DataMember = "yeargroup";
            this.yeargroupBindingSource.DataSource = this.timetableseDS;
            // 
            // timetableseDS
            // 
            this.timetableseDS.DataSetName = "timetableseDS";
            this.timetableseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMod
            // 
            this.cmbMod.DataSource = this.moduleBindingSource1;
            this.cmbMod.DisplayMember = "moduleName";
            this.cmbMod.FormattingEnabled = true;
            this.cmbMod.Location = new System.Drawing.Point(271, 64);
            this.cmbMod.Name = "cmbMod";
            this.cmbMod.Size = new System.Drawing.Size(164, 23);
            this.cmbMod.TabIndex = 4;
            this.cmbMod.ValueMember = "moduleName";
            // 
            // moduleBindingSource1
            // 
            this.moduleBindingSource1.DataMember = "module";
            this.moduleBindingSource1.DataSource = this.timetableseDS;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labEndTime);
            this.groupBox1.Controls.Add(this.cmbEndTime);
            this.groupBox1.Controls.Add(this.Day);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.cmblect);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.cmbStartTime);
            this.groupBox1.Controls.Add(this.lblRoom);
            this.groupBox1.Controls.Add(this.cmbRoom);
            this.groupBox1.Controls.Add(this.lblMod);
            this.groupBox1.Controls.Add(this.lblYG);
            this.groupBox1.Controls.Add(this.lblLect);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.cmbMod);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Input";
            // 
            // labEndTime
            // 
            this.labEndTime.AutoSize = true;
            this.labEndTime.Location = new System.Drawing.Point(497, 125);
            this.labEndTime.Name = "labEndTime";
            this.labEndTime.Size = new System.Drawing.Size(56, 15);
            this.labEndTime.TabIndex = 22;
            this.labEndTime.Text = "End Time";
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Items.AddRange(new object[] {
            "08:00",
            "08:45",
            "08:15",
            "08:55",
            "09:00",
            "09:45",
            "09:15",
            "09:55"});
            this.cmbEndTime.Location = new System.Drawing.Point(497, 144);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(166, 23);
            this.cmbEndTime.TabIndex = 21;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(268, 174);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(28, 15);
            this.Day.TabIndex = 20;
            this.Day.Text = "Day";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuseday",
            "Wednesday",
            "Thursday",
            "Firday"});
            this.cmbDay.Location = new System.Drawing.Point(271, 209);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(166, 23);
            this.cmbDay.TabIndex = 19;
            // 
            // cmblect
            // 
            this.cmblect.DataSource = this.lecturerBindingSource;
            this.cmblect.DisplayMember = "lecturerName";
            this.cmblect.FormattingEnabled = true;
            this.cmblect.Location = new System.Drawing.Point(20, 62);
            this.cmblect.Name = "cmblect";
            this.cmblect.Size = new System.Drawing.Size(162, 23);
            this.cmblect.TabIndex = 18;
            this.cmblect.ValueMember = "lecturerName";
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "lecturer";
            this.lecturerBindingSource.DataSource = this.timetableseDS;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(494, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 15);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Start Time";
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            ""});
            this.cmbStartTime.Location = new System.Drawing.Point(497, 64);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(166, 23);
            this.cmbStartTime.TabIndex = 14;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(268, 109);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 15);
            this.lblRoom.TabIndex = 11;
            this.lblRoom.Text = "Room";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.roomBindingSource;
            this.cmbRoom.DisplayMember = "roomName";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(269, 144);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(166, 23);
            this.cmbRoom.TabIndex = 10;
            this.cmbRoom.ValueMember = "roomName";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.timetableseDS;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(268, 37);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(83, 15);
            this.lblMod.TabIndex = 8;
            this.lblMod.Text = "Module Name";
            // 
            // lblYG
            // 
            this.lblYG.AutoSize = true;
            this.lblYG.Location = new System.Drawing.Point(13, 109);
            this.lblYG.Name = "lblYG";
            this.lblYG.Size = new System.Drawing.Size(67, 15);
            this.lblYG.TabIndex = 7;
            this.lblYG.Text = "Year Group";
            // 
            // lblLect
            // 
            this.lblLect.AutoSize = true;
            this.lblLect.Location = new System.Drawing.Point(13, 37);
            this.lblLect.Name = "lblLect";
            this.lblLect.Size = new System.Drawing.Size(80, 15);
            this.lblLect.TabIndex = 6;
            this.lblLect.Text = "Lecture Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 58);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(701, 499);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 58);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.timetableseDS;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // yeargroupTableAdapter
            // 
            this.yeargroupTableAdapter.ClearBeforeFill = true;
            // 
            // dgvLesson
            // 
            this.dgvLesson.AllowUserToAddRows = false;
            this.dgvLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesson.Location = new System.Drawing.Point(12, 39);
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.Size = new System.Drawing.Size(757, 150);
            this.dgvLesson.TabIndex = 9;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(349, 499);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 58);
            this.bntDelete.TabIndex = 10;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(819, 569);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.dgvLesson);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lesson";
            this.Text = "Lesson";
            this.Load += new System.EventHandler(this.Lesson_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeargroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblYG;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoom;
 
     

       
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectureOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearGroupOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomOptionsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbStartTime;
      
        private System.Windows.Forms.Label lblTime;

        private System.Windows.Forms.ComboBox cmblect;
      
      
       
       
        private System.Windows.Forms.BindingSource moduleBindingSource;
       
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.ComboBox cmbDay;
        private timetableseDS timetableseDS;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private timetableseDSTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private timetableseDSTableAdapters.lecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.BindingSource moduleBindingSource1;
        private timetableseDSTableAdapters.moduleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private timetableseDSTableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource yeargroupBindingSource;
        private timetableseDSTableAdapters.yeargroupTableAdapter yeargroupTableAdapter;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.Label labEndTime;
       
    }
}