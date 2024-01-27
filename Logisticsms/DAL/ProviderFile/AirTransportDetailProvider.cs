using Logisticsms.DAL.BaseFiles;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq;


namespace Logisticsms.DAL.ProviderFile
{
    public class AirTransportDetailProvider : ProviderBase, IProvider<AirTransportDetail>
    {
        public int Delete(AirTransportDetail entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        public List<AirTransportDetail> GetAll()
        {
            return db.AirTransportDetail.ToList();
        }

        public int Insert(AirTransportDetail entity)
        {
            db.Entry(entity).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int Update(AirTransportDetail entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
