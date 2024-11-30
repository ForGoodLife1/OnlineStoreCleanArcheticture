using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _ReviewRepository;

        public ReviewService(IReviewRepository ReviewRepository)
        {
            _ReviewRepository=ReviewRepository;
        }

        public async Task<Review> GetReviewByIdAsync(int id)
        {
            var customer = await _ReviewRepository.GetTableNoTracking().Where(x => x.ReviewId.Equals(id))
                                                   .Include(x => x.ReviewItems)
                                                   .Include(x => x.Payments)
                                                   .Include(x => x.Shippings).FirstOrDefaultAsync();
            return customer;
        }
    }
}
