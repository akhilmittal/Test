using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private StudentDBEntities dbContext;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected StudentDBEntities DbContext
        {
            get { return dbContext ?? (dbContext = DbFactory.Init()); }
        }

        public GenericRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }


        public T GetById(object id)
        {
            return DbContext.Set<T>().Find(id);
        }
       
    }  
}
