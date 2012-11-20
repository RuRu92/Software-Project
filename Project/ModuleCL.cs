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
        Int32 m_reqModuleHours;

        public ModuleCL(int IDModule, string ModuleName, int ModHrs, int RepModHRS )
        {
            m_moduleID = ModuleID;
            m_moduleName = ModuleName;
            m_moduleHours = ModHrs;
            m_reqModuleHours = ReqModHRS;
        }


        public int ModHrs { get { return m_moduleHours; } set {m_moduleHours = value;} }

        public string ModuleName { get {return m_moduleName ;} set {m_moduleName = value ;} }

        public int ModuleID{ get {return m_moduleID ;} set { m_moduleID = value ;} }

        public int ReqModHRS { get { return m_reqModuleHours; } set {m_reqModuleHours = value ;} }
    }
}
