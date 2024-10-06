
using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Responses;

namespace OnlineStore.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResponse>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
