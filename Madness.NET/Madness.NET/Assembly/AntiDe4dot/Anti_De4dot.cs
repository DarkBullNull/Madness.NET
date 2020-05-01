using dnlib.DotNet;
using System;
using dnlib.DotNet.Writer;


namespace MadnessNET.Assembly.AntiDe4dot
{
    public class Anti_De4dot
    {

        public static void Yeboy(Context context, ref ModuleDef moduleDef)
        {
            Random rnd = new Random();
            InterfaceImpl interfaceMain = new InterfaceImplUser(moduleDef.GlobalType);
            for (int i = 100; i < 133; i++)
            {
                TypeDef typeDef = new TypeDefUser("M.VM", $"VM_INSTRUCTIONS_BYTE{i.ToString()}", moduleDef.CorLibTypes.GetTypeRef("System", "Attribute"));
                InterfaceImpl interfaceSub = new InterfaceImplUser(typeDef);
                moduleDef.Types.Add(typeDef);
                typeDef.Interfaces.Add(interfaceSub);
                typeDef.Interfaces.Add(interfaceMain);
            }
        }

        public ModuleWriterOptions AntiDe4dotInit(ref ModuleDef moduleDef)
        {
            Context ctx = new Context(ref moduleDef);
            Yeboy(ctx, ref moduleDef);
            var Options = new ModuleWriterOptions(ctx.ManifestModule);
            Options.Logger = DummyLogger.NoThrowInstance;
            return Options;
        }
    }
}