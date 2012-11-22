using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class LabRoom : RoomCL
    {
        String m_type;

        //Constructor with inherited propertied from Events class
        public LabRoom(int roomID, String rName, int capacity, String Type)
            : base(roomID, rName, capacity)
        {
            m_type = type;
        }

        public String type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
    }
}
