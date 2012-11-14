using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class RoomList
    {
        public List<RoomCL> m_RoomList;

        //Initializes array list
        public RoomList()
        {
            m_RoomList = new List<RoomCL>();
        }
        // Add Contact
        public void addRecord(RoomCL r)
        {
            m_RoomList.Add(r);
        }
        // Delete Contact
        public void deleteRecord(RoomCL r)
        {
            m_RoomList.Remove(r);
        }

        public void deleteAllRecords(RoomCL r)
        {
            //m_Addresses.RemoveAll();
        }

        // Replace existing contact with the new contact
        public void updateRecord(RoomCL r, int oldr)
        {
            m_RoomList[oldr] = r;
        }
    }
}