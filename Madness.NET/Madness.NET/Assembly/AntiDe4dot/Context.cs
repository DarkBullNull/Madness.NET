using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessNET.Assembly.AntiDe4dot
{
    public class Context
    {
        public ModuleDef ManifestModule;
        public TypeDef GlobalType;
        public Importer Imp;
        public MethodDef cctor;
        public Context(ref ModuleDef moduleDef)
        {
            ManifestModule = moduleDef.Assembly.ManifestModule;
            GlobalType = ManifestModule.GlobalType;
            Imp = new Importer(ManifestModule);
            cctor = GlobalType.FindOrCreateStaticConstructor();
        }
    }
}
