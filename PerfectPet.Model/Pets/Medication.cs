using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Pets
{
    public class Medication : Business<Medication>, IMedication
    {
        private readonly IMedication _medication;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Quantity { get; set; }
        public virtual string Directions { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Pet Pet { get; set; }

        public Medication()
        {
            
        }

        public Medication(IMedication medication)
        {
            _medication = medication;
        }

        public Medication Get()
        {
            return new Medication();
        }

        public IList<Medication> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var medicationlist = _session.CreateCriteria(typeof(Medication)).List<Medication>();
                return medicationlist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Medication GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var medication = repository.GetById(typeof(Medication), id);
                    repository.CommitTransaction();
                    return medication as Medication;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public IEnumerable<Medication> GetByPetId(int petid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var medicationlist = _session.CreateCriteria(typeof(Medication)).List<Medication>();

                IEnumerable<Medication> medications = from p in medicationlist
                                               where p.Pet.PetId == petid
                                           select p;

                return medications;

            }
            catch (Exception)
            {
                return null;
            } 
        }

        public void Save(Medication medication)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(medication);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Medication medication)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(medication);
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
