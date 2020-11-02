using MicroRabbit.Domin.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent:Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
