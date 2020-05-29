using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace MadnessNET.Assembly
{
    public class AntiILSpy
    {
        public AntiILSpy(ref ModuleDef md)
        {
            Obfuscating(ref md);
        }

        public void Obfuscating(ref ModuleDef moduleDef)
        {
            foreach (TypeDef type in moduleDef.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (method.Body == null) continue;

                    Importer importer = new Importer(moduleDef);
                    ITypeDefOrRef int32Import = importer.Import(typeof(System.Int32));
                    ITypeDefOrRef booleanImport = importer.Import(typeof(System.Boolean));
                    method.Body.Variables.Locals.Add(new Local(int32Import.ToTypeSig()));
                    method.Body.Variables.Locals.Add(new Local(booleanImport.ToTypeSig()));


                    int i = 0;
                    var lengthILBody = method.Body.Instructions.Count;
                    var instructionLdcI41 = new Instruction(OpCodes.Ldc_I4_1);
                    var instructionLdloc0 = new Instruction(OpCodes.Ldloc_0);
                    method.Body.KeepOldMaxStack = true;
                    method.Body.Instructions.Insert(i, new Instruction(OpCodes.Ldc_I4_0));
                    method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Stloc_0));
                    method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Br_S, instructionLdcI41));
                    method.Body.Instructions.Insert(i + 3, instructionLdloc0);
                    method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Ldc_I4_0));
                    method.Body.Instructions.Insert(i + 5, new Instruction(OpCodes.Ceq));
                    method.Body.Instructions.Insert(i + 6, new Instruction(OpCodes.Ldc_I4_1));
                    method.Body.Instructions.Insert(i + 7, new Instruction(OpCodes.Ceq));
                    method.Body.Instructions.Insert(i + 8, new Instruction(OpCodes.Stloc_1));
                    method.Body.Instructions.Insert(i + 9, new Instruction(OpCodes.Ldloc_1));
                    method.Body.Instructions.Insert(i + 10, new Instruction(OpCodes.Brtrue_S, method.Body.Instructions[10]));
                    method.Body.Instructions.Insert(i + 11, new Instruction(OpCodes.Ret));
                    method.Body.Instructions.Insert(i + 12, new Instruction(OpCodes.Calli, null));
                    method.Body.Instructions.Insert(i + 13, new Instruction(OpCodes.Sizeof, null));
                    method.Body.Instructions.Insert(i + lengthILBody + 14, instructionLdcI41); // start debug method
                    method.Body.Instructions.Insert(i + lengthILBody + 15, new Instruction(OpCodes.Stloc_1));
                    method.Body.Instructions.Insert(i + lengthILBody + 16, new Instruction(OpCodes.Br_S, instructionLdloc0));
                    method.Body.Instructions.Insert(i + lengthILBody + 17, new Instruction(OpCodes.Ret));

                    
                    var exceptionHandler = new ExceptionHandler();
                    exceptionHandler.TryStart = method.Body.Instructions[12];
                    exceptionHandler.TryEnd = method.Body.Instructions[14];
                    exceptionHandler.FilterStart = null;
                    exceptionHandler.HandlerStart = method.Body.Instructions[10];
                    exceptionHandler.HandlerEnd = method.Body.Instructions[11];
                    exceptionHandler.HandlerType = ExceptionHandlerType.Finally;
                    exceptionHandler.CatchType = null;
                    method.Body.ExceptionHandlers.Add(exceptionHandler);
                    

                    //method.Body.OptimizeBranches();
                    //method.Body.SimplifyBranches();

                }
            }


        }



    }
}
