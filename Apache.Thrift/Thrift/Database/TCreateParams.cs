using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TCreateParams : TBase
    {
        private bool _is_replicated;

        public bool Is_replicated
        {
            get
            {
                return _is_replicated;
            }
            set
            {
                isset.is_replicated = true;
                _is_replicated   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool is_replicated;
        }

        public TCreateParams()
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
                            if (field.Type == TType.Bool)
                            {
                                Is_replicated = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TCreateParams");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.is_replicated)
                {
                    field.Name = "is_replicated";
                    field.Type = TType.Bool;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_replicated, cancellationToken);
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
            var other = that as TCreateParams;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.is_replicated == other.isset.is_replicated) && ((!isset.is_replicated) || (System.Object.Equals(Is_replicated, other.Is_replicated))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.is_replicated)
                    hashcode = (hashcode * 397) + Is_replicated.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCreateParams(");
            bool __first = true;
            if (isset.is_replicated)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_replicated: ");
                sb.Append(Is_replicated);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

