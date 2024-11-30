using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ReviewRepository : GenericRepositoryAsync<Review>, IReviewRepository
    {
        private DbSet<Review> _reviews;
        public ReviewRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _reviews=dBContext.Set<Review>();
        }

        public async Task<List<Review>> GetReviewsListAsync()
        {
            return await _reviews.ToListAsync();
        }
    }
}
