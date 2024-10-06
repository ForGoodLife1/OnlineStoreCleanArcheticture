using OnlineStore.Data.Entities.Identity;

namespace OnlineStore.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
