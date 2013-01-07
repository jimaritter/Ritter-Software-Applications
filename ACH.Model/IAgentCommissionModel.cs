namespace ACH.Model
{
    public interface IAgentCommissionModel
    {
        #region Instance Methods

        AchFile GenerateAchFile(string submitDateId);
        void Save(AchFile achFile);
        void WriteNachaToDisk();

        #endregion
    }
}