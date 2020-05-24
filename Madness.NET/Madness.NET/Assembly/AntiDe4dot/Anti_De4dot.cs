using dnlib.DotNet;
using System;
using dnlib.DotNet.Writer;


namespace MadnessNET.Assembly.AntiDe4dot
{
    public class Anti_De4dot
    {

        public static void AntiDe4dot(Context context, ref ModuleDef moduleDef)
        {
            InterfaceImpl interfaceMain = new InterfaceImplUser(moduleDef.GlobalType);
            for (int i = 100; i < 133; i++)
            {
                TypeDef typeDef = new TypeDefUser("M.VMF", $"VM_INSTRUCTIONS_BYTE{i.ToString()}", moduleDef.CorLibTypes.GetTypeRef("System", "Attribute"));
                InterfaceImpl interfaceSub = new InterfaceImplUser(typeDef);
                moduleDef.Types.Add(typeDef);
                typeDef.Interfaces.Add(interfaceSub);
                typeDef.Interfaces.Add(interfaceMain);
            }
        }

        public ModuleWriterOptions AntiDe4dotInit(ref ModuleDef moduleDef)
        {
            Context ctx = new Context(ref moduleDef);
            AntiDe4dot(ctx, ref moduleDef);
            var Options = new ModuleWriterOptions(ctx.ManifestModule);
            Options.Logger = DummyLogger.NoThrowInstance;
            return Options;
        }

    }
}