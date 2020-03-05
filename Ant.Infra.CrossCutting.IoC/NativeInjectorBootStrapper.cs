using Ant.Application.AutoMapper.Services;
using Ant.Application.Interfaces;
using Ant.Domain.Core.Bus;
using Ant.Domain.Core.Notifications;
using Ant.Domain.Interfaces;
using Ant.Infra.CrossCutting.Bus;
using Ant.Infra.Data.Context;
using Ant.Infra.Data.Repository;
using Ant.Infra.Data.UoW;
using Equinox.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ant.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
          //  services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
           // services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddScoped<IUserAppService, UserAppService>();

            // Domain - Events
         //   services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
          //  services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
          //   services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
          // services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            //services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<AntContext>();

            // Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSqlContext>();

            // Infra - Identity
           // services.AddScoped<IUser, AspNetUser>();
        }
    }
}
