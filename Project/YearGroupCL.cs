﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// this class difines what a year group is and what values create the 
    /// </summary>
    class YearGroupCL
    {
        Int32 m_yearGroupID;
        String m_yearGroupName;
        Int32 m_numStudents;
        /// <summary>
        /// this  gets and  sets  the  values accroding to what the user has inputed into the  text boxs and  passes them to the data base 
        /// </summary>
        /// <param name="YearGroupID"></param>
        /// <param name="YearGruopName"></param>
        /// <param name="NumStudents"></param>
        public YearGroupCL(int YearGroupID, string YearGruopName, int NumStudents)
        {
            m_yearGroupID = YearGroupID;
            m_yearGroupName = YearGruopName;
            m_numStudents = NumStudents;
        }


        public int YearGroupID { get {return m_yearGroupID ;} set {m_yearGroupID = value ;} }

        public string YearGropName { get {return m_yearGroupName ;} set {m_yearGroupName = value ;} }

        public int NumStudents { get {return m_numStudents ;} set {m_numStudents = value ;} }
    }
   }

