using OnlineStore.Core.Feautres.OrderCQRS.Queries.Responses;
using OnlineStore.Data.Entities;
namespace OnlineStore.Core.Mapping.OrderMapping
{
    public partial class OrderProfile
    {
        public void GetOrderByIdMapping()
        {
            CreateMap<Order, GetOrderByIdResponse>();
            CreateMap<OrderItem, OrderItemResponse>();
        }
    }
}
