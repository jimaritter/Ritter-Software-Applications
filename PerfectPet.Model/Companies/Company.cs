using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.People;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Companies
{
    public class Company : Business<Company>, ICompany
    {
        private readonly ICompany _company;
        protected ISession _session = null;
        public virtual int Id { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string Description { get; set; }
        public virtual string TaxNumber { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string Phone  { get; set; }
        public virtual string Cell { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Web { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] Logo { get; set; }
        public virtual IList<Person> Employees { get; set; }
        public virtual double TaxRate { get; set; }


        public Company()
        {
            
        }

        public Company(ICompany company)
        {
            _company = company;
        }

        public Company GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var company = repository.GetById(typeof(Company), id);
                    repository.CommitTransaction();

                    return company as Company;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public Company Get()
        {
            return new Company();
        }

        public IList<Company> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var companylist = _session.CreateCriteria(typeof(Company)).List<Company>();
                return companylist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(Company company)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(company);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Company company)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(company);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }
    }
}
