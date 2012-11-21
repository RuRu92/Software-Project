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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            DBconnector dbc = new DBconnector();

            //TODO: Validate Data
            // adds the lectuer information form the text boxes to the  databases and up dates it 
            dbc.InsertLect(new LecturerCL(0, txtRName.Text, txtType., int.Parse(txtCap.Text));
            this.roomTableAdapter.Fill(this.timeTableDBRoom.room);
            MessageBox.Show("Room information added");
        }
    }
}
