﻿using MicroRabbit.Domin.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand: Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amound { get; protected set; }
    }
}
