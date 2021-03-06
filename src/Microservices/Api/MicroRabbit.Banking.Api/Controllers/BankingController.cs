﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interface;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private IAccountService _accountServices;

        public BankingController(IAccountService accountServices)
        {
            _accountServices = accountServices ?? throw new ArgumentNullException(nameof(accountServices));
        }

        // GET: api/<BankingController>
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountServices.GetAccounts());
        }
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountServices.Tranafer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
