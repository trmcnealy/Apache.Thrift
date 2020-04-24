using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDatabaseException : TException, TBase
    {
        private string _error_msg;

        public string Error_msg
        {
            get
            {
                return _error_msg;
            }
            set
            {
                isset.error_msg = true;
                _error_msg   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool error_msg;
        }

        public TDatabaseException()
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
                                Error_msg = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TDatabaseException");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Error_msg != null && isset.error_msg)
                {
                    field.Name = "error_msg";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Error_msg, cancellationToken);
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
            var other = that as TDatabaseException;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.error_msg == other.isset.error_msg) && ((!isset.error_msg) || (System.Object.Equals(Error_msg, other.Error_msg))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.error_msg)
                    hashcode = (hashcode * 397) + Error_msg.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDatabaseException(");
            bool __first = true;
            if (Error_msg != null && isset.error_msg)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Error_msg: ");
                sb.Append(Error_msg);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

