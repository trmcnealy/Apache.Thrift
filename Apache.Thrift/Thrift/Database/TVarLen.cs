using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TVarLen : TBase
    {
        private byte[] _payload;
        private bool   _is_null;

        public byte[] Payload
        {
            get
            {
                return _payload;
            }
            set
            {
                isset.payload = true;
                _payload   = value;
            }
        }

        public bool Is_null
        {
            get
            {
                return _is_null;
            }
            set
            {
                isset.is_null = true;
                _is_null   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool payload;
            public bool is_null;
        }

        public TVarLen()
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
                                Payload = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Is_null = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TVarLen");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Payload != null && isset.payload)
                {
                    field.Name = "payload";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Payload, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_null)
                {
                    field.Name = "is_null";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_null, cancellationToken);
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
            var other = that as TVarLen;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.payload == other.isset.payload) && ((!isset.payload) || (TCollections.Equals(Payload, other.Payload))))
                && ((isset.is_null == other.isset.is_null) && ((!isset.is_null) || (System.Object.Equals(Is_null, other.Is_null))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.payload)
                    hashcode = (hashcode * 397) + Payload.GetHashCode();
                if(isset.is_null)
                    hashcode = (hashcode * 397) + Is_null.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TVarLen(");
            bool __first = true;
            if (Payload != null && isset.payload)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Payload: ");
                sb.Append(Payload);
            }
            if (isset.is_null)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_null: ");
                sb.Append(Is_null);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

