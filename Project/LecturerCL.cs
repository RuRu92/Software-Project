using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class LecturerCL
    {
        Int32   m_lectuerID;
        String  m_lectuerName;
        Int32   m_requiedTeachingHrs;
        Int32   m_teachingHrs;
        
        public LecturerCL(int lectID, string lectName, int TeachingHrs,int ReqTeachingHrs)
        {
            m_lectuerID = LectID;
            m_lectuerName = lectName;
            m_requiedTeachingHrs = ReqTeachingHrs;
            m_teachingHrs = TeachingHrs;


            
        }


        public int LectID { get { return m_lectuerID; } set { m_lectuerID = value; ;} }

        public string lectName { get { return m_lectuerName;} set {m_lectuerName = value ;} }

        public int ReqTeachingHrs { get {return m_requiedTeachingHrs ;} set {m_requiedTeachingHrs = value ;} }

        public int TeachingHrs { get { return m_teachingHrs ;} set {m_teachingHrs = value ;} }

      
    }
}
