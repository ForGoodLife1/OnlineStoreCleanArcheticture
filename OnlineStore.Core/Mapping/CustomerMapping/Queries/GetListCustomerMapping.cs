using OnlineStore.Core.Feautres.PatientCQRS.Queries.ResponseQueries;
using OnlineStore.Data.Entities;


namespace OnlineStore.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void GetListCustomerMapping()
        {
            CreateMap<Customer, GetListCustomerResponse>();
        }
    }
}
