using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Requests;

namespace OnlineStore.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
