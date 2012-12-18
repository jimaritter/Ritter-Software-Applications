using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Users
{
    public class User : Business<User>, IUser
    {
        private readonly IUser _user;

        public virtual int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual bool Active { get; set; }
        public virtual int RoleId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        protected ISession _session = null;

        public User()
        {
            
        }

        public User(IUser user)
        {
            _user = user;
        }

        public User Get()
        {
            return new User();
        }

        public IList<User> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var userlist = _session.CreateCriteria(typeof(User)).List<User>();
                return userlist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var user = repository.GetById(typeof(User), id);
                    repository.CommitTransaction();
                    return user as User;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }             
        }

        public void Add(User user)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(user);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(User user)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(user);
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
