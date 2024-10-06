﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.Behaviors;
using System.Reflection;

namespace OnlineStore.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Configuration Of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            // Configuration Of Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


            return services;
        }

    }
}
