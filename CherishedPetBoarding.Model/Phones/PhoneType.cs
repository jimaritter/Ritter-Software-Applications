using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Repository;
using NHibernate;

namespace CherishedPetBoarding.Model.Phones
{
    public class PhoneType : Business<PhoneType>, IPhoneType
    {
        protected ISession _session = null;
        private readonly IPhoneType _phoneType;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public PhoneType()
        {
            
        }

        public PhoneType(IPhoneType phoneType)
        {
            _phoneType = phoneType;
        }

        public PhoneType Get()
        {
            return this;
        }

        public IList<PhoneType> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var phonetypelist = _session.CreateCriteria(typeof(PhoneType)).List<PhoneType>();
                return phonetypelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<PhoneType> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var phonetypelist = _session.CreateCriteria(typeof(PhoneType)).List<PhoneType>();
                IEnumerable<PhoneType> phonelist = from p in phonetypelist
                                                 where p.Id == id
                                                 orderby p.Name
                                                 select p;

                return phonelist as IList<PhoneType>;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PhoneType phoneType)
        {
            throw new NotImplementedException();
        }

        public void Delete(PhoneType phoneType)
        {
            throw new NotImplementedException();
        }
    }
}
