using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTranaferCommand : TransferCommand
    {
        public CreateTranaferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amound = amount;
        }
    }
}
