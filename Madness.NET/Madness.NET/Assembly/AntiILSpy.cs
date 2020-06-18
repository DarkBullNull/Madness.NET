using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ExceptionHandler = dnlib.DotNet.Emit.ExceptionHandler;
using OpCodes = dnlib.DotNet.Emit.OpCodes;

namespace MadnessNET.Assembly
{
    public class AntiILSpy
    {
        public AntiILSpy(ref ModuleDef md, MethodDef[] methodDef)
        {
            Obfuscating(ref md, methodDef);
        }

        public void Obfuscating(ref ModuleDef moduleDef, MethodDef[] methodDef)
        {
            foreach (var methodDef_Enumerator in methodDef)
            {
                if (methodDef_Enumerator.Body == null) continue;
                Importer importer = new Importer(moduleDef);
                ITypeDefOrRef int32Import = importer.Import(typeof(System.Int32));
                ITypeDefOrRef booleanImport = importer.Import(typeof(System.Boolean));

                Local int32Importing = new Local(int32Import.ToTypeSig());
                Local booleanImporting = new Local(booleanImport.ToTypeSig());

                methodDef_Enumerator.Body.Variables.Locals.Add(int32Importing);
                methodDef_Enumerator.Body.Variables.Locals.Add(booleanImporting);

                int i = 0;

                var lengthILBody = methodDef_Enumerator.Body.Instructions.Count;
                var instructionLdcI41 = new Instruction(OpCodes.Ldc_I4_1);
                var instructionLdloc0 = new Instruction(OpCodes.Ldloc_S, int32Importing);

                    methodDef_Enumerator.Body.KeepOldMaxStack = true;
                methodDef_Enumerator.Body.Instructions.Insert(i, new Instruction(OpCodes.Ldc_I4_0));
                methodDef_Enumerator.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Stloc_S, int32Importing));
                methodDef_Enumerator.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Br_S, instructionLdcI41));
                methodDef_Enumerator.Body.Instructions.Insert(i + 3, instructionLdloc0);
                methodDef_Enumerator.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Ldc_I4_0));
                methodDef_Enumerator.Body.Instructions.Insert(i + 5, new Instruction(OpCodes.Ceq));
                methodDef_Enumerator.Body.Instructions.Insert(i + 6, new Instruction(OpCodes.Ldc_I4_1));
                methodDef_Enumerator.Body.Instructions.Insert(i + 7, new Instruction(OpCodes.Ceq));
                methodDef_Enumerator.Body.Instructions.Insert(i + 8, new Instruction(OpCodes.Stloc_S, booleanImporting));
                methodDef_Enumerator.Body.Instructions.Insert(i + 9, new Instruction(OpCodes.Ldloc_S, booleanImporting));
                methodDef_Enumerator.Body.Instructions.Insert(i + 10, new Instruction(OpCodes.Brtrue_S, methodDef_Enumerator.Body.Instructions[10]));
                methodDef_Enumerator.Body.Instructions.Insert(i + 11, new Instruction(OpCodes.Ret));
                methodDef_Enumerator.Body.Instructions.Insert(i + 12, new Instruction(OpCodes.Calli, null));
                methodDef_Enumerator.Body.Instructions.Insert(i + 13, new Instruction(OpCodes.Sizeof, null));
                methodDef_Enumerator.Body.Instructions.Insert(i + lengthILBody + 14, instructionLdcI41);
                methodDef_Enumerator.Body.Instructions.Insert(i + lengthILBody + 15, new Instruction(OpCodes.Stloc_S, booleanImporting));
                methodDef_Enumerator.Body.Instructions.Insert(i + lengthILBody + 16, new Instruction(OpCodes.Br_S, instructionLdloc0));
                methodDef_Enumerator.Body.Instructions.Insert(i + lengthILBody + 17, new Instruction(OpCodes.Ret));



                var exceptionHandler = new ExceptionHandler();
                exceptionHandler.TryStart = methodDef_Enumerator.Body.Instructions[12];
                exceptionHandler.TryEnd = methodDef_Enumerator.Body.Instructions[14];
                exceptionHandler.FilterStart = null;
                exceptionHandler.HandlerStart = methodDef_Enumerator.Body.Instructions[10];
                exceptionHandler.HandlerEnd = methodDef_Enumerator.Body.Instructions[11];
                exceptionHandler.HandlerType = ExceptionHandlerType.Finally;
                exceptionHandler.CatchType = null;
                methodDef_Enumerator.Body.ExceptionHandlers.Add(exceptionHandler);


                //method.Body.OptimizeBranches();
                //method.Body.SimplifyBranches();


            }


        }



    }
}
