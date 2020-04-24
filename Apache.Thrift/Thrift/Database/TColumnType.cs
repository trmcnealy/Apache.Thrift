using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TColumnType : TBase
    {
        private string    _col_name;
        private TTypeInfo _col_type;
        private bool      _is_reserved_keyword;
        private string    _src_name;
        private bool      _is_system;
        private bool      _is_physical;
        private long      _col_id;

        public string Col_name
        {
            get
            {
                return _col_name;
            }
            set
            {
                isset.col_name = true;
                _col_name   = value;
            }
        }

        public TTypeInfo Col_type
        {
            get
            {
                return _col_type;
            }
            set
            {
                isset.col_type = true;
                _col_type   = value;
            }
        }

        public bool Is_reserved_keyword
        {
            get
            {
                return _is_reserved_keyword;
            }
            set
            {
                isset.is_reserved_keyword = true;
                _is_reserved_keyword   = value;
            }
        }

        public string Src_name
        {
            get
            {
                return _src_name;
            }
            set
            {
                isset.src_name = true;
                _src_name   = value;
            }
        }

        public bool Is_system
        {
            get
            {
                return _is_system;
            }
            set
            {
                isset.is_system = true;
                _is_system   = value;
            }
        }

        public bool Is_physical
        {
            get
            {
                return _is_physical;
            }
            set
            {
                isset.is_physical = true;
                _is_physical   = value;
            }
        }

        public long Col_id
        {
            get
            {
                return _col_id;
            }
            set
            {
                isset.col_id = true;
                _col_id   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool col_name;
            public bool col_type;
            public bool is_reserved_keyword;
            public bool src_name;
            public bool is_system;
            public bool is_physical;
            public bool col_id;
        }

        public TColumnType()
        {
            isset = new Isset();
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
                                Col_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Struct)
                            {
                                Col_type = new TTypeInfo();
                                await Col_type.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Bool)
                            {
                                Is_reserved_keyword = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.String)
                            {
                                Src_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Bool)
                            {
                                Is_system = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Bool)
                            {
                                Is_physical = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.I64)
                            {
                                Col_id = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TColumnType");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Col_name != null && isset.col_name)
                {
                    field.Name = "col_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Col_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Col_type != null && isset.col_type)
                {
                    field.Name = "col_type";
                    field.Type = TType.Struct;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Col_type.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_reserved_keyword)
                {
                    field.Name = "is_reserved_keyword";
                    field.Type = TType.Bool;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_reserved_keyword, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Src_name != null && isset.src_name)
                {
                    field.Name = "src_name";
                    field.Type = TType.String;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Src_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_system)
                {
                    field.Name = "is_system";
                    field.Type = TType.Bool;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_system, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_physical)
                {
                    field.Name = "is_physical";
                    field.Type = TType.Bool;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_physical, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.col_id)
                {
                    field.Name = "col_id";
                    field.Type = TType.I64;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Col_id, cancellationToken);
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
            var other = that as TColumnType;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.col_name            == other.isset.col_name)            && ((!isset.col_name)            || (System.Object.Equals(Col_name,            other.Col_name))))
                && ((isset.col_type            == other.isset.col_type)            && ((!isset.col_type)            || (System.Object.Equals(Col_type,            other.Col_type))))
                && ((isset.is_reserved_keyword == other.isset.is_reserved_keyword) && ((!isset.is_reserved_keyword) || (System.Object.Equals(Is_reserved_keyword, other.Is_reserved_keyword))))
                && ((isset.src_name            == other.isset.src_name)            && ((!isset.src_name)            || (System.Object.Equals(Src_name,            other.Src_name))))
                && ((isset.is_system           == other.isset.is_system)           && ((!isset.is_system)           || (System.Object.Equals(Is_system,           other.Is_system))))
                && ((isset.is_physical         == other.isset.is_physical)         && ((!isset.is_physical)         || (System.Object.Equals(Is_physical,         other.Is_physical))))
                && ((isset.col_id              == other.isset.col_id)              && ((!isset.col_id)              || (System.Object.Equals(Col_id,              other.Col_id))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.col_name)
                    hashcode = (hashcode * 397) + Col_name.GetHashCode();
                if(isset.col_type)
                    hashcode = (hashcode * 397) + Col_type.GetHashCode();
                if(isset.is_reserved_keyword)
                    hashcode = (hashcode * 397) + Is_reserved_keyword.GetHashCode();
                if(isset.src_name)
                    hashcode = (hashcode * 397) + Src_name.GetHashCode();
                if(isset.is_system)
                    hashcode = (hashcode * 397) + Is_system.GetHashCode();
                if(isset.is_physical)
                    hashcode = (hashcode * 397) + Is_physical.GetHashCode();
                if(isset.col_id)
                    hashcode = (hashcode * 397) + Col_id.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TColumnType(");
            bool __first = true;
            if (Col_name != null && isset.col_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_name: ");
                sb.Append(Col_name);
            }
            if (Col_type != null && isset.col_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_type: ");
                sb.Append(Col_type == null ? "<null>" : Col_type.ToString());
            }
            if (isset.is_reserved_keyword)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_reserved_keyword: ");
                sb.Append(Is_reserved_keyword);
            }
            if (Src_name != null && isset.src_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Src_name: ");
                sb.Append(Src_name);
            }
            if (isset.is_system)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_system: ");
                sb.Append(Is_system);
            }
            if (isset.is_physical)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_physical: ");
                sb.Append(Is_physical);
            }
            if (isset.col_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_id: ");
                sb.Append(Col_id);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

