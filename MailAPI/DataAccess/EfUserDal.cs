using MailAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MailAPI.DataAccess
{
    public class EfUserDal
    {
        Context context = new Context();
        DbSet<User> _object;

        public EfUserDal()
        {
            _object = context.Set<User>();
        }

        public List<User> GetAll()
        {
            return _object.ToList();
        }

        public List<User> GetAll(Expression<Func<User,bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
