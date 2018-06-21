using HuyShop.Data.Infrastructure;
using HuyShop.Model.Models;

namespace HuyShop.Data.Repositories
{
    public interface IMenuGroupRepository:IRepository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}