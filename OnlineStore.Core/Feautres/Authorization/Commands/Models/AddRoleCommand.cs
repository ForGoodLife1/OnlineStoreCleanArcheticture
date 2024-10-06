using MediatR;
using OnlineStore.Core.Bases;

namespace OnlineStore.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
