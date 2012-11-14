using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Module : Form
    {
        public Module()
        {
            InitializeComponent();
        }

        private void Module_Load(object sender, EventArgs e)
        {

        }

       

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void modName_TextChanged(object sender, EventArgs e)
        {
            ModuleCL modClass = new ModuleCL();
            modClass.ModuleName = modName.Text;
        }

        private void modcode_TextChanged(object sender, EventArgs e)
        {
            ModuleCL modClass = new ModuleCL();
          
            // this small bool that allows an int to be passed into a text box 
            // in this case it is the module code that are  passed  in.
            int num;
            bool flag = int.TryParse(modcode.Text, out num);
            if (flag)
                modClass.ModuleCode = num;
        }

        private void modTeachingHrs_TextChanged(object sender, EventArgs e)
        {
            ModuleCL modClass = new ModuleCL();
            // this bool  allows the text box to pass in interges  
            int num;
            bool flag = int.TryParse(modTeachingHrs.Text, out num);
            if (flag)
                modClass.ModHrs = num;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Module modfrom = new Module();
            this.Close();
           
        }

       

       
    }
}
