using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Service.Abstracts;
using OnlineStore.Service.AuthServices.Implementations;
using OnlineStore.Service.AuthServices.Interfaces;
using OnlineStore.Service.Implementations;

namespace OnlineStore.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IFileService, FileService>();
            return services;

        }

    }
}
