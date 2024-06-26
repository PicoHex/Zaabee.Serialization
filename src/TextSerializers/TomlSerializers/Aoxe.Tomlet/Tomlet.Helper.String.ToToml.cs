namespace Aoxe.Tomlet;

public static partial class TomletHelper
{
    /// <summary>
    /// Serialize the value to toml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="tomlSerializerOptions"></param>
    /// <returns></returns>
    public static string ToToml<TValue>(
        TValue? value,
        TomlSerializerOptions? tomlSerializerOptions = null
    ) => value is null ? string.Empty : TomletMain.TomlStringFrom(value, tomlSerializerOptions);

    /// <summary>
    /// Serialize the value to toml string.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="tomlSerializerOptions"></param>
    /// <returns></returns>
    public static string ToToml(
        Type type,
        object? value,
        TomlSerializerOptions? tomlSerializerOptions = null
    ) =>
        value is null
            ? string.Empty
            : TomletMain.TomlStringFrom(type, value, tomlSerializerOptions);
}
