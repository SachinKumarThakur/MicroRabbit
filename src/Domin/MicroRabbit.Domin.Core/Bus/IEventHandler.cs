using MicroRabbit.Domin.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domin.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent:Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler { }
}
