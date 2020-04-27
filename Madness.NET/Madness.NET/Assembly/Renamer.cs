using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessNET.Assembly
{
    public class Renamer
    {
        private string _pathApp { get; set; }
        public Renamer(string path, string user_base_name)
        {
            _pathApp = path;
            UserRenamer(_pathApp);
        }

        void UserRenamer(string path)
        {
            ModuleDef md = ModuleDefMD.Load(_pathApp);
            var class_user = new TypeDefUser("My.Namespace", "MyType", md.CorLibTypes.Object.TypeDefOrRef);

            class_user.Attributes = TypeAttributes.Public | TypeAttributes.AutoLayout |
                                             TypeAttributes.Class | TypeAttributes.AnsiClass;
            md.Types.Add(class_user);

            var field1 = new FieldDefUser("MyField",
                            new FieldSig(md.CorLibTypes.Int32),
                            FieldAttributes.Public | FieldAttributes.Static);
            // Add it to the type we created earlier
            class_user.Fields.Add(field1);

            // Add a static method that adds both inputs and the static field
            // and returns the result
            var methImplFlags = MethodImplAttributes.IL | MethodImplAttributes.Managed;
            var methFlags = MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot;
            var meth1 = new MethodDefUser("MyMethod",
                        MethodSig.CreateStatic(md.CorLibTypes.Int32, md.CorLibTypes.Int32, md.CorLibTypes.Int32),
                        methImplFlags, methFlags);
            class_user.Methods.Add(meth1);

            md.Write(Path.GetDirectoryName(_pathApp) + "\\" + Path.GetFileNameWithoutExtension(_pathApp) + "_MADNESS" + Path.GetExtension(_pathApp));
        }
    }
}
