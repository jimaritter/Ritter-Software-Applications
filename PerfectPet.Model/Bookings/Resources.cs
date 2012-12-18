using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Bookings
{
    public class Resources : Business<Resources>, IResources, INotifyPropertyChanged
    {
        protected ISession _session;
        private int _id;
        private string _name;
        private byte[] _image;
        private bool _visible;
        private string _size;
        private string _description;
        //private IList<Appointments> _appointments;

        public Resources()
        {
        }

        public Resources(string name, int id, byte[] image, IList<Appointments> appointments,string size, string description)
        {
            this._name = name;
            this._id = id;
            this._image = image;
            this._size = size;
            this._description = description;
        }

        public virtual int Id
        {
            get { return this._id; } 
            set
            {
                if(this._id != value)
                {
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public virtual string Name
        {
            get { return this._name; }
            set
            {
                if(this._name != value)
                {
                    this._name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public virtual byte[] Image
        {
            get { return this._image; }
            set
            {
                if (this._image != value)
                {
                    this._image = value;
                    this.OnPropertyChanged("Image");
                }
            }
        }

        public virtual bool Visible
        {
            get { return this._visible; }
            set
            {
                if (this._visible != value)
                {
                    this._visible = value;
                    this.OnPropertyChanged("Visible");
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

        public virtual string Size
        {
            get { return this._size; } 
            set
            {
                if(this._size != value)
                {
                    this._size = value;
                    this.OnPropertyChanged("Size");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Resources Get()
        {
            return new Resources();
        }

        public IList<Resources> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var resourcelist = _session.CreateCriteria(typeof(Resources)).List<Resources>();
                return resourcelist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Resources GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var resources = repository.GetById(typeof(Resources), id);
                    repository.CommitTransaction();
                    return resources as Resources;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public void Save(Resources resource)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(resource);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }

        public void Delete(Resources resource)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(resource);
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
