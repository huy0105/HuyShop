using HuyShop.Data.Infrastructure;
using HuyShop.Model.Models;

namespace HuyShop.Data.Repositories
{
    public interface IOrderDetailRepository:IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}