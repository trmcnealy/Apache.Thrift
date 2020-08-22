using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Apache.Thrift.Transport
{
    public abstract class TIOStreamTransport : TTransport
    {
        protected Stream _inputStream;

        protected Stream _outputStream;

        protected TIOStreamTransport()
        {
        }

        protected TIOStreamTransport(Stream inputStream,
                                     Stream outputStream)
        {
            _inputStream  = inputStream;
            _outputStream = outputStream;
        }

        public override bool IsOpen { get { return _inputStream != null || _outputStream != null; } }

        public override TConfiguration Configuration { get; }

        public abstract Task OpenAsync();

        public override void Close()
        {
            _inputStream?.Close();

            _outputStream?.Close();

            _inputStream  = null;
            _outputStream = null;
        }

        public override async ValueTask<int> ReadAsync(byte[]            buffer,
                                                       int               offset,
                                                       int               length,
                                                       CancellationToken cancellationToken)
        {
            if(_inputStream == null)
            {
                throw new TTransportException("Cannot read from null inputStream");
            }

            int bytesRead = await _inputStream.ReadAsync(buffer, offset, length, cancellationToken);

            if(bytesRead < 0)
            {
                throw new TTransportException("Socket is closed by peer.");
            }

            return bytesRead;
        }

        public override async Task WriteAsync(byte[]            buffer,
                                              int               offset,
                                              int               length,
                                              CancellationToken cancellationToken)
        {
            if(_outputStream == null)
            {
                throw new TTransportException("Cannot write to null outputStream");
            }

            await _outputStream.WriteAsync(buffer, offset, length, cancellationToken);
        }

        public override async Task FlushAsync(CancellationToken cancellationToken)
        {
            if(_outputStream == null)
            {
                throw new TTransportException("Cannot flush null outputStream");
            }

            await _outputStream.FlushAsync(cancellationToken);
        }

        protected override void Dispose(bool disposing)
        {
            throw new System.NotImplementedException();
        }
    }
}