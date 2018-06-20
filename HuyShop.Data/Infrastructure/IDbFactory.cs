using System;

namespace HuyShop.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        HuyShopDbContext Init();
    }
}