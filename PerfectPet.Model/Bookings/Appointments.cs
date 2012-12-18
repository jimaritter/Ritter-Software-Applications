using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Bookings
{
    public class Appointments : Business<Appointments>, IAppointments, INotifyPropertyChanged

    {
        protected ISession _session;
        private int _id;
        private DateTime _start;
        private DateTime _enddate;
        private string _summary = string.Empty;
        private string _description = string.Empty;
        private string _location = string.Empty;
        private string _recurrencerule;
        private int _mastereventid;
        private int _backgroundid;
        private bool _visible;
        private Resources _resource;
        private Appointments _masterAppointment;

        public Appointments()
        {
            //Resources = new List<Resources>();
        }

        public Appointments(int id, DateTime start, DateTime end, string summary, string description, string location, string recurrencerule, int mastereventid, int backgroundid, Resources resource)
        {
            this._id = id;
            this._start = start;
            this._enddate = end;
            this._summary = summary;
            this._description = description;
            this._location = location;
            this._recurrencerule = recurrencerule;
            this._mastereventid = mastereventid;
            this._backgroundid = backgroundid;
            this._resource = resource;
        }

        public virtual int Id
        {
            get { return this._id; }
            set
            {
                if (this._id != value)
                {
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public virtual DateTime Start
        {
            get
            {
                return this._start;
            }
            set
            {
                if (this._start != value)
                {
                    this._start = value;
                    this.OnPropertyChanged("Start");
                }
            }
        }

        public virtual DateTime EndDate
        {
            get { return this._enddate; }
            set
            {
                if (this._enddate != value)
                {
                    this._enddate = value;
                    this.OnPropertyChanged("EndDate");
                }
            }
        }

        public virtual string Summary
        {
            get { return this._summary; }
            set
            {
                if (this._summary != value)
                {
                    this._summary = value;
                    this.OnPropertyChanged("Summary");
                }
            }
        }

        public virtual string Description
        {
            get { return this._description; }
            set
            {
                if (this._description != value)
                {
                    this._description = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        public virtual string Location
        {
            get { return this._location; }
            set
            {
                if (this._location != value)
                {
                    this._location = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        public virtual string RecurrenceRule
        {
            get { return this._recurrencerule; } 
            set
            {
                if (this._recurrencerule != value)
                {
                    this._recurrencerule = value;
                    this.OnPropertyChanged("RecurrenceRule");
                }
            }
        }

        public virtual int MasterEventId
        {
            get { return this._mastereventid; }
            set
            {
                if(this._mastereventid != value)
                {
                    this._mastereventid = value;
                    this.OnPropertyChanged("MasterEventId");
                }
            }
        }

        public virtual int BackgroundId
        {
            get { return this._mastereventid; }
            set
            {
                if (this._backgroundid != value)
                {
                    this._backgroundid = value;
                    this.OnPropertyChanged("BackgroundId");
                }
            }
        }

        public virtual Resources Resource
        {
            get { return this._resource; }
            set
            {
                if (this._resource != value)
                {
                    this._resource = value;
                }
            }
        }

        public virtual Appointments MasterAppointment
        {
            get
            {
                return this._masterAppointment;
            }
            set
            {
                if (this._masterAppointment != value)
                {
                    this._masterAppointment = value;
                    this.OnPropertyChanged("MasterAppointment");
                }
            }
        }

        public virtual bool Visible
        {
            get
            {
                return this._visible;
            }
            set
            {
                if (this._visible != value)
                {
                    this._visible = value;
                    this.OnPropertyChanged("Visible");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Appointments Get()
        {
            return new Appointments();
        }

        public IList<Appointments> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var appointmentlist = _session.CreateCriteria(typeof(Appointments)).List<Appointments>();
                return appointmentlist;
            }
            catch (Exception)
            {

                throw;
            }    
        }

        public Appointments GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var appointment = repository.GetById(typeof(Appointments), id);
                    repository.CommitTransaction();
                    return appointment as Appointments;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public void Save(Appointments appointment)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(appointment);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }

        public void Delete(Appointments appointment)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(appointment);
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
