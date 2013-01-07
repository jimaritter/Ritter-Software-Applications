using System.Xml;

namespace ACH.FileGeneration
{
    public interface IXsltTransformer
    {
        /// <summary>
        /// Renders the specified serializable obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <param name="xsltPath">The XSLT path.</param>
        XmlDocument Render<T>(T serializableObj, string xsltPath);

        /// <summary>
        /// Renders as text with ampersand. Replaces ##amp## with & and ##nbsp## with &nbsp;
        /// Inserts Xhtml 1.0 Transitional DocType specification
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <param name="xsltPath">The XSLT path.</param>
        /// <returns></returns>
        string RenderAsHtmlTranslation<T>(T serializableObj, string xsltPath);
    }
}