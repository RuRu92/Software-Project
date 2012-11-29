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
    public partial class Lesson : Form
    {
        public Lesson()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Lesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableseDataSet1.ttableday' table. You can move, or remove it, as needed.
            this.ttabledayTableAdapter.Fill(this.timetableseDataSet1.ttableday);
            // TODO: This line of code loads data into the 'startTimeDB.ttabletime' table. You can move, or remove it, as needed.
            this.ttabletimeTableAdapter.Fill(this.startTimeDB.ttabletime);
            // TODO: This line of code loads data into the 'timetableseDataSetLess.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter1.Fill(this.timetableseDataSetLess.lesson);
            // TODO: This line of code loads data into the 'timetableseDataSetRoom.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);
            // TODO: This line of code loads data into the 'timetableDTYearGroup.yeargroup' table. You can move, or remove it, as needed.
            this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);
            // TODO: This line of code loads data into the 'timetableDBModule.module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.timetableDBModule.module);
            // TODO: This line of code loads data into the 'timeTableDBLect.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.timeTableDBLect.lecturer);
            // TODO: This line of code loads data into the 'timetableseDataSetLesson.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.timetableseDataSetLesson.lesson);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLect_Click(object sender, EventArgs e)
        {

        }

        private void cmbLec_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (dbc.checkClash(cmbLec.Text, cmbGroup.Text, cmbRoom.Text, cmbMod.Text))
            {
                MessageBox.Show("Sorry there is a clash with your selection");
                return;
            }

            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it
            int t;
            if (cmbTime.Text == "")
                t = 0;
            else
            t = int.Parse(cmbTime.Text);
            dbc.InsertLess(new LessonCL(0, cmbLec.Text, cmbGroup.Text, cmbRoom.Text, cmbMod.Text,t ));
            this.lessonTableAdapter1.Fill(this.timetableseDataSetLess.lesson);
            MessageBox.Show("Lesson added information added");
        }
     } 
  }

