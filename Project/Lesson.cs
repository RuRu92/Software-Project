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
            // TODO: This line of code loads data into the 'timeTableDBLect.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.timeTableDBLect.lecturer);
            // TODO: This line of code loads data into the 'timetableseDataSetLesson.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.timetableseDataSetLesson.lesson);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Module modfrom = new Module();
            this.Close();
        }

        private void lblLect_Click(object sender, EventArgs e)
        {

        }

        private void cmbLec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
