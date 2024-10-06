using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Data.Responses;

namespace OnlineStore.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResponse>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
