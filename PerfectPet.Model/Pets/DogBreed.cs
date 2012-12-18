using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Pets
{
    public class DogBreed : Business<DogBreed>, IDogBreed
    {
        private readonly IDogBreed _dogBreed;
        protected ISession _session = null;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public DogBreed()
        {
            
        }

        //public DogBreed(IDogBreed dogBreed)
        //{
        //    _dogBreed = dogBreed;
        //}

        public DogBreed Get()
        {
            return new DogBreed();
        }

        public IList<DogBreed> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var breedlist = _session.CreateCriteria(typeof(DogBreed)).List<DogBreed>();
                return breedlist;
            }
            catch (Exception)
            {

                throw;
            }   
        }

        public DogBreed GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var breed = repository.GetById(typeof(DogBreed), id);
                    repository.CommitTransaction();
                    return breed as DogBreed;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public IEnumerable<DogBreed> GetByPetId(int petid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var breeds = _session.CreateCriteria(typeof(DogBreed)).List<DogBreed>();

                IEnumerable<DogBreed> breedlist = from p in breeds
                                           where p.Id == petid
                                           select p;

                return breedlist;

            }
            catch (Exception)
            {
                return null;
            }  
        }

        public void Save(DogBreed breed)
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

        public void Delete(DogBreed breed)
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
