using MediatR;
using OnlineStore.Core.Bases;

namespace OnlineStore.Core.Features.Authentication.Queries.Models
{
    public class AuthorizeUserQuery : IRequest<Response<string>>
    {
        public string AccessToken { get; set; }
    }
}
