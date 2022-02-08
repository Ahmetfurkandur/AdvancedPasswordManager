using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Models;

namespace PasswordManager.DataAcces
{
    public class PasswordDal
    {
        public List<Passwords> GetAll(Expression<Func<Passwords, bool>> filter=null)
        {
            using (PasswordManagerDbContext context = new PasswordManagerDbContext())
            {
                return filter == null
                    ? context.Set<Passwords>().ToList()
                    : context.Set<Passwords>().Where(filter).ToList();
            }
        }

        public void Update(Passwords password)
        {
            using (PasswordManagerDbContext context = new PasswordManagerDbContext())
            {
                var updatedEntity = context.Entry(password);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Add(Passwords password)
        {
            using (PasswordManagerDbContext context = new PasswordManagerDbContext())
            {
                var addedEntity = context.Entry(password);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Passwords password)
        {
            using (PasswordManagerDbContext context = new PasswordManagerDbContext())
            {
                var deletedEntity = context.Entry(password);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
