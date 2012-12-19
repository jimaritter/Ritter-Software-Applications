using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Pets
{
    public class PetStatus : Business<PetStatus>, IPetStatus, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected ISession _session;
        private int _id;
        private Pet _pet;
        private Person _person;
        private Status _status;
        private DateTime _addedDate;

        public PetStatus()
        {
            
        }
        public PetStatus(int id, Pet pet, Person person, Status status, DateTime addedDate)
        {
            _id = id;
            _pet = pet;
            _person = person;
            _status = status;
            _addedDate = addedDate;
        }

        public virtual int Id
        {
            get { return this._id; }
            set
            {
                if(this._id != value)
                {
                    this._id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public virtual Pet Pet
        {
            get { return this._pet; }
            set
            {
                if(this._pet != value)
                {
                    this._pet = value;
                    OnPropertyChanged("Pet");
                }
            }
        }

        public virtual Person Person
        {
            get { return this._person; }
            set
            {
                if(this._person != value)
                {
                    this._person = value;
                    OnPropertyChanged("Person");
                }
            }
        }

        public virtual Status Status
        {
            get { return this._status; }
            set
            {
                if(this._status != value)
                {
                    this._status = value;
                    OnPropertyChanged("Status");
                }
            }
        }

        public virtual DateTime AddedDate
        {
            get { return this._addedDate; }
            set
            {
                if(this._addedDate != value)
                {
                    this._addedDate = value;
                    OnPropertyChanged("AddedDate");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public PetStatus Get()
        {
            return new PetStatus();
        }

        public IList<PetStatus> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petstatuslist = _session.CreateCriteria(typeof(PetStatus)).List<PetStatus>();
                return petstatuslist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PetStatus GetById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petstatuslist = _session.CreateCriteria(typeof(PetStatus)).List<PetStatus>();

                var query = from status in petstatuslist
                            where status.Id == id
                            select status;

                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<PetStatus> GetByPetIdandDate(int petid, DateTime dateTime)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petstatuslist = _session.CreateCriteria(typeof(PetStatus)).List<PetStatus>();

                var query = from petstatus in petstatuslist
                            where petstatus.Pet.PetId == petid & petstatus.AddedDate >= dateTime
                            select petstatus;

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<PetStatus> GetByPetIdandBetweenDates(int petid, DateTime startdate, DateTime enddate)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petstatuslist = _session.CreateCriteria(typeof(PetStatus)).List<PetStatus>();

                var query = from petstatus in petstatuslist
                            where petstatus.Pet.PetId == petid & petstatus.AddedDate >= startdate & petstatus.AddedDate <= enddate
                            select petstatus;

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PetStatus petStatus)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Save(petStatus);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public void Delete(PetStatus petStatus)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Delete(petStatus);
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
