using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRenderResult : TBase
    {
        private byte[] _image;
        private string _nonce;
        private long   _execution_time_ms;
        private long   _render_time_ms;
        private long   _total_time_ms;
        private string _vega_metadata;

        public byte[] Image
        {
            get
            {
                return _image;
            }
            set
            {
                isset.image = true;
                _image   = value;
            }
        }

        public string Nonce
        {
            get
            {
                return _nonce;
            }
            set
            {
                isset.nonce = true;
                _nonce   = value;
            }
        }

        public long Execution_time_ms
        {
            get
            {
                return _execution_time_ms;
            }
            set
            {
                isset.execution_time_ms = true;
                _execution_time_ms   = value;
            }
        }

        public long Render_time_ms
        {
            get
            {
                return _render_time_ms;
            }
            set
            {
                isset.render_time_ms = true;
                _render_time_ms   = value;
            }
        }

        public long Total_time_ms
        {
            get
            {
                return _total_time_ms;
            }
            set
            {
                isset.total_time_ms = true;
                _total_time_ms   = value;
            }
        }

        public string Vega_metadata
        {
            get
            {
                return _vega_metadata;
            }
            set
            {
                isset.vega_metadata = true;
                _vega_metadata   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool image;
            public bool nonce;
            public bool execution_time_ms;
            public bool render_time_ms;
            public bool total_time_ms;
            public bool vega_metadata;
        }

        public TRenderResult()
        {
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
                TField field;
                await iprot.ReadStructBeginAsync(cancellationToken);
                while (true)
                {
                    field = await iprot.ReadFieldBeginAsync(cancellationToken);
                    if (field.Type == TType.Stop)
                    {
                        break;
                    }

                    switch (field.ID)
                    {
                        case 1:
                            if (field.Type == TType.String)
                            {
                                Image = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Nonce = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Execution_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I64)
                            {
                                Render_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I64)
                            {
                                Total_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.String)
                            {
                                Vega_metadata = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        default: 
                            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            break;
                    }

                    await iprot.ReadFieldEndAsync(cancellationToken);
                }

                await iprot.ReadStructEndAsync(cancellationToken);
            }
            finally
            {
                iprot.DecrementRecursionDepth();
            }
        }

        public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
        {
            oprot.IncrementRecursionDepth();
            try
            {
                var struc = new TStruct("TRenderResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Image != null && isset.image)
                {
                    field.Name = "image";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Image, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Nonce != null && isset.nonce)
                {
                    field.Name = "nonce";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Nonce, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.execution_time_ms)
                {
                    field.Name = "execution_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Execution_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.render_time_ms)
                {
                    field.Name = "render_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Render_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.total_time_ms)
                {
                    field.Name = "total_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Total_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Vega_metadata != null && isset.vega_metadata)
                {
                    field.Name = "vega_metadata";
                    field.Type = TType.String;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Vega_metadata, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                await oprot.WriteFieldStopAsync(cancellationToken);
                await oprot.WriteStructEndAsync(cancellationToken);
            }
            finally
            {
                oprot.DecrementRecursionDepth();
            }
        }

        public override bool Equals(object that)
        {
            var other = that as TRenderResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.image             == other.isset.image)             && ((!isset.image)             || (TCollections.Equals(Image, other.Image))))
                && ((isset.nonce             == other.isset.nonce)             && ((!isset.nonce)             || (System.Object.Equals(Nonce,             other.Nonce))))
                && ((isset.execution_time_ms == other.isset.execution_time_ms) && ((!isset.execution_time_ms) || (System.Object.Equals(Execution_time_ms, other.Execution_time_ms))))
                && ((isset.render_time_ms    == other.isset.render_time_ms)    && ((!isset.render_time_ms)    || (System.Object.Equals(Render_time_ms,    other.Render_time_ms))))
                && ((isset.total_time_ms     == other.isset.total_time_ms)     && ((!isset.total_time_ms)     || (System.Object.Equals(Total_time_ms,     other.Total_time_ms))))
                && ((isset.vega_metadata     == other.isset.vega_metadata)     && ((!isset.vega_metadata)     || (System.Object.Equals(Vega_metadata,     other.Vega_metadata))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.image)
                    hashcode = (hashcode * 397) + Image.GetHashCode();
                if(isset.nonce)
                    hashcode = (hashcode * 397) + Nonce.GetHashCode();
                if(isset.execution_time_ms)
                    hashcode = (hashcode * 397) + Execution_time_ms.GetHashCode();
                if(isset.render_time_ms)
                    hashcode = (hashcode * 397) + Render_time_ms.GetHashCode();
                if(isset.total_time_ms)
                    hashcode = (hashcode * 397) + Total_time_ms.GetHashCode();
                if(isset.vega_metadata)
                    hashcode = (hashcode * 397) + Vega_metadata.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRenderResult(");
            bool __first = true;
            if (Image != null && isset.image)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Image: ");
                sb.Append(Image);
            }
            if (Nonce != null && isset.nonce)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Nonce: ");
                sb.Append(Nonce);
            }
            if (isset.execution_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Execution_time_ms: ");
                sb.Append(Execution_time_ms);
            }
            if (isset.render_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Render_time_ms: ");
                sb.Append(Render_time_ms);
            }
            if (isset.total_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Total_time_ms: ");
                sb.Append(Total_time_ms);
            }
            if (Vega_metadata != null && isset.vega_metadata)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Vega_metadata: ");
                sb.Append(Vega_metadata);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

