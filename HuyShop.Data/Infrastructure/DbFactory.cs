namespace HuyShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HuyShopDbContext dbContext;

        public HuyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HuyShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}