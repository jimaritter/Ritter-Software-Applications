using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Repository;
using NHibernate;

namespace CherishedPetBoarding.Model.People
{
    public class PersonType : Business<PersonType>, IPersonType
    {
        private readonly IPersonType _personType;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        protected ISession _session = null;

        public PersonType()
        {

        }

        public PersonType(IPersonType personType)
        {
            _personType = personType;
        }

        public PersonType Get()
        {
            return this;
        }

        public IList<PersonType> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var persontypelist = _session.CreateCriteria(typeof(PersonType)).List<PersonType>();
                return persontypelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PersonType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonType> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var persontypelist = _session.CreateCriteria(typeof(PersonType)).List<PersonType>();

                IEnumerable<PersonType> personlist = from p in persontypelist
                                                     where p.Id == id
                                                     orderby p.Name
                                                     select p;

                return personlist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PersonType phoneType)
        {
            throw new NotImplementedException();
        }

        public void Delete(PersonType phoneType)
        {
            throw new NotImplementedException();
        }
    }
}
