using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TSlotSize : TBase
    {
        private short _padded;
        private short _logical;

        public short Padded
        {
            get
            {
                return _padded;
            }
            set
            {
                isset.padded = true;
                _padded   = value;
            }
        }

        public short Logical
        {
            get
            {
                return _logical;
            }
            set
            {
                isset.logical = true;
                _logical   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool padded;
            public bool logical;
        }

        public TSlotSize()
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
                            if (field.Type == TType.I16)
                            {
                                Padded = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I16)
                            {
                                Logical = await iprot.ReadI16Async(cancellationToken);
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
                var struc = new TStruct("TSlotSize");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.padded)
                {
                    field.Name = "padded";
                    field.Type = TType.I16;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI16Async(Padded, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.logical)
                {
                    field.Name = "logical";
                    field.Type = TType.I16;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI16Async(Logical, cancellationToken);
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
            var other = that as TSlotSize;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.padded  == other.isset.padded)  && ((!isset.padded)  || (System.Object.Equals(Padded,  other.Padded))))
                && ((isset.logical == other.isset.logical) && ((!isset.logical) || (System.Object.Equals(Logical, other.Logical))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.padded)
                    hashcode = (hashcode * 397) + Padded.GetHashCode();
                if(isset.logical)
                    hashcode = (hashcode * 397) + Logical.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TSlotSize(");
            bool __first = true;
            if (isset.padded)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Padded: ");
                sb.Append(Padded);
            }
            if (isset.logical)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Logical: ");
                sb.Append(Logical);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

