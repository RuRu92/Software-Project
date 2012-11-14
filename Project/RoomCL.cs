//Purpose: To store Room details
//Version: 1.5
//Author: Ruslan Jonusas   
//Name: Software Engineering
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class RoomCL
    {
        private String m_rName;
        private int m_capacity;
        private String m_type;

         // Constructor
        public RoomCL()
        {
            m_rName = rName;
            m_capacity = capacity;
            m_type = type;
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
