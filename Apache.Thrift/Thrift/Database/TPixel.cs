using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TPixel : TBase
    {
        private long _x;
        private long _y;

        public long X
        {
            get
            {
                return _x;
            }
            set
            {
                isset.x = true;
                _x   = value;
            }
        }

        public long Y
        {
            get
            {
                return _y;
            }
            set
            {
                isset.y = true;
                _y   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool x;
            public bool y;
        }

        public TPixel()
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
                            if (field.Type == TType.I64)
                            {
                                X = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Y = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TPixel");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.x)
                {
                    field.Name = "x";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(X, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.y)
                {
                    field.Name = "y";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Y, cancellationToken);
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
            var other = that as TPixel;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.x == other.isset.x) && ((!isset.x) || (System.Object.Equals(X, other.X))))
                && ((isset.y == other.isset.y) && ((!isset.y) || (System.Object.Equals(Y, other.Y))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.x)
                    hashcode = (hashcode * 397) + X.GetHashCode();
                if(isset.y)
                    hashcode = (hashcode * 397) + Y.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TPixel(");
            bool __first = true;
            if (isset.x)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("X: ");
                sb.Append(X);
            }
            if (isset.y)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Y: ");
                sb.Append(Y);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

