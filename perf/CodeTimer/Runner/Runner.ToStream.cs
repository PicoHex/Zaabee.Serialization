namespace CodeTimer.Runner;

public partial class Runner
{
    public void ToStream(int iteration)
    {
        Console.WriteLine("ToStream go!");

        Zaabee.CodeTimer.CodeTimer.Initialize();

        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("BinaryHelper ToStream", iteration,
#pragma warning disable CS0618
            () => BinaryHelper.ToStream(_testModel)));
#pragma warning restore CS0618
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("DataContractHelper ToStream", iteration,
            () => DataContractHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("JilHelper ToStream", iteration,
            () => JilHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("MessagePackHelper ToStream", iteration,
            () => MessagePackHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("MsgPackHelper ToStream", iteration,
            () => MsgPackHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("NewtonsoftJsonHelper ToStream", iteration,
            () => NewtonsoftJsonHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("ProtobufHelper ToStream", iteration,
            () => ProtobufHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("SharpYamlHelper ToStream", iteration,
            () => SharpYamlHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("SystemTextJsonHelper ToStream", iteration,
            () => SystemTextJsonHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("Utf8JsonHelper ToStream", iteration,
            () => Utf8JsonHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("XmlHelper ToStream", iteration,
            () => XmlHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("YamlDotNetHelper ToStream", iteration,
            () => YamlDotNetHelper.ToStream(_testModel)));
        Console.WriteLine(Zaabee.CodeTimer.CodeTimer.Time("ZeroFormatterHelper ToStream", iteration,
            () => ZeroFormatterHelper.ToStream(_testModel)));

        Console.WriteLine("\r\nToStream complete!\r\n");
    }
}