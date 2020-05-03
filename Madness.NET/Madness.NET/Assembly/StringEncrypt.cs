using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib;
using dnlib.DotNet;
using System.Reflection;
using System.Windows.Forms;
using dnlib.DotNet.Emit;
using FieldAttributes = dnlib.DotNet.FieldAttributes;
using MethodAttributes = dnlib.DotNet.MethodAttributes;
using MethodImplAttributes = dnlib.DotNet.MethodImplAttributes;
using TypeAttributes = dnlib.DotNet.TypeAttributes;

namespace MadnessNET.Assembly
{
    public class StringEncrypt
    {
        public StringEncrypt(ref ModuleDef md)
        {
            StringEncrypting(ref md);
        }

        public static void StringEncrypting(ref ModuleDef moduleDef)
        {
            DecryptString(ref moduleDef);
            foreach (TypeDef type in moduleDef.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (method.Body == null) continue;
                    for (int i = 0; i < method.Body.Instructions.Count(); i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            //Encoding.UTF8.GetString(Convert.FromBase64String(""));
                            String oldString = method.Body.Instructions[i].Operand.ToString(); //Original String.
                            String newString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(oldString)); //Encrypted String by Base64
                            method.Body.Instructions[i].OpCode = OpCodes.Nop; //Change the Opcode for the Original Instruction
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8", new Type[] { })))); //get Method (get_UTF8) from Type (System.Text.Encoding).
                            method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, newString)); //add the Encrypted String
                            method.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, moduleDef.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) })))); //get Method (FromBase64String) from Type (System.Convert), and arguments for method we will get it using "new Type[] { typeof(string) }"
                            method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
                            i += 4; //skip the Instructions that we have just added.
                            method.Body.OptimizeBranches();
                            method.Body.SimplifyBranches();
                        }
                    }
                }
            }
        }

        public static void DecryptString(ref ModuleDef moduleDef)
        {
            var classUser = new TypeDefUser("MADNESS.NET", "MADNESS_TYPE", null);
            classUser.Attributes = TypeAttributes.Public |
                                   TypeAttributes.Class;
            moduleDef.Types.Add(classUser);

            /*
            var field1 = new FieldDefUser("MyField",
                new FieldSig(moduleDef.CorLibTypes.Int32),
                FieldAttributes.Public |
                FieldAttributes.Static);
            classUser.Fields.Add(field1);
            */

            var methodImplFlags = MethodImplAttributes.IL |
                                  MethodImplAttributes.Managed;
            var methodFlags = MethodAttributes.Public |
                              MethodAttributes.Static |
                              MethodAttributes.HideBySig |
                              MethodAttributes.ReuseSlot;
            var decryptMethod = new MethodDefUser("StringDecryptor",
                MethodSig.CreateStatic(moduleDef.CorLibTypes.String,
                    moduleDef.CorLibTypes.String),
                methodImplFlags, methodFlags);
            classUser.Methods.Add(decryptMethod);
            MethodDef method = classUser.FindMethod("StringDecryptor");
            //method.Body.Instructions.Insert(1, new Instruction(OpCodes.Ret));
            method.MethodBody = new CilBody();
            method.Body.Instructions.Add(new Instruction(OpCodes.Ret));
        }




    }
}
