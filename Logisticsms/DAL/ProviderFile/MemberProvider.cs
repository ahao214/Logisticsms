using Logisticsms.DAL.BaseFiles;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Logisticsms.DAL.ProviderFile
{
    public class MemberProvider : ProviderBase, IProvider<Member>
    {
        public int Delete(Member entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<Member> GetAll()
        {
            return db.Member.ToList();
        }

        public int Insert(Member entity)
        {
            db.Entry(entity).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(Member entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
