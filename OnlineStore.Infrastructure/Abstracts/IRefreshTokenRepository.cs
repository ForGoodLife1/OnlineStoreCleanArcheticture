using OnlineStore.Data.Entities.Identity;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
