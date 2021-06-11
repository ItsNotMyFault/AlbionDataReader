using System;
using System.Threading.Tasks;

namespace Albion.Network.Example
{
    public class MoveEventHandler : EventPacketHandler<MoveEvent>
    {
        public MoveEventHandler() : base((int)EventCodes.evMove) { }

        protected override Task OnActionAsync(MoveEvent value)
        {
            Console.WriteLine($"Id: {value.Id} x: {value.Position[0]} y: {value.Position[1]}");

            return Task.CompletedTask;
        }
    }
}
