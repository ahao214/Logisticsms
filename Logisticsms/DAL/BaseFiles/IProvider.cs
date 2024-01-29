using System.Collections.Generic;


namespace Logisticsms.DAL.BaseFiles
{
    public interface IProvider<T> where T : class
    {
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> GetAll();
        int Save();

    }
}
