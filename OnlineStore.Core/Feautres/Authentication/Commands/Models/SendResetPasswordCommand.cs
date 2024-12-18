﻿using MediatR;
using OnlineStore.Core.Bases;

namespace OnlineStore.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
