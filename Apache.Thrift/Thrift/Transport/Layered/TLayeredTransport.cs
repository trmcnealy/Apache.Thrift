using System;
using System.Collections.Generic;
using System.Text;

namespace Apache.Thrift.Transport
{
    public abstract class TLayeredTransport : TTransport
    {
        public readonly TTransport InnerTransport;

        public override TConfiguration Configuration { get { return InnerTransport.Configuration; } }

        public TLayeredTransport(TTransport transport)
        {
            InnerTransport = transport ?? throw new ArgumentNullException(nameof(transport));
        }

        public override void UpdateKnownMessageSize(long size)
        {
            InnerTransport.UpdateKnownMessageSize(size);
        }

        public override void CheckReadBytesAvailable(long numBytes)
        {
            InnerTransport.CheckReadBytesAvailable(numBytes);
        }
    }
}
