using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TCountDistinctSet : TBase
    {
        private TCountDistinctImplType   _type;
        private TCountDistinctSetStorage _storage;
        private long                     _remote_ptr;

        /// <summary>
        /// 
        /// <seealso cref="TCountDistinctImplType"/>
        /// </summary>
        public TCountDistinctImplType Type
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

        public TCountDistinctSetStorage Storage
        {
            get
            {
                return _storage;
            }
            set
            {
                isset.storage = true;
                _storage   = value;
            }
        }

        public long Remote_ptr
        {
            get
            {
                return _remote_ptr;
            }
            set
            {
                isset.remote_ptr = true;
                _remote_ptr   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool type;
            public bool storage;
            public bool remote_ptr;
        }

        public TCountDistinctSet()
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
                                Type = (TCountDistinctImplType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Struct)
                            {
                                Storage = new TCountDistinctSetStorage();
                                await Storage.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Remote_ptr = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TCountDistinctSet");
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
                if (Storage != null && isset.storage)
                {
                    field.Name = "storage";
                    field.Type = TType.Struct;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Storage.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.remote_ptr)
                {
                    field.Name = "remote_ptr";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Remote_ptr, cancellationToken);
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
            var other = that as TCountDistinctSet;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.type       == other.isset.type)       && ((!isset.type)       || (System.Object.Equals(Type,       other.Type))))
                && ((isset.storage    == other.isset.storage)    && ((!isset.storage)    || (System.Object.Equals(Storage,    other.Storage))))
                && ((isset.remote_ptr == other.isset.remote_ptr) && ((!isset.remote_ptr) || (System.Object.Equals(Remote_ptr, other.Remote_ptr))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.storage)
                    hashcode = (hashcode * 397) + Storage.GetHashCode();
                if(isset.remote_ptr)
                    hashcode = (hashcode * 397) + Remote_ptr.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCountDistinctSet(");
            bool __first = true;
            if (isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type);
            }
            if (Storage != null && isset.storage)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Storage: ");
                sb.Append(Storage == null ? "<null>" : Storage.ToString());
            }
            if (isset.remote_ptr)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Remote_ptr: ");
                sb.Append(Remote_ptr);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

