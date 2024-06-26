namespace Aoxe.MessagePack;

public static partial class MessagePackHelper
{
    public static async ValueTask PackAsync<TValue>(
        TValue? value,
        Stream? stream,
        MessagePackSerializerOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (stream is null)
            return;
        await MessagePackSerializer.SerializeAsync(stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    public static async ValueTask PackAsync(
        Type type,
        object? value,
        Stream? stream,
        MessagePackSerializerOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (stream is null)
            return;
        await MessagePackSerializer.SerializeAsync(type, stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}
