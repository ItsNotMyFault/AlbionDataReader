﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new
{
    public interface IPhotonReceiver
    {

        void ReceivePacket(byte[] payload);

    }
}
