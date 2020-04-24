using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TImportStatus : TBase
    {
        private long _elapsed;
        private long _rows_completed;
        private long _rows_estimated;
        private long _rows_rejected;

        public long Elapsed
        {
            get
            {
                return _elapsed;
            }
            set
            {
                isset.elapsed = true;
                _elapsed   = value;
            }
        }

        public long Rows_completed
        {
            get
            {
                return _rows_completed;
            }
            set
            {
                isset.rows_completed = true;
                _rows_completed   = value;
            }
        }

        public long Rows_estimated
        {
            get
            {
                return _rows_estimated;
            }
            set
            {
                isset.rows_estimated = true;
                _rows_estimated   = value;
            }
        }

        public long Rows_rejected
        {
            get
            {
                return _rows_rejected;
            }
            set
            {
                isset.rows_rejected = true;
                _rows_rejected   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool elapsed;
            public bool rows_completed;
            public bool rows_estimated;
            public bool rows_rejected;
        }

        public TImportStatus()
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
                                Elapsed = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Rows_completed = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Rows_estimated = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I64)
                            {
                                Rows_rejected = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TImportStatus");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.elapsed)
                {
                    field.Name = "elapsed";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Elapsed, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.rows_completed)
                {
                    field.Name = "rows_completed";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Rows_completed, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.rows_estimated)
                {
                    field.Name = "rows_estimated";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Rows_estimated, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.rows_rejected)
                {
                    field.Name = "rows_rejected";
                    field.Type = TType.I64;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Rows_rejected, cancellationToken);
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
            var other = that as TImportStatus;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.elapsed        == other.isset.elapsed)        && ((!isset.elapsed)        || (System.Object.Equals(Elapsed,        other.Elapsed))))
                && ((isset.rows_completed == other.isset.rows_completed) && ((!isset.rows_completed) || (System.Object.Equals(Rows_completed, other.Rows_completed))))
                && ((isset.rows_estimated == other.isset.rows_estimated) && ((!isset.rows_estimated) || (System.Object.Equals(Rows_estimated, other.Rows_estimated))))
                && ((isset.rows_rejected  == other.isset.rows_rejected)  && ((!isset.rows_rejected)  || (System.Object.Equals(Rows_rejected,  other.Rows_rejected))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.elapsed)
                    hashcode = (hashcode * 397) + Elapsed.GetHashCode();
                if(isset.rows_completed)
                    hashcode = (hashcode * 397) + Rows_completed.GetHashCode();
                if(isset.rows_estimated)
                    hashcode = (hashcode * 397) + Rows_estimated.GetHashCode();
                if(isset.rows_rejected)
                    hashcode = (hashcode * 397) + Rows_rejected.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TImportStatus(");
            bool __first = true;
            if (isset.elapsed)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Elapsed: ");
                sb.Append(Elapsed);
            }
            if (isset.rows_completed)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Rows_completed: ");
                sb.Append(Rows_completed);
            }
            if (isset.rows_estimated)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Rows_estimated: ");
                sb.Append(Rows_estimated);
            }
            if (isset.rows_rejected)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Rows_rejected: ");
                sb.Append(Rows_rejected);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

