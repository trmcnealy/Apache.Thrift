using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDictionaryGeneration : TBase
    {
        private int  _dict_id;
        private long _entry_count;

        public int Dict_id
        {
            get
            {
                return _dict_id;
            }
            set
            {
                isset.dict_id = true;
                _dict_id   = value;
            }
        }

        public long Entry_count
        {
            get
            {
                return _entry_count;
            }
            set
            {
                isset.entry_count = true;
                _entry_count   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool dict_id;
            public bool entry_count;
        }

        public TDictionaryGeneration()
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
                                Dict_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Entry_count = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TDictionaryGeneration");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.dict_id)
                {
                    field.Name = "dict_id";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Dict_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.entry_count)
                {
                    field.Name = "entry_count";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Entry_count, cancellationToken);
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
            var other = that as TDictionaryGeneration;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.dict_id     == other.isset.dict_id)     && ((!isset.dict_id)     || (System.Object.Equals(Dict_id,     other.Dict_id))))
                && ((isset.entry_count == other.isset.entry_count) && ((!isset.entry_count) || (System.Object.Equals(Entry_count, other.Entry_count))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.dict_id)
                    hashcode = (hashcode * 397) + Dict_id.GetHashCode();
                if(isset.entry_count)
                    hashcode = (hashcode * 397) + Entry_count.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDictionaryGeneration(");
            bool __first = true;
            if (isset.dict_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dict_id: ");
                sb.Append(Dict_id);
            }
            if (isset.entry_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Entry_count: ");
                sb.Append(Entry_count);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

