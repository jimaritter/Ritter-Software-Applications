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
    public class Status : Business<Status>, IStatus, INotifyPropertyChanged
    {
        protected ISession _session;
        private int _id;
        private string _title;

        public Status()
        {
            
        }

        public Status(int id, string title)
        {
            this._id = id;
            this._title = title;
        }

        public virtual int Id
        {
            get { return this._id; }
            set
            {
                if (this._id != value)
                {
                    this._id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
 
        public virtual string Title
        {
            get { return this._title; }
            set
            {
                if (this._title != value)
                {
                    this._title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Status Get()
        {
            return new Status();
        }

        public IList<Status> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var statuslist = _session.CreateCriteria(typeof(Status)).List<Status>();
                return statuslist;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public Status GetById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var statuslist = _session.CreateCriteria(typeof(Status)).List<Status>();

                var query = from status in statuslist
                            where status.Id == id
                            select status;

                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(Status status)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Save(status);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public void Delete(Status status)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Delete(status);
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
