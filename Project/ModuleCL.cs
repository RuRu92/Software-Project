using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ModuleCL
    {
        Int32 m_moduleID;
        String m_moduleName;
        Int32 m_moduleHours;

        public ModuleCL()
        {
            m_moduleID = ModuleCode;
            m_moduleName = ModuleName;
            m_moduleHours = ModHrs;
        }


        public int ModHrs { get { return m_moduleHours; } set {m_moduleHours = value;} }

        public string ModuleName { get {return m_moduleName ;} set {m_moduleName = value ;} }

        public int ModuleCode { get {return m_moduleID ;} set { m_moduleID = value ;} }
    }
}
