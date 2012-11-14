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
    public partial class Main : Form
    {
        private TableLayoutPanel tlp; 
        public Main()
        {
            InitializeComponent();
            this.tlp = new TableLayoutPanel();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module modFrom = new Module();
            this.Hide();
            modFrom.ShowDialog();
            this.Show();
        }

        private void addYearGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearGroup yearGFrom = new YearGroup();
            this.Hide();
            yearGFrom.ShowDialog();
            this.Show();
        }
       
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0,0,800,350));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMon_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblFri_Click(object sender, EventArgs e)
        {

        }

        private void lbbMon_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lectfrom = new Lecturer();
            this.Hide();
            lectfrom.ShowDialog();
            this.Show();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room roomForm = new Room();
            this.Hide();
            roomForm.ShowDialog();
            this.Show();
        }
    }
}
