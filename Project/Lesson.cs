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
    public partial class Lesson : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Lesson()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Lesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableseDS.yeargroup' table. You can move, or remove it, as needed.
            this.yeargroupTableAdapter.Fill(this.timetableseDS.yeargroup);
            // TODO: This line of code loads data into the 'timetableseDS.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.timetableseDS.room);
            // TODO: This line of code loads data into the 'timetableseDS.module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.timetableseDS.module);
            // TODO: This line of code loads data into the 'timetableseDS.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.timetableseDS.lecturer);

            DBconnector dbc = new DBconnector();
            dgvLesson.DataSource = dbc.LessonVeiw();
            // dt.Fill(dbc.LessonView());




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lectureOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lecWin = new Lecturer();
            lecWin.ShowDialog();
            this.Close();
        }

        private void moduleOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module modFrom = new Module();
            modFrom.ShowDialog();
            this.Close();
        }

        private void yearGroupOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearGroup ygWin = new YearGroup();
            ygWin.ShowDialog();
            this.Close();
        }

        private void roomOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room roomWin = new Room();
            roomWin.ShowDialog();
            this.Close();
        }


        // Checks user input for clashes with the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();
            if (dbc.checkClash(cmblect.Text, cmbGroup.Text, cmbRoom.Text, cmbMod.Text, cmbStartTime.Text, cmbEndTime.Text, cmbDay.Text))
            {
                MessageBox.Show("Sorry there is a clash with your selection");
                return;
            }

            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it   
            dbc.InsertLess(new LessonCL(0, cmblect.Text, cmbGroup.Text, cmbRoom.Text, cmbMod.Text, cmbStartTime.Text, cmbEndTime.Text, cmbDay.Text));
            dgvLesson.DataSource = dbc.LessonVeiw();
            MessageBox.Show("Lesson added information added");
        }

        private void button1_Click(object sender, EventArgs e)
        {

             DBconnector dbc = new DBconnector();
             int id = dbc.GetLessID(cmblect.Text, cmbGroup.Text, cmbRoom.Text, cmbMod.Text, cmbStartTime.Text, cmbDay.Text);
             if (id > -1)
             {
                 dbc.DeleteLess(id);
                 dgvLesson.DataSource = dbc.LessonVeiw();
             }
            

        }

     

     
    }
}


