using OnlineStore.Core.Features.Authorization.Quaries.Responses;
using OnlineStore.Data.Entities.Identity;

namespace OnlineStore.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRolesListMapping()
        {
            CreateMap<Role, GetRolesListResponse>();
        }
    }
}
