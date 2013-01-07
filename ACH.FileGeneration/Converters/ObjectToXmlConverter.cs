#region Using Statements

#endregion

#region Using Statements

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace ACH.FileGeneration.Converters
{
    public  class ObjectToXmlConverter : ISerializer
    {
        #region Class Methods

        /// <summary>
        /// Renders the specified serializable obj.
        /// </summary>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <returns></returns>
        public string Render<T>(T serializableObj)
        {
            if (!typeof (T).IsSerializable)
                throw new SerializationException(string.Format("{0} is not marked Serializable.", typeof(T)));

            var xmls = new XmlSerializer(typeof (T));
            using (var ms = new MemoryStream())
            {
                var settings = new XmlWriterSettings
                                   {
                                       Encoding = Encoding.UTF8,
                                       Indent = true,
                                       IndentChars = "\t",
                                       NewLineChars = Environment.NewLine,
                                       ConformanceLevel = ConformanceLevel.Document
                                   };

                using (var writer = XmlWriter.Create(ms, settings))
                {
                    xmls.Serialize(writer, serializableObj);
                }


                string xml = Encoding.UTF8.GetString(ms.ToArray());

                if (xml.Length > 0 && xml[0] != '<')
                {
                    xml = xml.Substring(1, xml.Length - 1);
                }

                return xml;
            }
        }

        #endregion
    }
}