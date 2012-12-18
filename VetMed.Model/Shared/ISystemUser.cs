using System.Collections.Generic;

namespace VetMed.Model.Shared
{
    public interface ISystemUser
    {
        SystemUser GetById(int id);
        List<SystemUser> GetAll();
        void Update(SystemUser systemUser);
        void Delete(SystemUser systemUser);
    }
}