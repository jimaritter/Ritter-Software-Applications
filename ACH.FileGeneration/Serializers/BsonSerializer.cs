#region Using Statements

using System.IO;
using Newtonsoft.Json.Bson;

#endregion

namespace ACH.FileGeneration.Serializers
{
    public class BsonSerializer : ISerializer
    {
        #region ISerializer Members

        /// <summary>
        /// Serializes the specified serializable obj using Newtonsoft.Json.Bson.BsonWriter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <returns></returns>
        public string Serialize<T>(T serializableObj)
        {
            using (var ms = new MemoryStream())
            {
                using (var writer = new BsonWriter(ms))
                {
                    var serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(writer, serializableObj);

                    ms.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(ms))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        /// <summary>
        /// Deserializes the specified serialized obj using Newtonsoft.Json.Bson.BsonReader.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedObj">The serialized obj.</param>
        /// <returns></returns>
        public T Deserialize<T>(string serializedObj)
        {
            using (var ms = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(ms))
                {
                    streamWriter.Write(serializedObj);
                    ms.Seek(0, SeekOrigin.Begin);

                    using (var reader = new BsonReader(ms))
                    {
                        var serializer = new Newtonsoft.Json.JsonSerializer();
                        return (T) serializer.Deserialize(reader, typeof (T));
                    }
                }
            }
        }

        #endregion
    }
}