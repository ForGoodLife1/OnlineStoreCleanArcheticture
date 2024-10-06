using OnlineStore.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using OnlineStore.Data.Entities;

namespace OnlineStore.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void GetCustomerByIDMapping()
        {
            CreateMap<Customer, GetCustomerByIDResponse>();
        }

    }
}
