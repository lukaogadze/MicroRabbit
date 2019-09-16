using System;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTimeOffset Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }
}