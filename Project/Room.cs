﻿using System;
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
    /// <summary>
    /// 
    /// </summary>
    public partial class Room : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Room()
        {
            InitializeComponent();
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableseDS.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.timetableseDS.room);    
                   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
            DBconnector dbc = new DBconnector();

            //TODO: Validate Data
            // adds the room information form the text boxes to the  databases and up dates it 

             dbc.InsertRoom(new RoomCL(0, txtRName.Text, cmbType.SelectedItem.ToString(), int.Parse(txtCap.Text)));
             this.roomTableAdapter.Fill(this.timetableseDS.room);
             MessageBox.Show("Room information added");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgRoom.SelectedRows.Count > 0)
            {
                int id = (int)this.dtgRoom.SelectedRows[0].Cells[0].Value;
                DBconnector db = new DBconnector();
                db.DeleteRoom(id);
                this.roomTableAdapter.Fill(this.timetableseDS.room);            

            }
        }

        private void lectureWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lecWin = new Lecturer();
            this.Close();
            lecWin.ShowDialog();
            this.Show();
        }

        private void moduleWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module modFrom = new Module();
            this.Hide();
            modFrom.ShowDialog();
            this.Show();
        }

        private void yearGroupWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearGroup ygWin = new YearGroup();
            this.Hide();
            ygWin.ShowDialog();
            this.Show();
        }

        private void lessonWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson lesWin = new Lesson();
            this.Hide();
            lesWin.Show();
        }
    }
}