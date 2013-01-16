using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Tasks
{
    public class Task : Business<Task>, ITask
    {
        private readonly ITask _task;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public Task()
        {
            
        }

        public Task(ITask task)
        {
            _task = task;
        }

        public Task Get()
        {
            return new Task();
        }

        public IList<Task> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var tasklist = _session.CreateCriteria(typeof(Task)).List<Task>();
                return tasklist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Task GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var task = repository.GetById(typeof(Task), id);
                    repository.CommitTransaction();
                    return task as Task;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Task task)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(task);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Task task)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(task);
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
