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
            // TODO: This line of code loads data into the 'timetableseDataSetRoom.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'timetableseDataSetRoom.room' table. You can move, or remove it, as needed.
            //this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);
            DBconnector dbc = new DBconnector();

            //TODO: Validate Data
            // adds the room information form the text boxes to the  databases and up dates it 
             dbc.InsertRoom(new RoomCL(0, txtRName.Text, txtType.Text, int.Parse(txtCap.Text)));
             this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);
             MessageBox.Show("Room information added");
        }
        }
    }