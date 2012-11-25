using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            
        }
            RoomCL room;



        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableseDataSetRoom.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);

            DBconnector dbc = new DBconnector();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM room Order by roomType", dbc);

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            da.Fill(dt);

            MySqlDataAdapter ad = new MySqlDataAdapter();
            ad.SelectCommand = new SqlCommand("SELECT roomType FROM room", dbc);
            ad.Fill(ds, "Problem");

            dtgRoom.DataSource = dt;
            //Biding the data with the control
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "Problem";

            DataGridView dvg = new DataGridView();
            this.Controls.Add(dvg);
            dvg.DataSource = bs;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbType.Items.Add(dt.Rows[i]["roomType"]);

            }
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

            switch (selectRoomType)
            {
                case LectureRoom:
                    room = new LecRoom(roomID, rName, capacity, type);
                    break;
            
                case Lab:
                    room = new LabRoom(roomID, rName, capacity, type);
                    break;

                case Network:
                    room = new NetRoom(roomID, rName, capacity, type);
                    break;

                case Network:
                    room = new CompRoom(roomID, rName, capacity, type);
                    break;
            }

             dbc.InsertRoom(room);
             this.roomTableAdapter.Fill(this.timetableseDataSetRoom.room);
             MessageBox.Show("Room information added");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }
    }
}