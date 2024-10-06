using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities.Identity;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrustructure.Abstracts;

namespace OnlineStore.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        #region Fields
        private DbSet<UserRefreshToken> userRefreshToken;
        #endregion

        #region Constructors
        public RefreshTokenRepository(OnlineStoreContext dbContext) : base(dbContext)
        {
            userRefreshToken=dbContext.Set<UserRefreshToken>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
