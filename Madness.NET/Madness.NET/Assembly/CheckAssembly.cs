using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MadnessNET.Assembly;

namespace MadnessNET
{
    public static class CheckAssembly
    {
        public static bool IsValidAssembly(string path)
        {
            try
            {
                AssemblyName myAssemblyName = AssemblyName.GetAssemblyName(path);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }
    }
}
