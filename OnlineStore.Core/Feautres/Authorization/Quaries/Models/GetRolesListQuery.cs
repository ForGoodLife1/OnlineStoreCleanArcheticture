using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Features.Authorization.Quaries.Responses;

namespace OnlineStore.Core.Features.Authorization.Quaries.Models
{
    public class GetRolesListQuery : IRequest<Response<List<GetRolesListResponse>>>
    {
    }
}
