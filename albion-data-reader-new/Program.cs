using GankCompanionDataReader.eventHandler;
using GankCompanionDataReader.eventHandler.party;
using GankCompanionDataReader.infrastructure;
using GankCompanionDataReader.packethandler;
using Microsoft.Extensions.DependencyInjection;
using PacketDotNet;
using SharpPcap;
using System;
using System.Threading;
namespace albion_data_reader_new
{
    class Program
    {
        private static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<IPartyRepository, InMemoryPartyRepository>().AddTransient<PartyApiService>().BuildServiceProvider();
            PacketReader packetReader = new PacketReader(serviceProvider.GetService<PartyApiService>());
            packetReader.Start();
        }

    }
}
