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
    public partial class YearGroup : Form
    {
        public YearGroup()
        {
            InitializeComponent();
        }

        private void YearGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDTYearGroup.yeargroup' table. You can move, or remove it, as needed.
            this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);
            
        }

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();
            dbc.insertYG(new YearGroupCL(0, txtGroupName.Text, int.Parse(txtGroupSizeTB.Text)));
            this.yeargroupTableAdapter.Fill(this.timetableDTYearGroup.yeargroup);
            MessageBox.Show(" year group information added");
            
        }

        private void grpGroup_Enter(object sender, EventArgs e)
        {

        }


        private void txtgroupIDTB_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGroupSizeTB_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
