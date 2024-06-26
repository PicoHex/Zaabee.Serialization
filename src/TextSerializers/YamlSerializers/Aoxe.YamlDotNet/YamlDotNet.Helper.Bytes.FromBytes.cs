namespace Aoxe.YamlDotNet;

public static partial class YamlDotNetHelper
{
    public static TValue? FromBytes<TValue>(byte[]? bytes, Encoding? encoding = null) =>
        bytes is null
            ? default
            : FromYaml<TValue>(bytes.GetString(encoding ?? Defaults.Utf8Encoding));

    public static object? FromBytes(Type type, byte[]? bytes, Encoding? encoding = null) =>
        bytes is null
            ? default
            : FromYaml(type, bytes.GetString(encoding ?? Defaults.Utf8Encoding));
}
