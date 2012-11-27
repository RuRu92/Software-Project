namespace Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addYearGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblTime4 = new System.Windows.Forms.Label();
            this.lblTime5 = new System.Windows.Forms.Label();
            this.lblTime6 = new System.Windows.Forms.Label();
            this.lblTime7 = new System.Windows.Forms.Label();
            this.lblTime8 = new System.Windows.Forms.Label();
            this.lblTime9 = new System.Windows.Forms.Label();
            this.timetableseDataSetLesson = new Project.timetableseDataSetLesson();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Project.timetableseDataSetLessonTableAdapters.lessonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDayTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleidModuleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureridLecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearGroupidYearGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableidTimetableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntAddLesson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tlpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDataSetLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1039, 25);
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
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.newToolStripMenuItem.Text = "Create New Timetable";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openToolStripMenuItem.Text = "Open Timetable";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(231, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "Edit Timetable";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(147, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModuleToolStripMenuItem,
            this.addLecturerToolStripMenuItem,
            this.addYearGroupToolStripMenuItem,
            this.addRoomToolStripMenuItem,
            this.lessonToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // addModuleToolStripMenuItem
            // 
            this.addModuleToolStripMenuItem.Name = "addModuleToolStripMenuItem";
            this.addModuleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addModuleToolStripMenuItem.Text = "Module options";
            this.addModuleToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // addLecturerToolStripMenuItem
            // 
            this.addLecturerToolStripMenuItem.Name = "addLecturerToolStripMenuItem";
            this.addLecturerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addLecturerToolStripMenuItem.Text = "Lecturer options";
            this.addLecturerToolStripMenuItem.Click += new System.EventHandler(this.addLecturerToolStripMenuItem_Click);
            // 
            // addYearGroupToolStripMenuItem
            // 
            this.addYearGroupToolStripMenuItem.Name = "addYearGroupToolStripMenuItem";
            this.addYearGroupToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addYearGroupToolStripMenuItem.Text = "Year Group options";
            this.addYearGroupToolStripMenuItem.Click += new System.EventHandler(this.addYearGroupToolStripMenuItem_Click);
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addRoomToolStripMenuItem.Text = "Room options";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
            // tlpGrid
            // 
            this.tlpGrid.BackColor = System.Drawing.Color.Lavender;
            this.tlpGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpGrid.ColumnCount = 10;
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4568F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504801F));
            this.tlpGrid.Controls.Add(this.lblFri, 0, 5);
            this.tlpGrid.Controls.Add(this.lblMon, 0, 1);
            this.tlpGrid.Controls.Add(this.lblTue, 0, 2);
            this.tlpGrid.Controls.Add(this.lblWed, 0, 3);
            this.tlpGrid.Controls.Add(this.lblThu, 0, 4);
            this.tlpGrid.Controls.Add(this.panel1, 1, 1);
            this.tlpGrid.Controls.Add(this.lblTime1, 1, 0);
            this.tlpGrid.Controls.Add(this.lblTime2, 2, 0);
            this.tlpGrid.Controls.Add(this.lblTime3, 3, 0);
            this.tlpGrid.Controls.Add(this.lblTime4, 4, 0);
            this.tlpGrid.Controls.Add(this.lblTime5, 5, 0);
            this.tlpGrid.Controls.Add(this.lblTime6, 6, 0);
            this.tlpGrid.Controls.Add(this.lblTime7, 7, 0);
            this.tlpGrid.Controls.Add(this.lblTime8, 8, 0);
            this.tlpGrid.Controls.Add(this.lblTime9, 9, 0);
            this.tlpGrid.Location = new System.Drawing.Point(21, 279);
            this.tlpGrid.Name = "tlpGrid";
            this.tlpGrid.RowCount = 6;
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tlpGrid.Size = new System.Drawing.Size(880, 424);
            this.tlpGrid.TabIndex = 2;
            this.tlpGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_2);
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFri.Location = new System.Drawing.Point(6, 345);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(116, 76);
            this.lblFri.TabIndex = 4;
            this.lblFri.Text = "Friday";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMon
            // 
            this.lblMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMon.Location = new System.Drawing.Point(6, 49);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(116, 71);
            this.lblMon.TabIndex = 0;
            this.lblMon.Text = "Monday";
            this.lblMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMon.Click += new System.EventHandler(this.lbbMon_Click);
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTue.Location = new System.Drawing.Point(6, 123);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(116, 71);
            this.lblTue.TabIndex = 1;
            this.lblTue.Text = "Tuesday";
            this.lblTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWed.Location = new System.Drawing.Point(6, 197);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(116, 71);
            this.lblWed.TabIndex = 2;
            this.lblWed.Text = "Wednesday";
            this.lblWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThu.Location = new System.Drawing.Point(6, 271);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(116, 71);
            this.lblThu.TabIndex = 3;
            this.lblThu.Text = "Thursday";
            this.lblThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(131, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 65);
            this.panel1.TabIndex = 5;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime1.Location = new System.Drawing.Point(131, 3);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(74, 43);
            this.lblTime1.TabIndex = 6;
            this.lblTime1.Text = "8:00";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime2.Location = new System.Drawing.Point(214, 3);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(74, 43);
            this.lblTime2.TabIndex = 7;
            this.lblTime2.Text = "09:00";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime3.Location = new System.Drawing.Point(297, 3);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(74, 43);
            this.lblTime3.TabIndex = 8;
            this.lblTime3.Text = "10:00";
            this.lblTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime4
            // 
            this.lblTime4.AutoSize = true;
            this.lblTime4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime4.Location = new System.Drawing.Point(380, 3);
            this.lblTime4.Name = "lblTime4";
            this.lblTime4.Size = new System.Drawing.Size(74, 43);
            this.lblTime4.TabIndex = 9;
            this.lblTime4.Text = "11:00";
            this.lblTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime5
            // 
            this.lblTime5.AutoSize = true;
            this.lblTime5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime5.Location = new System.Drawing.Point(463, 3);
            this.lblTime5.Name = "lblTime5";
            this.lblTime5.Size = new System.Drawing.Size(74, 43);
            this.lblTime5.TabIndex = 10;
            this.lblTime5.Text = "12:00";
            this.lblTime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime6
            // 
            this.lblTime6.AutoSize = true;
            this.lblTime6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime6.Location = new System.Drawing.Point(546, 3);
            this.lblTime6.Name = "lblTime6";
            this.lblTime6.Size = new System.Drawing.Size(74, 43);
            this.lblTime6.TabIndex = 11;
            this.lblTime6.Text = "13:00";
            this.lblTime6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime7
            // 
            this.lblTime7.AutoSize = true;
            this.lblTime7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime7.Location = new System.Drawing.Point(629, 3);
            this.lblTime7.Name = "lblTime7";
            this.lblTime7.Size = new System.Drawing.Size(74, 43);
            this.lblTime7.TabIndex = 12;
            this.lblTime7.Text = "14:00";
            this.lblTime7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime8
            // 
            this.lblTime8.AutoSize = true;
            this.lblTime8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime8.Location = new System.Drawing.Point(712, 3);
            this.lblTime8.Name = "lblTime8";
            this.lblTime8.Size = new System.Drawing.Size(74, 43);
            this.lblTime8.TabIndex = 13;
            this.lblTime8.Text = "15:00";
            this.lblTime8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime9
            // 
            this.lblTime9.AutoSize = true;
            this.lblTime9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime9.Location = new System.Drawing.Point(795, 3);
            this.lblTime9.Name = "lblTime9";
            this.lblTime9.Size = new System.Drawing.Size(79, 43);
            this.lblTime9.TabIndex = 14;
            this.lblTime9.Text = "16:00";
            this.lblTime9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timetableseDataSetLesson
            // 
            this.timetableseDataSetLesson.DataSetName = "timetableseDataSetLesson";
            this.timetableseDataSetLesson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.timetableseDataSetLesson;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLessonDataGridViewTextBoxColumn,
            this.lessonLengthDataGridViewTextBoxColumn,
            this.lessonDayTimeDataGridViewTextBoxColumn,
            this.roomidRoomDataGridViewTextBoxColumn,
            this.moduleidModuleDataGridViewTextBoxColumn,
            this.lectureridLecturerDataGridViewTextBoxColumn,
            this.yearGroupidYearGroupDataGridViewTextBoxColumn,
            this.timetableidTimetableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 89);
            this.dataGridView1.TabIndex = 3;
            // 
            // idLessonDataGridViewTextBoxColumn
            // 
            this.idLessonDataGridViewTextBoxColumn.DataPropertyName = "idLesson";
            this.idLessonDataGridViewTextBoxColumn.HeaderText = "idLesson";
            this.idLessonDataGridViewTextBoxColumn.Name = "idLessonDataGridViewTextBoxColumn";
            // 
            // lessonLengthDataGridViewTextBoxColumn
            // 
            this.lessonLengthDataGridViewTextBoxColumn.DataPropertyName = "lessonLength";
            this.lessonLengthDataGridViewTextBoxColumn.HeaderText = "lessonLength";
            this.lessonLengthDataGridViewTextBoxColumn.Name = "lessonLengthDataGridViewTextBoxColumn";
            // 
            // lessonDayTimeDataGridViewTextBoxColumn
            // 
            this.lessonDayTimeDataGridViewTextBoxColumn.DataPropertyName = "lessonDayTime";
            this.lessonDayTimeDataGridViewTextBoxColumn.HeaderText = "lessonDayTime";
            this.lessonDayTimeDataGridViewTextBoxColumn.Name = "lessonDayTimeDataGridViewTextBoxColumn";
            // 
            // roomidRoomDataGridViewTextBoxColumn
            // 
            this.roomidRoomDataGridViewTextBoxColumn.DataPropertyName = "Room_idRoom";
            this.roomidRoomDataGridViewTextBoxColumn.HeaderText = "Room_idRoom";
            this.roomidRoomDataGridViewTextBoxColumn.Name = "roomidRoomDataGridViewTextBoxColumn";
            // 
            // moduleidModuleDataGridViewTextBoxColumn
            // 
            this.moduleidModuleDataGridViewTextBoxColumn.DataPropertyName = "Module_idModule";
            this.moduleidModuleDataGridViewTextBoxColumn.HeaderText = "Module_idModule";
            this.moduleidModuleDataGridViewTextBoxColumn.Name = "moduleidModuleDataGridViewTextBoxColumn";
            // 
            // lectureridLecturerDataGridViewTextBoxColumn
            // 
            this.lectureridLecturerDataGridViewTextBoxColumn.DataPropertyName = "Lecturer_idLecturer";
            this.lectureridLecturerDataGridViewTextBoxColumn.HeaderText = "Lecturer_idLecturer";
            this.lectureridLecturerDataGridViewTextBoxColumn.Name = "lectureridLecturerDataGridViewTextBoxColumn";
            // 
            // yearGroupidYearGroupDataGridViewTextBoxColumn
            // 
            this.yearGroupidYearGroupDataGridViewTextBoxColumn.DataPropertyName = "YearGroup_idYearGroup";
            this.yearGroupidYearGroupDataGridViewTextBoxColumn.HeaderText = "YearGroup_idYearGroup";
            this.yearGroupidYearGroupDataGridViewTextBoxColumn.Name = "yearGroupidYearGroupDataGridViewTextBoxColumn";
            // 
            // timetableidTimetableDataGridViewTextBoxColumn
            // 
            this.timetableidTimetableDataGridViewTextBoxColumn.DataPropertyName = "Timetable_idTimetable";
            this.timetableidTimetableDataGridViewTextBoxColumn.HeaderText = "Timetable_idTimetable";
            this.timetableidTimetableDataGridViewTextBoxColumn.Name = "timetableidTimetableDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(354, 176);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 27);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(510, 176);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 27);
            this.comboBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Module ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lectuer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year Group ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Timetable ID";
            // 
            // bntAddLesson
            // 
            this.bntAddLesson.Location = new System.Drawing.Point(31, 227);
            this.bntAddLesson.Name = "bntAddLesson";
            this.bntAddLesson.Size = new System.Drawing.Size(100, 27);
            this.bntAddLesson.TabIndex = 14;
            this.bntAddLesson.Text = "Add Lesson";
            this.bntAddLesson.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete Lesson";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lessonToolStripMenuItem
            // 
            this.lessonToolStripMenuItem.Name = "lessonToolStripMenuItem";
            this.lessonToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lessonToolStripMenuItem.Text = "Lesson";
            this.lessonToolStripMenuItem.Click += new System.EventHandler(this.lessonToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1039, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntAddLesson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tlpGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Timetable Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpGrid.ResumeLayout(false);
            this.tlpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableseDataSetLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addYearGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tlpGrid;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblTime4;
        private System.Windows.Forms.Label lblTime5;
        private System.Windows.Forms.Label lblTime6;
        private System.Windows.Forms.Label lblTime7;
        private System.Windows.Forms.Label lblTime8;
        private System.Windows.Forms.Label lblTime9;
        private timetableseDataSetLesson timetableseDataSetLesson;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private timetableseDataSetLessonTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLessonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonDayTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleidModuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureridLecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearGroupidYearGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetableidTimetableDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntAddLesson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem lessonToolStripMenuItem;
    }
}

