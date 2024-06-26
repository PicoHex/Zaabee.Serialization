namespace Aoxe.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    public static ValueTask PackToAsync<TValue>(
        this TValue? value,
        Stream? stream,
        JsonSerializerOptions? options = null,
        CancellationToken cancellationToken = default
    ) => SystemTextJsonHelper.PackAsync(value, stream, options, cancellationToken);

    public static ValueTask PackToAsync(
        this object? value,
        Type type,
        Stream? stream,
        JsonSerializerOptions? options = null,
        CancellationToken cancellationToken = default
    ) => SystemTextJsonHelper.PackAsync(type, value, stream, options, cancellationToken);
}
