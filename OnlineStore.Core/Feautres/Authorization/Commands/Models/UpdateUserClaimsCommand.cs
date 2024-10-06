using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Requests;

namespace OnlineStore.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserClaimsCommand : UpdateUserClaimsRequest, IRequest<Response<string>>
    {
    }
}
