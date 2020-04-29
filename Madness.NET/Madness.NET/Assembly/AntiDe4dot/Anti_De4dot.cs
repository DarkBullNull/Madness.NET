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
            InterfaceImpl interfaceM = new InterfaceImplUser(moduleDef.GlobalType);
            for (int i = 100; i < 150; i++)
            {
                TypeDef typeDef1 = new TypeDefUser("", $"Form{i.ToString()}", moduleDef.CorLibTypes.GetTypeRef("System", "Attribute"));
                InterfaceImpl interface1 = new InterfaceImplUser(typeDef1);
                moduleDef.Types.Add(typeDef1);
                typeDef1.Interfaces.Add(interface1);
                typeDef1.Interfaces.Add(interfaceM);
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