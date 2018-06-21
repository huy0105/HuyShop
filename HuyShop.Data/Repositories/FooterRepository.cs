using HuyShop.Data.Infrastructure;
using HuyShop.Model.Models;

namespace HuyShop.Data.Repositories
{
    public interface IFooterRepository:IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}