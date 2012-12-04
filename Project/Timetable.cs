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
        /// <summary>
        /// 
        /// </summary>
        public Timetable()
        {
            InitializeComponent();

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
             DBconnector dbc = new DBconnector();
          //  dgvT.DataSource = dbc.LessonVeiw();
             dgvTimeTable.DataSource = dbc.LessonVeiw();
            
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

    }
}
