using System;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }
}