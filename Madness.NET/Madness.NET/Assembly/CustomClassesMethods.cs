using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessNET.Assembly
{
    public class CustomClassesMethods
    {
        public CustomClassesMethods(ref ModuleDef moduleDef)
        {
            UserRenamer(ref moduleDef);
        }

        void UserRenamer(ref ModuleDef moduleDef)
        {
            var class_user = new TypeDefUser("MADNESS.NET", "MADNESS_TYPE", moduleDef.CorLibTypes.Object.TypeDefOrRef);
            class_user.Attributes = TypeAttributes.Public | TypeAttributes.AutoLayout |
                                             TypeAttributes.Class | TypeAttributes.AnsiClass;
            moduleDef.Types.Add(class_user);
            var field1 = new FieldDefUser("MyField",
                            new FieldSig(moduleDef.CorLibTypes.Int32),
                            FieldAttributes.Public | FieldAttributes.Static);
            class_user.Fields.Add(field1);
            var methImplFlags = MethodImplAttributes.IL | MethodImplAttributes.Managed;
            var methFlags = MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot;
            var meth1 = new MethodDefUser("MyMethod",
                        MethodSig.CreateStatic(moduleDef.CorLibTypes.Int32, moduleDef.CorLibTypes.Int32, moduleDef.CorLibTypes.Int32),
                        methImplFlags, methFlags);
            class_user.Methods.Add(meth1);
        }
    }
}
