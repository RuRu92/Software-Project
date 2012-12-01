using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Timetable : Form
    {
        private TableLayoutPanel tlp; 
        /// <summary>
        /// 
        /// </summary>
        public Timetable()
        {
            InitializeComponent();
            this.tlp = new TableLayoutPanel();

        }

        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module modFrom = new Module();
            modFrom.ShowDialog();
            this.Show();
        }

        private void addYearGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearGroup yearGFrom = new YearGroup();
            yearGFrom.ShowDialog();
            this.Show();
        }
       
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableseDataSetLesson.lesson' table. You can move, or remove it, as needed.

            this.tlpGrid.AllowDrop = true;
            this.tlpGrid.DragOver += new DragEventHandler(tlpGrid_DragOver);
            this.tlpGrid.DragDrop += new DragEventHandler(tlpGrid_DragDrop); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0,0,800,350));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

       private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lectfrom = new Lecturer();
            lectfrom.ShowDialog();
            this.Show();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room roomForm = new Room();            
            roomForm.ShowDialog();
            this.Show();
        }

        private void lessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson lesWin = new Lesson();
            lesWin.ShowDialog();
            this.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tlpGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        void tlpGrid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void tlpGrid_DragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (c != null)
            {
                c.Location = this.tlpGrid.PointToClient(new Point(e.X, e.Y));
                this.tlpGrid.Controls.Add(c);
            }
        }
    }
}
