using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Responses;

namespace OnlineStore.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResponse>>
    {
        public int UserId { get; set; }
    }
}
