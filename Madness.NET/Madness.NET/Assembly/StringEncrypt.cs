using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib;
using dnlib.DotNet;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using dnlib.DotNet.Emit;
using FieldAttributes = dnlib.DotNet.FieldAttributes;
using Label = System.Reflection.Emit.Label;
using MethodAttributes = dnlib.DotNet.MethodAttributes;
using MethodImplAttributes = dnlib.DotNet.MethodImplAttributes;
using OpCodes = dnlib.DotNet.Emit.OpCodes;
using TypeAttributes = dnlib.DotNet.TypeAttributes;
using System.Threading;
using dnlib.DotNet.Writer;
using MethodBody = dnlib.DotNet.Emit.MethodBody;
using System.Linq;
using OpCode = System.Reflection.Emit.OpCode;

namespace MadnessNET.Assembly
{
    public class StringEncrypt
    {
        public StringEncrypt(ref ModuleDef md)
        {
            StringEncrypting(ref md);
        }

        public void StringEncrypting(ref ModuleDef moduleDef)
        {
            //BuildAdderType();

            TypeDef deshifratorType = null;
            DefType(ref moduleDef);
            foreach (var type in moduleDef.Types)
            {
                if (type.Name == "Deshifrator")
                {
                    deshifratorType = type;
                    break;
                }
            }
            foreach (TypeDef type in moduleDef.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (method.Body == null) continue;
                    for (int i = 0; i < method.Body.Instructions.Count(); i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            String oldString = method.Body.Instructions[i].Operand.ToString();
                            String newString = EncryptString(oldString);
                            method.Body.Instructions[i].OpCode = OpCodes.Nop;
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Ldstr, newString));
                            method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Call, deshifratorType.FindMethod("StringDecryptor")));
                            i += 2;
                            method.Body.OptimizeBranches();
                            method.Body.SimplifyBranches();
                        }
                    }
                }
            }
        }

        public static void DefType(ref ModuleDef moduleDef)
        {
            var classUser = new TypeDefUser("MadnessNET.Protector", "Deshifrator", moduleDef.CorLibTypes.Object.TypeDefOrRef);
            classUser.Attributes = TypeAttributes.Public |
                                   TypeAttributes.Abstract |
                                   TypeAttributes.Sealed |
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
                              MethodAttributes.Static;
            
            var decryptMethod = new MethodDefUser(
                "StringDecryptor",
                MethodSig.CreateStatic(
                    moduleDef.CorLibTypes.String,
                    moduleDef.CorLibTypes.String),
                methodImplFlags,
                methodFlags);
            classUser.Methods.Add(decryptMethod);

            MethodDef method = classUser.FindMethod("StringDecryptor");

            method.MethodBody = new CilBody();

            Importer importer = new Importer(moduleDef);
            ITypeDefOrRef byteArrayRef = importer.Import(typeof(System.Byte[]));

            Instruction instruction_Ldloc_1 = Instruction.Create(OpCodes.Ldloc_1);
            Instruction instruction_Ldloc_0 = Instruction.Create(OpCodes.Ldloc_0);

            method.Body.Variables.Locals.Add(new Local(byteArrayRef.ToTypeSig()));
            method.Body.Variables.Locals.Add(new Local(method.Module.CorLibTypes.Int32));

            method.Body.Instructions.Add(new Instruction(OpCodes.Call, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("get_ASCII", new Type[] { }))));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldarg_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Callvirt, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("GetBytes", new Type[] { typeof(string) }))));
            method.Body.Instructions.Add(new Instruction(OpCodes.Stloc_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Stloc_1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Br_S, instruction_Ldloc_1));
            method.Body.Instructions.Add(instruction_Ldloc_0);
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldelema, moduleDef.Import(typeof(System.Byte))));
            method.Body.Instructions.Add(new Instruction(OpCodes.Dup));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldind_U1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Sub));
            method.Body.Instructions.Add(new Instruction(OpCodes.Conv_U1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Stind_I1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_1));
            method.Body.Instructions.Add(new Instruction(OpCodes.Add));
            method.Body.Instructions.Add(new Instruction(OpCodes.Stloc_1));
            method.Body.Instructions.Add(instruction_Ldloc_1);
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldlen));
            method.Body.Instructions.Add(new Instruction(OpCodes.Conv_I4));
            method.Body.Instructions.Add(new Instruction(OpCodes.Blt_S, instruction_Ldloc_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Call, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("get_ASCII", new Type[] { }))));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_0));
            method.Body.Instructions.Add(new Instruction(OpCodes.Callvirt, moduleDef.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
            method.Body.Instructions.Add(new Instruction(OpCodes.Ret));

            method.Body.OptimizeBranches();
            method.Body.SimplifyBranches();

        }

        


        private byte[] StrToBytes(string str)
        {
            byte[] encryptBytes = Encoding.ASCII.GetBytes(str);
            return encryptBytes;
        }

        private string EncryptString(string str)
        {
            byte[] byteString = StrToBytes(str);
            for (var i = 0; i < byteString.Length; i++)
            {
                byteString[i] += 1;

            }
            return Encoding.ASCII.GetString(byteString);
        }

        private string DecryptString(string str)
        {
            byte[] encryptBytes = Encoding.ASCII.GetBytes(str);
            for (var i = 0; i < encryptBytes.Length; i++)
            {
                encryptBytes[i] -= 1;

            }
            return Encoding.ASCII.GetString(encryptBytes);
        }

    }
}
