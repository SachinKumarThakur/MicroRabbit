using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interface;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDBContext _dbContext;

        public AccountRepository(BankingDBContext dbContext) => _dbContext = dbContext;

        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts;
        }
    }
}
