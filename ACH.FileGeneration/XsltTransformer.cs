#region Using Statements

using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;
using ACH.FileGeneration.Converters;
using ACH.Shared;
using StructureMap;

#endregion

namespace ACH.FileGeneration
{
    public class XsltTransformer : IXsltTransformer
    {
        #region Instance Methods

        /// <summary>
        /// Renders the specified serializable obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <param name="xsltPath">The XSLT path.</param>
        public XmlDocument Render<T>(T serializableObj, string xsltPath)
        {
            var serializer = serializableObj is BusinessEntity
                                 ? ObjectFactory.GetNamedInstance<ISerializer>("DataContractSerializer")
                                 : ObjectFactory.GetNamedInstance<ISerializer>("XmlSerializer");

            var rawXml = serializer.Render(serializableObj);
            rawXml = StripInvalidCharacters(rawXml);

            var document = new XmlDocument();
            document.LoadXml(rawXml);

            var xDoc = XDocument.Load(new XmlNodeReader(document));
            var transformedDoc = new XDocument();

            using (var writer = transformedDoc.CreateWriter())
            {
                var transform = new XslCompiledTransform();
                transform.Load(XmlReader.Create(new StreamReader(xsltPath)), new XsltSettings {EnableScript = true}, new XmlUrlResolver());
                transform.Transform(xDoc.CreateReader(), writer);
            }


            var xmlDocument = new XmlDocument();
            xmlDocument.Load(transformedDoc.CreateReader());

            return xmlDocument;
        }

        /// <summary>
        /// Renders as text with ampersand. Replaces ##amp## with & and ##nbsp## with &nbsp;
        /// Inserts Xhtml 1.0 Transitional DocType specification
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <param name="xsltPath">The XSLT path.</param>
        /// <returns></returns>
        public string RenderAsHtmlTranslation<T>(T serializableObj, string xsltPath)
        {
            var doc = Render(serializableObj, xsltPath);

            const string docTypeSpecification =
                @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">";

            return doc.InnerXml.Replace("##amp##", "&").Replace("##nbsp##", "&nbsp;").Replace("##lt##", "<").Replace("##gt##", ">").Insert(0,
                                                                                                                                           docTypeSpecification);
        }

        #endregion

        #region Class Methods

        /// <summary>
        /// Strips the illegal characters.
        /// </summary>
        /// <param name="rawXml">The raw XML.</param>
        /// <returns></returns>
        private static string StripInvalidCharacters(string rawXml)
        {
            rawXml = rawXml.Replace("\r", string.Empty).Replace("\n", string.Empty).Replace("\t", string.Empty);
            return rawXml;
        }

        #endregion
    }
}