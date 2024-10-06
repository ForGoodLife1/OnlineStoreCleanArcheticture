using OnlineStore.Core.Features.ApplicationUser.Queries.Responses;
using OnlineStore.Data.Entities.Identity;

namespace OnlineStore.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserByIdMapping()
        {
            CreateMap<User, GetUserByIdResponse>();
        }
    }
}
