using MicroRabbit.Banking.Application.Interface;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interface;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domin.Core.Bus;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Tranafer(AccountTransfer accountTransfer)
        {
            var createTransfer = new CreateTranaferCommand(
                from:accountTransfer.FromAccount,
                to:accountTransfer.ToAccount,
                amount:accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransfer);
        }
    }
}
