using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// this class holds the construotr and geter and setter 
    /// for all the varibles that are used  in other clases 
    /// </summary>
    class LecturerCL
    {
        Int32   m_lectuerID;
        String  m_lectuerName;
        Int32   m_requiedTeachingHrs;
        Int32   m_teachingHrs;
        /// <summary>
        /// this is all the things that make up a lectuer 
        /// and are used to pass in the users input vlaues  
        /// </summary>
        /// <param name="lectID"></param>
        /// <param name="lectName"></param>
        /// <param name="TeachingHrs"></param>
        /// <param name="ReqTeachingHrs"></param>
        public LecturerCL(int lectID, string lectName, int TeachingHrs,int ReqTeachingHrs)
        {
            m_lectuerID = LectID;
            m_lectuerName = lectName;
            m_requiedTeachingHrs = ReqTeachingHrs;
            m_teachingHrs = TeachingHrs;


            
        }

        /// <summary>
        /// this is all the getters and  
        /// setter for this class that gets 
        /// and stets the values to user input and the database
        /// </summary>
        public int LectID { get { return m_lectuerID; } set { m_lectuerID = value; ;} }

        public string lectName { get { return m_lectuerName;} set {m_lectuerName = value ;} }

        public int ReqTeachingHrs { get {return m_requiedTeachingHrs ;} set {m_requiedTeachingHrs = value ;} }

        public int TeachingHrs { get { return m_teachingHrs ;} set {m_teachingHrs = value ;} }

      
    }
}
