using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class LessonCL
    {
        Int32 m_lessonID;
        String m_lectName;
        String m_ygName;
        String m_roomsName;
        String m_modName;
        Int32 m_lessTime;

        public LessonCL(int lessID, string lectName, String ygName, String roomsName, String modName, int lessTime)
        {

            m_lessonID = lessID;
            m_lectName = lectName;
            m_ygName = ygName;
            m_roomsName = roomsName;
            m_modName = modName;
            m_lessTime = lessTime;

        }

        public int lessID
       { 
            get 
            {
                return m_lessonID;
            } 
            
            set 
            { 
                m_lessonID = value;
            } 
        }
        
        public string lectName 
        {
            get 
            {
                return m_lectName;
            } 
            set 
            {
                m_lectName = value;
            } 
        }

        public string ygName
        {
            get
            {
                return m_ygName;
            }

            set
            {
                m_ygName = value;
            }
        }

        public string roomsName
        {
            get
            {
                return m_roomsName;
            }

            set
            {
                m_roomsName = value;
            }
        }

        public string modName
        {
            get
            {
                return m_modName;
            }

            set
            {
                m_modName = value;
            }
        }

        public int lessTime
        {
            get
            {
                return m_lessTime;
            }

            set
            {
                m_lessTime = value;
            }
        }
    }
}
