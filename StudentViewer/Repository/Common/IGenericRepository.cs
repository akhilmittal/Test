using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T GetById(object id);
               
    } 
}
