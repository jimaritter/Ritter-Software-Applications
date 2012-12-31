using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;

namespace PerfectPet.Model.Pets
{
    public class Pet : Business<Pet>, IPet
    {
        private readonly IPet _pet;
        protected ISession _session = null;

        public virtual int PetId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Breed { get; set; }
        public virtual string Color { get; set; }
        public virtual string Weight { get; set; }
        public virtual string Size { get; set; }
        public virtual string Temperment { get; set; }
        public virtual string Diet { get; set; }
        public virtual int Age { get; set; }
        public virtual string Species { get; set; }
        public virtual bool HasMedications { get; set; }
        public virtual bool MixedBreed { get; set; }
        public virtual bool Vaccintated { get; set; }
        public virtual bool Biter { get; set; }
        public virtual bool Deceased { get; set; }
        public virtual string Sex { get; set; }
        public virtual byte[] Picture { get; set; }
        public virtual bool IsCheckedIn { get; set; }
        public virtual IList<Medication> Medications { get; set; }
        public virtual string Notes { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Pet()
        {
        }

        //public Pet(IPet pet)
        //{
        //   // _pet = pet;
        //}

        public Pet Get()
        {
            return new Pet();
        }

        public IList<Pet> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petlist = _session.CreateCriteria(typeof(Pet)).List<Pet>();
                return petlist;
            }
            catch (Exception)
            {

                throw;
            }           
        }

        public Pet GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var pet = repository.GetById(typeof (Pet), id);
                    repository.CommitTransaction();
                    return pet as Pet;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public IEnumerable<Pet> GetByPersonId(int personid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petList = _session.CreateCriteria(typeof(Pet)).List<Pet>();

                IEnumerable<Pet> petlist = from p in petList
                                                 where p.Person.Id == personid
                                                 select p;

                return petlist;

            }
            catch (Exception)
            {
                return null;
            }             
        }

        public IEnumerable<Pet> GetByMultiplePets(int[] petids)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var pets = _session.CreateCriteria(typeof(Pet)).List<Pet>();

                IEnumerable<Pet> petlist = from p in pets
                                           join ids in petids
                                           on p.PetId equals ids 
                                           select p;

                _session.Close();
                return petlist.ToList();

            }
            catch (Exception)
            {
                return null;
            }     
        }

        public IList<Pet> GetAllCheckedIn()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var pets = _session.CreateCriteria(typeof(Pet)).List<Pet>();

                IEnumerable<Pet> petlist = from p in pets
                                           where p.IsCheckedIn == true
                                           select p;

                _session.Close();
                return petlist.ToList();

            }
            catch (Exception)
            {
                return null;
            }   
        }

        public void Save(Pet pet)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(pet);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                 }
            }
        }

        public void Delete(Pet pet)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(pet);
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
