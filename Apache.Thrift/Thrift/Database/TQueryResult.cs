using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TQueryResult : TBase
    {
        private TRowSet _row_set;
        private long    _execution_time_ms;
        private long    _total_time_ms;
        private string  _nonce;
        private string  _debug;

        public TRowSet Row_set
        {
            get
            {
                return _row_set;
            }
            set
            {
                isset.row_set = true;
                _row_set   = value;
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

        public string Debug
        {
            get
            {
                return _debug;
            }
            set
            {
                isset.debug = true;
                _debug   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool row_set;
            public bool execution_time_ms;
            public bool total_time_ms;
            public bool nonce;
            public bool debug;
        }

        public TQueryResult()
        {
            isset              = new Isset();
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
                            if (field.Type == TType.Struct)
                            {
                                Row_set = new TRowSet();
                                await Row_set.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Execution_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Total_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.String)
                            {
                                Nonce = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.String)
                            {
                                Debug = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TQueryResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Row_set != null && isset.row_set)
                {
                    field.Name = "row_set";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Row_set.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.execution_time_ms)
                {
                    field.Name = "execution_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Execution_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.total_time_ms)
                {
                    field.Name = "total_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Total_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Nonce != null && isset.nonce)
                {
                    field.Name = "nonce";
                    field.Type = TType.String;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Nonce, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Debug != null && isset.debug)
                {
                    field.Name = "debug";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Debug, cancellationToken);
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
            var other = that as TQueryResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.row_set           == other.isset.row_set)           && ((!isset.row_set)           || (System.Object.Equals(Row_set,           other.Row_set))))
                && ((isset.execution_time_ms == other.isset.execution_time_ms) && ((!isset.execution_time_ms) || (System.Object.Equals(Execution_time_ms, other.Execution_time_ms))))
                && ((isset.total_time_ms     == other.isset.total_time_ms)     && ((!isset.total_time_ms)     || (System.Object.Equals(Total_time_ms,     other.Total_time_ms))))
                && ((isset.nonce             == other.isset.nonce)             && ((!isset.nonce)             || (System.Object.Equals(Nonce,             other.Nonce))))
                && ((isset.debug             == other.isset.debug)             && ((!isset.debug)             || (System.Object.Equals(Debug,             other.Debug))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.row_set)
                    hashcode = (hashcode * 397) + Row_set.GetHashCode();
                if(isset.execution_time_ms)
                    hashcode = (hashcode * 397) + Execution_time_ms.GetHashCode();
                if(isset.total_time_ms)
                    hashcode = (hashcode * 397) + Total_time_ms.GetHashCode();
                if(isset.nonce)
                    hashcode = (hashcode * 397) + Nonce.GetHashCode();
                if(isset.debug)
                    hashcode = (hashcode * 397) + Debug.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TQueryResult(");
            bool __first = true;
            if (Row_set != null && isset.row_set)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_set: ");
                sb.Append(Row_set == null ? "<null>" : Row_set.ToString());
            }
            if (isset.execution_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Execution_time_ms: ");
                sb.Append(Execution_time_ms);
            }
            if (isset.total_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Total_time_ms: ");
                sb.Append(Total_time_ms);
            }
            if (Nonce != null && isset.nonce)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Nonce: ");
                sb.Append(Nonce);
            }
            if (Debug != null && isset.debug)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Debug: ");
                sb.Append(Debug);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

