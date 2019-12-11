using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Common
{
   public class DbFactory : IDbFactory
    {
        StudentDBEntities dbContext;
        public StudentDBEntities Init()
        {
            return dbContext ?? (dbContext = new StudentDBEntities());
        }
    }
}
