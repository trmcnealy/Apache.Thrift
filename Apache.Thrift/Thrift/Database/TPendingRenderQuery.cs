using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TPendingRenderQuery : TBase
    {
        private long _id;

        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                isset.id = true;
                _id   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool id;
        }

        public TPendingRenderQuery()
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
                                Id = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TPendingRenderQuery");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.id)
                {
                    field.Name = "id";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Id, cancellationToken);
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
            var other = that as TPendingRenderQuery;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.id == other.isset.id) && ((!isset.id) || (System.Object.Equals(Id, other.Id))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.id)
                    hashcode = (hashcode * 397) + Id.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TPendingRenderQuery(");
            bool __first = true;
            if (isset.id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Id: ");
                sb.Append(Id);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

