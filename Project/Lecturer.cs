using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project
{
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTableDBLect.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter1.Fill(this.timeTableDBLect.lecturer);
            


        }

        private void lectName_TextChanged(object sender, EventArgs e)
        {
            //LecturerCL lectClass = new LecturerCL();
            //lectClass.lectName = lectName.Text;

        }
       
        private void teachingHrs_TextChanged(object sender, EventArgs e)
        {
            // this text box is were the teaching hours are enterd on the form
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close the from after crateing it 
            Lecturer lectfrom = new Lecturer();
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();

            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it 
            dbc.InsertLect(new LecturerCL(0, txtLectName.Text, int.Parse(txtTeachingHrs.Text), int.Parse(txtReqHrs.Text)));
            this.lecturerTableAdapter1.Fill(this.timeTableDBLect.lecturer);
            MessageBox.Show("lectuer information added");

        }

        private void txtReqHrs_TextChanged(object sender, EventArgs e)
        {
            // this text box is where the requied teaching hours are inputed on the form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLect.SelectedRows.Count > 0)
            {   
                int id = (int)this.dataGridViewLect.SelectedRows[0].Cells[0].Value;
                DBconnector db = new DBconnector();
                db.DeleteLect(id);
                this.lecturerTableAdapter1.Fill(this.timeTableDBLect.lecturer);
                
            }
            
        }

        private void moduleWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module modFrom = new Module();
            this.Hide();
            modFrom.ShowDialog();
            this.Show();
        }

        private void yearGroupWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearGroup ygWin = new YearGroup();
            this.Hide();
            ygWin.ShowDialog();
            this.Show();
        }

        private void roomWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room roomWin = new Room();
            this.Hide();
            roomWin.ShowDialog();
            this.Show();
        }

        private void lessonWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson lesWin = new Lesson();
            this.Hide();
            lesWin.ShowDialog();
            this.Show();
        }
    }
}