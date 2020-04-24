using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TTargetInfo : TBase
    {
        private bool      _is_agg;
        private TAggKind  _kind;
        private TTypeInfo _type;
        private TTypeInfo _arg_type;
        private bool      _skip_nulls;
        private bool      _is_distinct;

        public bool Is_agg
        {
            get
            {
                return _is_agg;
            }
            set
            {
                isset.is_agg = true;
                _is_agg   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TAggKind"/>
        /// </summary>
        public TAggKind Kind
        {
            get
            {
                return _kind;
            }
            set
            {
                isset.kind = true;
                _kind   = value;
            }
        }

        public TTypeInfo Type
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

        public TTypeInfo Arg_type
        {
            get
            {
                return _arg_type;
            }
            set
            {
                isset.arg_type = true;
                _arg_type   = value;
            }
        }

        public bool Skip_nulls
        {
            get
            {
                return _skip_nulls;
            }
            set
            {
                isset.skip_nulls = true;
                _skip_nulls   = value;
            }
        }

        public bool Is_distinct
        {
            get
            {
                return _is_distinct;
            }
            set
            {
                isset.is_distinct = true;
                _is_distinct   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool is_agg;
            public bool kind;
            public bool type;
            public bool arg_type;
            public bool skip_nulls;
            public bool is_distinct;
        }

        public TTargetInfo()
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
                                Is_agg = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Kind = (TAggKind)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Struct)
                            {
                                Type = new TTypeInfo();
                                await Type.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Struct)
                            {
                                Arg_type = new TTypeInfo();
                                await Arg_type.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Bool)
                            {
                                Skip_nulls = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Bool)
                            {
                                Is_distinct = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TTargetInfo");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.is_agg)
                {
                    field.Name = "is_agg";
                    field.Type = TType.Bool;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_agg, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.kind)
                {
                    field.Name = "kind";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Kind, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Type != null && isset.type)
                {
                    field.Name = "type";
                    field.Type = TType.Struct;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Type.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Arg_type != null && isset.arg_type)
                {
                    field.Name = "arg_type";
                    field.Type = TType.Struct;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Arg_type.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.skip_nulls)
                {
                    field.Name = "skip_nulls";
                    field.Type = TType.Bool;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Skip_nulls, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_distinct)
                {
                    field.Name = "is_distinct";
                    field.Type = TType.Bool;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_distinct, cancellationToken);
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
            var other = that as TTargetInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.is_agg      == other.isset.is_agg)      && ((!isset.is_agg)      || (System.Object.Equals(Is_agg,      other.Is_agg))))
                && ((isset.kind        == other.isset.kind)        && ((!isset.kind)        || (System.Object.Equals(Kind,        other.Kind))))
                && ((isset.type        == other.isset.type)        && ((!isset.type)        || (System.Object.Equals(Type,        other.Type))))
                && ((isset.arg_type    == other.isset.arg_type)    && ((!isset.arg_type)    || (System.Object.Equals(Arg_type,    other.Arg_type))))
                && ((isset.skip_nulls  == other.isset.skip_nulls)  && ((!isset.skip_nulls)  || (System.Object.Equals(Skip_nulls,  other.Skip_nulls))))
                && ((isset.is_distinct == other.isset.is_distinct) && ((!isset.is_distinct) || (System.Object.Equals(Is_distinct, other.Is_distinct))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.is_agg)
                    hashcode = (hashcode * 397) + Is_agg.GetHashCode();
                if(isset.kind)
                    hashcode = (hashcode * 397) + Kind.GetHashCode();
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.arg_type)
                    hashcode = (hashcode * 397) + Arg_type.GetHashCode();
                if(isset.skip_nulls)
                    hashcode = (hashcode * 397) + Skip_nulls.GetHashCode();
                if(isset.is_distinct)
                    hashcode = (hashcode * 397) + Is_distinct.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TTargetInfo(");
            bool __first = true;
            if (isset.is_agg)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_agg: ");
                sb.Append(Is_agg);
            }
            if (isset.kind)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Kind: ");
                sb.Append(Kind);
            }
            if (Type != null && isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type == null ? "<null>" : Type.ToString());
            }
            if (Arg_type != null && isset.arg_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Arg_type: ");
                sb.Append(Arg_type == null ? "<null>" : Arg_type.ToString());
            }
            if (isset.skip_nulls)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Skip_nulls: ");
                sb.Append(Skip_nulls);
            }
            if (isset.is_distinct)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_distinct: ");
                sb.Append(Is_distinct);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

