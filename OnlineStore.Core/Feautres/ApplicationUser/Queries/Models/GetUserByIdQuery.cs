using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Features.ApplicationUser.Queries.Responses;

namespace OnlineStore.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
