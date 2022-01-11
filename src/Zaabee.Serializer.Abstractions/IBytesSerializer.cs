namespace Zaabee.Serializer.Abstractions;

public interface IBytesSerializer : IStreamSerializer
{
    /// <summary>
    /// Serialize to bytes.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    byte[] ToBytes<TValue>(TValue? value);

    /// <summary>
    /// If the bytes is null or empty will return the default value of T.
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    TValue? FromBytes<TValue>(byte[]? bytes);

    /// <summary>
    /// Serialize to bytes.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    byte[] ToBytes(Type type, object? value);

    /// <summary>
    /// If the bytes is null or empty will return the default value of the type.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    object? FromBytes(Type type, byte[]? bytes);
}