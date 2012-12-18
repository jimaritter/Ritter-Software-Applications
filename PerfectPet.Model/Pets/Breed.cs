using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Pets
{
    public class Breed : Business<Breed>, IBreed
    {
        private readonly IBreed _breed;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int SpeciesId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Breed()
        {
            
        }

        public Breed(IBreed breed)
        {
            _breed = breed;
        }

        public Breed Get()
        {
            return new Breed();
        }

        public IList<Breed> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var breedlist = _session.CreateCriteria(typeof(Breed)).List<Breed>();
                return breedlist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Breed GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var breed = repository.GetById(typeof(Breed), id);
                    repository.CommitTransaction();
                    return breed as Breed;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public IEnumerable<Breed> GetByPetId(int petid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var selectedbreed = _session.CreateCriteria(typeof(Breed)).List<Breed>();

                IEnumerable<Breed> breeds = from p in selectedbreed
                                           where p.Id == petid
                                           select p;

                return breeds;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Save(Breed breed)
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
                    throw;
                }
            }
        }

        public void Delete(Breed breed)
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
                    throw;
                }
            }
        }
    }
}