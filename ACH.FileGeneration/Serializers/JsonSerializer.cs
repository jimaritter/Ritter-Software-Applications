#region Using Statements

using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

#endregion

namespace ACH.FileGeneration.Serializers
{
    public class JsonSerializer : ISerializer
    {
        #region ISerializer Members

        /// <summary>
        /// Serializes the specified serializable obj using Newtonsoft.Json.JsonSerializer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <returns></returns>
        public string Serialize<T>(T serializableObj)
        {
            var jsonSerializer = Newtonsoft.Json.JsonSerializer.Create(null);

            var sb = new StringBuilder(128);
            var sw = new StringWriter(sb, CultureInfo.InvariantCulture);
            using (var jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = Formatting.None;

                jsonSerializer.Serialize(jsonWriter, serializableObj);
            }

            return sw.ToString();
        }

        /// <summary>
        /// Deserializes the specified serialized obj using Newtonsoft.Json.JsonSerializer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedObj">The serialized obj.</param>
        /// <returns></returns>
        public T Deserialize<T>(string serializedObj)
        {
            var sr = new StringReader(serializedObj);
            var jsonSerializer = Newtonsoft.Json.JsonSerializer.Create(null);

            object obj;

            using (JsonReader jsonReader = new JsonTextReader(sr))
            {
                obj = jsonSerializer.Deserialize(jsonReader, typeof (T));

                if (jsonReader.Read() && jsonReader.TokenType != JsonToken.Comment)
                    throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
            }

            return (T) obj;
        }

        #endregion
    }
}