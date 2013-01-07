namespace ACH.FileGeneration.Converters
{
    public interface ISerializer
    {
        /// <summary>
        /// Renders the specified serializable obj.
        /// </summary>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <returns></returns>
        string Render<T>(T serializableObj);
    }
}