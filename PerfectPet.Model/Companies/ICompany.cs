using System.Collections.Generic;

namespace PerfectPet.Model.Companies
{
    public interface ICompany
    {
        Company GetById(int id);
        Company Get();
        IList<Company> GetAll();
        void Save(Company company);
        void Delete(Company company);
    }
}