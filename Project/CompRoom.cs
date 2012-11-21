using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CompRoom : RoomCL
    {

        private int m_type;

        //Constructor with inherited propertied from Events class
        public CompRoom(int roomID, String rName, int capacity) : base(roomID, rName, capacity)
        {
            m_type = type;
        }

        public int type
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
