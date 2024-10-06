using AutoMapper;

namespace OnlineStore.Core.Mapping.OrderMapping
{
    public partial class OrderProfile : Profile
    {
        public OrderProfile()
        {
            GetOrderByIdMapping();
        }
    }
}
