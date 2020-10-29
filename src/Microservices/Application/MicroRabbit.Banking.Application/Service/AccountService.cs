using MicroRabbit.Banking.Application.Interface;
using MicroRabbit.Banking.Domain.Interface;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
