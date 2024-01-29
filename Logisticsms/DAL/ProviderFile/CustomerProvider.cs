using Logisticsms.DAL.BaseFiles;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Logisticsms.DAL.ProviderFile
{
    public class CustomerProvider : ProviderBase, IProvider<Customer>
    {
        public int Delete(Customer entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        public int Insert(Customer entity)
        {
            db.Entry(entity).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(Customer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
