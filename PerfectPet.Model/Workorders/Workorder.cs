using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Products;
using PerfectPet.Model.Repository;
using PerfectPet.Model.Services;

namespace PerfectPet.Model.Workorders
{
    public class Workorder : Business<Workorder>, IWorkorder
    {
        private readonly IWorkorder _workorder;
        protected ISession _session = null;
        private int _workorderid;
        private Person _person;
        private Address _address;
        private IList<Pet> _pets;
        private IList<Product> _products;
        private IList<Service> _services; 

        public virtual int WorkorderId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Address Address { get; set; }
        public virtual IList<Pet> Pets { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Service> Services { get; set; }

        public Workorder()
        {
            
        }

        public Workorder(IWorkorder workorder)
        {
            _workorder = workorder;
        }

        public Workorder(int workorderid, Person person, Address address, IList<Pet> pets, IList<Product> products, IList<Service> services, IWorkorder workorder)
        {
            _workorderid = workorderid;
            _person = person;
            _address = address;
            _pets = pets;
            _products = products;
            _services = services;
            _workorder = workorder;
            Pets = new List<Pet>();
            Products = new List<Product>();
            Services = new List<Service>();
        }

        public Workorder Get()
        {
            return new Workorder();
        }

        public IList<Workorder> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var workorderlist = _session.CreateCriteria(typeof(Pet)).List<Workorder>();
                return workorderlist;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public Workorder GetById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var workordelist = _session.CreateCriteria(typeof(Workorder)).List<Workorder>();

                IEnumerable<Workorder> query = from p in workordelist
                                               where p.WorkorderId == id
                                               select p;

                return query.FirstOrDefault();

            }
            catch (Exception)
            {
                return null;
            } 
        }

        public IEnumerable<Workorder> GetByPersonId(int personid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var workordelist = _session.CreateCriteria(typeof(Workorder)).List<Workorder>();

                IEnumerable<Workorder> query = from p in workordelist
                                           where p.Person.Id == personid
                                           select p;

                return query;

            }
            catch (Exception)
            {
                return null;
            } 
        }

        public void Save(Workorder workorder)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Save(workorder);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(Workorder workorder)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Delete(workorder);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
