using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace CherishedPetBoarding.Model.Repository
{
    public abstract class Business<TEntity>
            where TEntity : class, new()
    {
        protected Business()
        {
        }

        public TEntity Load(object pk)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return (TEntity)session.Load(typeof(TEntity), pk);
            }
        }

        public void Delete(object pk)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(pk);
                    transaction.Commit();
                }
            }
        }

        public void Save(object obj)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(obj);
                    transaction.Commit();
                }
            }
        }

        public List<TEntity> ToList()
        {
            List<TEntity> resultList = new List<TEntity>();

            using (ISession session = SessionManager.OpenSession())
            {
                var objects = session
                    .CreateCriteria(typeof(TEntity))
                    .List();

                foreach (object obj in objects)
                {
                    resultList.Add((TEntity)obj);
                }
            }

            return resultList;
        }

    }
}
