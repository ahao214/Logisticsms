namespace Logisticsms.DAL.BaseFiles
{
    public abstract class ProviderBase
    {
        protected OrderDBEntities db = null;

        public ProviderBase()
        {
            this.db = new OrderDBEntities();
        }
    }
}
