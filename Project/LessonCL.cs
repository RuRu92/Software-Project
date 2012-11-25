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
        String m_lessonName;
        Int32 m_lessonLenght;
        DateTime m_lessonDateTime;

        public LessonCL(int lessID, string lessName, int lessLenght, DateTime lessDT)
        {
            m_lessonID = lessID;
            m_lessonName = lessName;
            m_lessonLenght = lessLenght;
            m_lessonDateTime = lessDT;
        }

        public int lessID { get { return m_lessonID; } set { m_lessonID = value;} }
        
        
        public string lessName { get {return m_lessonName;} set {m_lessonName = value;} }
       
        public int lessLenght { get {return m_lessonLenght ;} set {m_lessonLenght = value;} }

        public DateTime lessDT { get {return m_lessonDateTime;} set {m_lessonDateTime = value;} }
    }
}
