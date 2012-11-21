using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class RoomCL
    {
            private int m_roomId;
            private String m_rName;
            private int m_capacity;

            // Constructor
            public RoomCL(int roomID, string rName, int capacity)
            {
                m_rName = rName;
                m_capacity = capacity;
                m_roomId = roomID;
            }

            // Property method to access instance varriables
            public String rName
            {
                get
                {
                    return m_rName;
                }
                set
                {
                    m_rName = value;
                }
            }

            public int capacity
            {
                get
                {
                    return m_capacity;
                }
                set
                {
                    m_capacity = value;
                }
            }

            public int roomID

            {
                get
                {
                    return m_roomId;
                }
                set
                {
                    m_roomId = value;
                }
          
            }
        }
    }
 
