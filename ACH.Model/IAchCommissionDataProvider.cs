using System.Collections.Generic;

namespace ACH.Model
{
    public interface IAchCommissionDataProvider
    {
        void Save(AchFile achFile);
        void Delet(AchFile achFile);
        IList<AchGetCommissionData> GetCommissionData(string submitDateId);
    }
}