﻿namespace OnlineStore.Core.Features.ApplicationUser.Queries.Responses
{
    public class GetUserPaginationReponse
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
    }
}
