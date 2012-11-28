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
    /// this is the module forms  that contins all the user 
    /// functions  for the module form
    /// </summary>
    public partial class Module : Form
    {

        /// <summary>
        /// initialize the form to be used and displayed 
        /// </summary>
        public Module()
        {
            InitializeComponent();
        }

        /// <summary>
        /// loads the  form infoamrtion and  updates the  
        /// datagridview to show the values stored in the database for module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Module_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDBModule.module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.timetableDBModule.module);



        }

        /// <summary>
        /// this bunton allows the  user to  go back to the timetabling form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Module modfrom = new Module();
            this.Close();

        }

        /// <summary>
        /// this allows the  user to  
        /// enter the lectuer informaton 
        /// into the database form the text boxes  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it 
            DBconnector dbc = new DBconnector();

            // dbc.insertMOD(new ModuleCL(0, txtModName.Text, int.Parse(txtModTeachingHrs.Text), int.Parse(txtReqTeachHrs.Text)));
            dbc.insertMOD(new ModuleCL(0, txtModName.Text, int.Parse(txtReqTeachHrs.Text), int.Parse(txtModTeachingHrs.Text)));
            this.moduleTableAdapter.Fill(this.timetableDBModule.module);
            MessageBox.Show("module information added");
        }

        /// <summary>
        /// allows the user to delete a seclected 
        /// modlue from the datagrid view and the data base 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewModule.SelectedRows.Count > 0)
            {
                int id = (int)this.dataGridViewModule.SelectedRows[0].Cells[0].Value;
                DBconnector db = new DBconnector();
                db.DeleteMod(id);
                this.moduleTableAdapter.Fill(this.timetableDBModule.module);





            }
        }

        private void lecturerWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lecWin = new Lecturer();
            this.Hide();
            lecWin.ShowDialog();
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