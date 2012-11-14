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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

            
        }

        private void lectName_TextChanged(object sender, EventArgs e)
        {
            LecturerCL lectClass = new LecturerCL();
            lectClass.lectName = lectName.Text;

        }

        private void staffID_TextChanged(object sender, EventArgs e)
        {

            LecturerCL lectClass = new LecturerCL();
            // this small bool that allows an int to be passed into a text box 
            // in this case it is the Staff ID that are  passed  in.
            int num;
            bool flag = int.TryParse(staffID.Text, out num);
            if (flag)
                lectClass.LectID = num;

        }

        private void teachingHrs_TextChanged(object sender, EventArgs e)
        {
            LecturerCL lectClass = new LecturerCL();
            // this small bool that allows an int to be passed into a text box 
            // in this case it is the teaching hours that are  passed  in.
            int num;
            bool flag = int.TryParse(teachingHrs.Text, out num);
            if(flag)
                lectClass.TeachingHrs = num;
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Lecturer lectfrom = new Lecturer();
            this.Close();
           
        }
    }
}