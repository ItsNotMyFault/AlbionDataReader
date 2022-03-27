using Albion.Network;
using Albion.Network.Example;
using albion_data_reader_new;
using albion_data_reader_new.handlers;
using albion_data_reader_new.handlers.market;
using albion_data_reader_new.handlers.requests;
using albion_data_reader_new.handlers.responses;
using GankCompanionDataReader.eventHandler;
using GankCompanionDataReader.eventHandler.party;
using PacketDotNet;
using SharpPcap;
using System;
using System.Threading;

namespace GankCompanionDataReader.packethandler
{
    public class PacketReader
    {
        private static IPhotonReceiver receiver;
        private PartyApiService partyApiService;
        public PacketReader(PartyApiService partyApiService)
        {
            this.partyApiService = partyApiService;
        }

        public void Start()
        {
            ReceiverBuilder builder = ReceiverBuilder.Create();
            //builder.AddEventHandler(new MoveEventHandler());
            //builder.AddEventHandler(new PartyEventHandler(partyApiService));
            builder.AddEventHandler(new AllEventHandler());
            builder.AddRequestHandler(new AllRequestsHandler(0));
            builder.AddResponseHandler(new AllResponseHandler(0));
            //builder.AddEventHandler(new MarketEventHandler(null));
            //add request instead of event?!?!!?
            receiver = builder.Build();

            Console.WriteLine("Start");

            CaptureDeviceList devices = CaptureDeviceList.Instance;//uses winpcap
            foreach (var device in devices)
            {
                new Thread(() =>
                {
                    Console.WriteLine($"Open... {device.Description}");

                    device.OnPacketArrival += new PacketArrivalEventHandler(PacketHandler);
                    device.Open(DeviceMode.Promiscuous, 1000);
                    device.StartCapture();
                })
                .Start();
            }

            Console.Read();

        }

        private static void PacketHandler(object sender, CaptureEventArgs e)
        {
            UdpPacket packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data).Extract<UdpPacket>();
            if (packet != null && (packet.SourcePort == 5056 || packet.DestinationPort == 5056))
            {
                try
                {
                    receiver.ReceivePacket(packet.PayloadData);
                }
                catch (Exception) { }

            }
        }


    }
}
