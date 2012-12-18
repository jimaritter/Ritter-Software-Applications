using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Pets
{
    public class CatBreed : Business<CatBreed>, ICatBreed
    {
        private readonly ICatBreed _catBreed;
        protected ISession _session = null;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public CatBreed()
        {
            
        }

        //public CatBreed(ICatBreed catBreed)
        //{
        //    _catBreed = catBreed;
        //}

        public CatBreed Get()
        {
            return new CatBreed();
        }

        public IList<CatBreed> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var breedlist = _session.CreateCriteria(typeof(CatBreed)).List<CatBreed>();
                return breedlist;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public CatBreed GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var breed = repository.GetById(typeof(CatBreed), id);
                    repository.CommitTransaction();
                    return breed as CatBreed;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public IEnumerable<CatBreed> GetByPetId(int petid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var breeds = _session.CreateCriteria(typeof(CatBreed)).List<CatBreed>();

                IEnumerable<CatBreed> breedlist = from p in breeds
                                                  where p.Id == petid
                                                  select p;

                return breedlist;

            }
            catch (Exception)
            {
                return null;
            }  
        }

        public void Save(CatBreed breed)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(breed);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }

        public void Delete(CatBreed breed)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(breed);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }
    }
}
