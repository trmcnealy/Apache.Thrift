using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TTableGeneration : TBase
    {
        private int  _table_id;
        private long _tuple_count;
        private long _start_rowid;

        public int Table_id
        {
            get
            {
                return _table_id;
            }
            set
            {
                isset.table_id = true;
                _table_id   = value;
            }
        }

        public long Tuple_count
        {
            get
            {
                return _tuple_count;
            }
            set
            {
                isset.tuple_count = true;
                _tuple_count   = value;
            }
        }

        public long Start_rowid
        {
            get
            {
                return _start_rowid;
            }
            set
            {
                isset.start_rowid = true;
                _start_rowid   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool table_id;
            public bool tuple_count;
            public bool start_rowid;
        }

        public TTableGeneration()
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
                                Table_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Tuple_count = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Start_rowid = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TTableGeneration");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.table_id)
                {
                    field.Name = "table_id";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Table_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.tuple_count)
                {
                    field.Name = "tuple_count";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Tuple_count, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.start_rowid)
                {
                    field.Name = "start_rowid";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Start_rowid, cancellationToken);
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
            var other = that as TTableGeneration;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.table_id    == other.isset.table_id)    && ((!isset.table_id)    || (System.Object.Equals(Table_id,    other.Table_id))))
                && ((isset.tuple_count == other.isset.tuple_count) && ((!isset.tuple_count) || (System.Object.Equals(Tuple_count, other.Tuple_count))))
                && ((isset.start_rowid == other.isset.start_rowid) && ((!isset.start_rowid) || (System.Object.Equals(Start_rowid, other.Start_rowid))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.table_id)
                    hashcode = (hashcode * 397) + Table_id.GetHashCode();
                if(isset.tuple_count)
                    hashcode = (hashcode * 397) + Tuple_count.GetHashCode();
                if(isset.start_rowid)
                    hashcode = (hashcode * 397) + Start_rowid.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TTableGeneration(");
            bool __first = true;
            if (isset.table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_id: ");
                sb.Append(Table_id);
            }
            if (isset.tuple_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Tuple_count: ");
                sb.Append(Tuple_count);
            }
            if (isset.start_rowid)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Start_rowid: ");
                sb.Append(Start_rowid);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

