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
    public partial class Module : Form
    {
        public Module()
        {
            InitializeComponent();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDBModule.module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.timetableDBModule.module);
           
           
        }

       

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void modName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void modcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void modTeachingHrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Module modfrom = new Module();
            this.Close();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO: Validate Data
           // adds the lectuer information form the text boxes to the  databases and up dates it 
            DBconnector dbc = new DBconnector();

           // dbc.insertMOD(new ModuleCL(0, txtModName.Text, int.Parse(txtModTeachingHrs.Text), int.Parse(txtReqTeachHrs.Text)));
            dbc.insertMOD(new ModuleCL(0, txtModName.Text, int.Parse(txtReqTeachHrs.Text),int.Parse(txtModTeachingHrs.Text)));
            this.moduleTableAdapter.Fill(this.timetableDBModule.module);
            MessageBox.Show("module information added");

        }
       

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

       

       
    }
}
