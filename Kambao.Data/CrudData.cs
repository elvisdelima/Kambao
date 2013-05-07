using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using System.Linq;

namespace Kambao.Data
{
    public class CrudData<T> where T : class
    {
        public ISession NhSession
        {
            get { return SessionProvider.CurrentSession; }
        }

        public T Get(long id)
        {
            return NhSession.CreateCriteria<T>()
                .Add(Restrictions.Eq("Id", id))
                .List<T>()
                .FirstOrDefault();
        }

        public void Delete(T entidade)
        {
            NhSession.Delete(entidade);
        }

        public void Save(T entidade)
        {
            NhSession.Save(entidade);
        }

        public IEnumerable<T> List()
        {
            return NhSession.CreateCriteria<T>().List<T>();
        }
    }
}
