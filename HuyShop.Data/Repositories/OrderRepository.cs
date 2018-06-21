using HuyShop.Data.Infrastructure;
using HuyShop.Model.Models;

namespace HuyShop.Data.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}