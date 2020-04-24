using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRenderDatum : TBase
    {
        private TDatumType _type;
        private int        _cnt;
        private byte[]     _value;

        /// <summary>
        /// 
        /// <seealso cref="TDatumType"/>
        /// </summary>
        public TDatumType Type
        {
            get
            {
                return _type;
            }
            set
            {
                isset.type = true;
                _type   = value;
            }
        }

        public int Cnt
        {
            get
            {
                return _cnt;
            }
            set
            {
                isset.cnt = true;
                _cnt   = value;
            }
        }

        public byte[] Value
        {
            get
            {
                return _value;
            }
            set
            {
                isset.@value = true;
                _value    = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool type;
            public bool cnt;
            public bool @value;
        }

        public TRenderDatum()
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
                            if (field.Type == TType.I32)
                            {
                                Type = (TDatumType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Cnt = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.String)
                            {
                                Value = await iprot.ReadBinaryAsync(cancellationToken);
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
                var struc = new TStruct("TRenderDatum");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.type)
                {
                    field.Name = "type";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.cnt)
                {
                    field.Name = "cnt";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Cnt, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Value != null && isset.@value)
                {
                    field.Name = "value";
                    field.Type = TType.String;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Value, cancellationToken);
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
            var other = that as TRenderDatum;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.type   == other.isset.type)   && ((!isset.type)   || (System.Object.Equals(Type, other.Type))))
                && ((isset.cnt    == other.isset.cnt)    && ((!isset.cnt)    || (System.Object.Equals(Cnt,  other.Cnt))))
                && ((isset.@value == other.isset.@value) && ((!isset.@value) || (TCollections.Equals(Value, other.Value))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.cnt)
                    hashcode = (hashcode * 397) + Cnt.GetHashCode();
                if(isset.@value)
                    hashcode = (hashcode * 397) + Value.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRenderDatum(");
            bool __first = true;
            if (isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type);
            }
            if (isset.cnt)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Cnt: ");
                sb.Append(Cnt);
            }
            if (Value != null && isset.@value)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Value: ");
                sb.Append(Value);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

