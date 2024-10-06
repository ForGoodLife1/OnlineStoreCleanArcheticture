using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Responses;

namespace OnlineStore.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResponse>>
    {
        public int UserId { get; set; }
    }
}
