using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;

namespace MadnessNET.Assembly
{
    class Renamer
    {
        public Renamer(ref ModuleDef moduleDef, string userAssembly = null, string userModule = null)
        {
            customNames(ref moduleDef, userAssembly, userModule);
        }

        void customNames(ref ModuleDef moduleDef, string userAssembly = null, string userModule = null)
        {
            foreach (TypeDef type in moduleDef.Types)
            {
                type.Module.Name = userModule;
                type.Module.Assembly.Name = userAssembly;
            }

        }
    }
}
