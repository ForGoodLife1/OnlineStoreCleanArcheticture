using AutoMapper;

namespace OnlineStore.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            GetListCustomerMapping();
            GetCustomerByIDMapping();
            AddCustomerCommandMapping();
            EditCustomerCommandMapping();
        }
    }
}
