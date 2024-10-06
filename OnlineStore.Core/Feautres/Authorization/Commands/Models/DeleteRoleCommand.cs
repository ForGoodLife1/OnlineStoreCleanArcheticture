using MediatR;
using OnlineStore.Core.Bases;

namespace OnlineStore.Core.Features.Authorization.Commands.Models
{
    public class DeleteRoleCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteRoleCommand(int id)
        {
            Id = id;
        }
    }
}
