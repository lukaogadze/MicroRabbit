using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommandAsync<T>(T command) where T : Command;
        void Publish<T>(T @event) where T: Event;
        void Subscribe<TEvent, THandler>() where TEvent: Event where THandler: IEventHandler<TEvent>;
    }
}