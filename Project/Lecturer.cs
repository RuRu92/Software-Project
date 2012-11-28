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
    /// <summary>
    /// this is the lectuer from class that holds all the controls and information
    /// </summary>
    public partial class Lecturer : Form
    {
        /// <summary>
        /// this initializes the form so it can be used  
        /// </summary>
        public Lecturer()
        {
            InitializeComponent();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTableDBLect.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter1.Fill(this.timeTableDBLect.lecturer);
            
        }
        /// <summary>
        /// allows the user to go back to the main timetable form when this
        /// button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            // close the from and dispalys the time table form 
            Lecturer lectfrom = new Lecturer();
            this.Close();

        }
        /// <summary>
        /// this  allow the user to  and a  lectuer  to the 
        /// database and show it in the datagridLect the  the user can see 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();

            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it 
            dbc.InsertLect(new LecturerCL(0, txtLectName.Text, int.Parse(txtTeachingHrs.Text), int.Parse(txtReqHrs.Text)));
            this.lecturerTableAdapter1.Fill(this.timeTableDBLect.lecturer);
            MessageBox.Show("lectuer information added");

        }
        /// <summary>
        /// this button allows the user to 
        /// delete a sectected lecuter from the dataGridView based  on the 
        /// frist Colume and the frist Cell   
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // if statement that counts the number of recods in the 
            //table and deletes the one thats secleted
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