namespace ACH.FileGeneration.Serializers
{
    public interface ISerializer
    {
        #region Instance Methods

        /// <summary>
        /// Deserializes the specified serialized obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedObj">The serialized obj.</param>
        /// <returns></returns>
        T Deserialize<T>(string serializedObj);

        /// <summary>
        /// Serializes the specified serializable obj.
        /// </summary>
        /// <param name="serializableObj">The serializable obj.</param>
        /// <returns></returns>
        string Serialize<T>(T serializableObj);

        #endregion
    }
}