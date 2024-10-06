using OnlineStore.Core.Feautres.CustomerCQRS.Commands.ModelsCommands;
using OnlineStore.Data.Entities;

namespace OnlineStore.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile
    {
        public void AddCustomerCommandMapping()
        {
            CreateMap<Customer, AddCustomerCommand>();
        }
    }
}
