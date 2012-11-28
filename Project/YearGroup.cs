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
    /// this is the  year group form  
    /// which holds all the controls for the yeargroupCL class
    /// </summary>
    public partial class YearGroup : Form
    {
        /// <summary>
        /// intializes the form to be used 
        /// </summary>
        public YearGroup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this updates the data in the datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDTYearGroup.yeargroup' table. You can move, or remove it, as needed.
            this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);
            
        }
        /// <summary>
        /// this buton allows the user to delete a module 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewYG.SelectedRows.Count > 0)
            {
                int id = (int)this.dataGridViewYG.SelectedRows[0].Cells[0].Value;
                DBconnector db = new DBconnector();
                db.DeleteYG(id);
                this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);

            }
            else
                MessageBox.Show("record not deleted");
        }
        /// <summary>
        /// this allows the user to add the yeargroup 
        /// information to the datagridview and the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();
            dbc.insertYG(new YearGroupCL(0, txtGroupName.Text, int.Parse(txtGroupSizeTB.Text)));
            this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);
            MessageBox.Show(" year group information added");
            
        }       
    }
}
