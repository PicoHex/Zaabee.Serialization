namespace Aoxe.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    public static void Pack(object? value, Stream? stream, Encoding? encoding = null)
    {
        if (stream is null)
            return;
#if NETSTANDARD2_0
        var bytes = ToBytes(value, encoding ?? Defaults.Utf8Encoding);
        stream.Write(bytes, 0, bytes.Length);
#else
        stream.Write(ToBytes(value, encoding ?? Defaults.Utf8Encoding));
#endif
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}
