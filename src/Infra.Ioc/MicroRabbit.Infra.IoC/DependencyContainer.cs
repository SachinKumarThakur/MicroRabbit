using MediatR;
using MicroRabbit.Banking.Application.Interface;
using MicroRabbit.Banking.Application.Service;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Banking.Domain.Interface;
using MicroRabbit.Domin.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTranaferCommand, bool>, TransferCommandHandler>();
            //Application
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            //DBContext
            services.AddTransient<BankingDBContext>();
        }
    }
}
