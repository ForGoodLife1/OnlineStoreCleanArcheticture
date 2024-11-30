using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IReviewService
    {
        public Task<Review> GetReviewByIdAsync(int id);
        public Task<bool> IsReviewIdExist(int reviewId);
    }
}
