using MediatR;
using OnlineStore.Core.Bases;

namespace OnlineStore.Core.Feautres.CustomerCQRS.Commands.ModelsCommands
{
    public class DeleteCustomerCommand : IRequest<Response<string>>
    {
        public DeleteCustomerCommand(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
