using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;

namespace Apache.Thrift.Transport
{
    public class TZlibTransport : TIOStreamTransport
    {

        private readonly TTransport _transport;

        public class Factory : TTransportFactory
        {
            public Factory()
            {
            }

            public override TTransport GetTransport(TTransport transport)
            {
                return new TZlibTransport(transport);
            }
        }

        /// <summary>
        /// Constructs a new TZlibTransport instance. </summary>
        /// <param name="transport"> the underlying transport to Read from and Write to </param>
        public TZlibTransport(TTransport transport) : this(transport, CompressionLevel.Optimal)
        {
        }

        /// <summary>
        /// Constructs a new TZlibTransport instance. </summary>
        /// <param name="transport"> the underlying transport to Read from and Write to </param>
        /// <param name="compressionLevel"> 0 for no compression, 9 for maximum compression </param>
        public TZlibTransport(TTransport transport, CompressionLevel compressionLevel)
        {
            _transport    = transport;
            _inputStream  = new GZipStream(new TTransportInputStream(_transport),  CompressionMode.Compress);
            _outputStream = new GZipStream(new TTransportOutputStream(_transport), compressionLevel, true);
        }


        public override async Task OpenAsync()
        {
            await _transport.OpenAsync();
        }

        public override void Close()
        {
            base.Close();

            if (_transport.IsOpen)
            {
                _transport.Close();
            }
        }

        public override void CheckReadBytesAvailable(long numBytes)
        {
            throw new System.NotImplementedException();
        }


        protected override void Dispose(bool disposing)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class TTransportInputStream : Stream
    {

        private readonly TTransport _transport;

        public TTransportInputStream(TTransport transport)
        {
            _transport = transport;
        }

        public override int Read()
        {
            byte[] buf = new byte[1];
            _transport.ReadAsync(buf, 0, 1);
            return buf[0];
        }

        public override int Read(sbyte[] b, int off, int len)
        {
            try
            {
                return _transport.Read(b, off, len);
            }
            catch (TTransportException e)
            {
                throw new IOException(e);
            }
        }


        public override int Read(byte[] buffer,
                                 int    offset,
                                 int    count)
        {
            byte[] buf = new byte[1];
            _transport.ReadAsync(buf, 0, 1);
            return buf[0];
        }

        public override long Seek(long       offset,
                                  SeekOrigin origin)
        {
            throw new System.NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new System.NotImplementedException();
        }

        public override void Write(byte[] buffer,
                                   int    offset,
                                   int    count)
        {
            throw new System.NotImplementedException();
        }

        public override void Flush()
        {
            throw new System.NotImplementedException();
        }

        public override bool CanRead { get; }

        public override bool CanSeek { get; }

        public override bool CanWrite { get; }

        public override long Length { get; }

        public override long Position { get; set; }
    }

    internal class TTransportOutputStream : Stream
    {

        private TTransport transport = null;

        public TTransportOutputStream(TTransport transport)
        {
            this.transport = transport;
        }
        public override void Write(int b)
        {
                transport.Write(new sbyte[]{(sbyte) b});
        }

        public override void Write(sbyte[] b, int off, int len)
        {
                transport.Write(b, off, len);
        }
        public override void Flush()
        {
            try
            {
                transport.Flush();
            }
            catch (TTransportException e)
            {
                throw new IOException(e);
            }
        }
    }

}