using HuyShop.Data.Infrastructure;
using HuyShop.Model.Models;

namespace HuyShop.Data.Repositories
{
    public interface IPageRepository:IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}