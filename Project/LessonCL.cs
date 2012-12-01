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
        String m_startTime;
        String m_endTime;
        String m_lessDay;

        public LessonCL(int lessID, string lectName, String ygName, 
            String roomsName, String modName, String startTime,String endTime, String day)
        {

            m_lessonID = lessID;
            m_lectName = lectName;
            m_ygName = ygName;
            m_roomsName = roomsName;
            m_modName = modName;
            m_startTime = startTime;
            m_endTime = endTime;
            m_lessDay = day;

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

        public string startTime
        {
            get
            {
                return m_startTime;
            }

            set
            {
                m_startTime = value;
            }
        }

        public string endTime
        {
            get
            {
                return m_endTime;
            }
            set
            {
                m_endTime = value;
            }
                         
        }

        public string Day
        { 
            get 
            {
                return m_lessDay ;
            } 
            set 
            {
                m_lessDay = value ;
            }
        }
    }
}
