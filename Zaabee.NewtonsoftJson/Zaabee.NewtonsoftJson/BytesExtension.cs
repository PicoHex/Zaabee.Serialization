using System;
using Newtonsoft.Json;

namespace Zaabee.NewtonsoftJson
{
    public static class BytesExtension
    {
        public static T FromBytes<T>(this byte[] bytes, JsonSerializerSettings settings = null,
            Formatting? formatting = null) =>
            NewtonsoftJsonHelper.Deserialize<T>(bytes, settings, formatting);

        public static object FromBytes(this byte[] bytes, Type type, JsonSerializerSettings settings = null,
            Formatting? formatting = null) =>
            NewtonsoftJsonHelper.Deserialize(type, bytes, settings, formatting);
    }
}