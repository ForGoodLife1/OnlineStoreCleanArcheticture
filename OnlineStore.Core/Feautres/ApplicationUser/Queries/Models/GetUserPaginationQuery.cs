using MediatR;
using OnlineStore.Core.Features.ApplicationUser.Queries.Responses;
using OnlineStore.Core.Wrappers;

namespace OnlineStore.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
