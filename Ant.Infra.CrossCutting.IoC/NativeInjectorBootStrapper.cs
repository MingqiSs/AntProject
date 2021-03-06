﻿using Ant.Application.Interfaces;
using Ant.Application.Services;
using Ant.Domain.CommandHandlers;
using Ant.Domain.Commands;
using Ant.Domain.Core.Bus;
using Ant.Domain.Core.Events;
using Ant.Domain.Core.Notifications;
using Ant.Domain.EventHandlers;
using Ant.Domain.Events;
using Ant.Domain.Interfaces;
using Ant.Infra.CrossCutting.Bus;
using Ant.Infra.Data.Context;
using Ant.Infra.Data.EventStore;
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
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
           // services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddScoped<IUserAppService, UserAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<UserRegisteredEvent>, UserEventHandler>();
          //   services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
          // services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewUserCommand, bool>, UserCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<AntContext>();

            // Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSqlContext>();

            // Infra - Identity
           // services.AddScoped<IUser, AspNetUser>();
        }
    }
}
