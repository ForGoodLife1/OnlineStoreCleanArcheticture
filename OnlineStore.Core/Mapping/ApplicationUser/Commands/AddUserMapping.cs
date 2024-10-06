using OnlineStore.Core.Features.ApplicationUser.Commands.Models;
using OnlineStore.Data.Entities.Identity;

namespace OnlineStore.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void AddUserMapping()
        {
            CreateMap<AddUserCommand, User>();
        }
    }
}