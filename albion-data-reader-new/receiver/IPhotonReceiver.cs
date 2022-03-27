namespace albion_data_reader_new
{
    public interface IPhotonReceiver
    {

        void ReceivePacket(byte[] payload);

    }
}
