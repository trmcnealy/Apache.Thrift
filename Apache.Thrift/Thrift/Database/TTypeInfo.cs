using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TTypeInfo : TBase
    {
        private TDatumType    _type;
        private TEncodingType _encoding;
        private bool          _nullable;
        private bool          _is_array;
        private int           _precision;
        private int           _scale;
        private int           _comp_param;
        private int           _size;

        /// <summary>
        /// 
        /// <seealso cref="TDatumType"/>
        /// </summary>
        public TDatumType Type
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

        /// <summary>
        /// 
        /// <seealso cref="TEncodingType"/>
        /// </summary>
        public TEncodingType Encoding
        {
            get
            {
                return _encoding;
            }
            set
            {
                isset.encoding = true;
                _encoding   = value;
            }
        }

        public bool Nullable
        {
            get
            {
                return _nullable;
            }
            set
            {
                isset.nullable = true;
                _nullable   = value;
            }
        }

        public bool Is_array
        {
            get
            {
                return _is_array;
            }
            set
            {
                isset.is_array = true;
                _is_array   = value;
            }
        }

        public int Precision
        {
            get
            {
                return _precision;
            }
            set
            {
                isset.precision = true;
                _precision   = value;
            }
        }

        public int Scale
        {
            get
            {
                return _scale;
            }
            set
            {
                isset.scale = true;
                _scale   = value;
            }
        }

        public int Comp_param
        {
            get
            {
                return _comp_param;
            }
            set
            {
                isset.comp_param = true;
                _comp_param   = value;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                isset.size = true;
                _size   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool type;
            public bool encoding;
            public bool nullable;
            public bool is_array;
            public bool precision;
            public bool scale;
            public bool comp_param;
            public bool size;
        }

        public TTypeInfo()
        {
            _size        = -1;
            isset.size = true;
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
                                Type = (TDatumType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                Encoding = (TEncodingType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Nullable = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Bool)
                            {
                                Is_array = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I32)
                            {
                                Precision = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I32)
                            {
                                Scale = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.I32)
                            {
                                Comp_param = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.I32)
                            {
                                Size = await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TTypeInfo");
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
                if (isset.nullable)
                {
                    field.Name = "nullable";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Nullable, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_array)
                {
                    field.Name = "is_array";
                    field.Type = TType.Bool;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_array, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.encoding)
                {
                    field.Name = "encoding";
                    field.Type = TType.I32;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Encoding, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.precision)
                {
                    field.Name = "precision";
                    field.Type = TType.I32;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Precision, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.scale)
                {
                    field.Name = "scale";
                    field.Type = TType.I32;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Scale, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.comp_param)
                {
                    field.Name = "comp_param";
                    field.Type = TType.I32;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Comp_param, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.size)
                {
                    field.Name = "size";
                    field.Type = TType.I32;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Size, cancellationToken);
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
            var other = that as TTypeInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.type       == other.isset.type)       && ((!isset.type)       || (System.Object.Equals(Type,       other.Type))))
                && ((isset.encoding   == other.isset.encoding)   && ((!isset.encoding)   || (System.Object.Equals(Encoding,   other.Encoding))))
                && ((isset.nullable   == other.isset.nullable)   && ((!isset.nullable)   || (System.Object.Equals(Nullable,   other.Nullable))))
                && ((isset.is_array   == other.isset.is_array)   && ((!isset.is_array)   || (System.Object.Equals(Is_array,   other.Is_array))))
                && ((isset.precision  == other.isset.precision)  && ((!isset.precision)  || (System.Object.Equals(Precision,  other.Precision))))
                && ((isset.scale      == other.isset.scale)      && ((!isset.scale)      || (System.Object.Equals(Scale,      other.Scale))))
                && ((isset.comp_param == other.isset.comp_param) && ((!isset.comp_param) || (System.Object.Equals(Comp_param, other.Comp_param))))
                && ((isset.size       == other.isset.size)       && ((!isset.size)       || (System.Object.Equals(Size,       other.Size))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.encoding)
                    hashcode = (hashcode * 397) + Encoding.GetHashCode();
                if(isset.nullable)
                    hashcode = (hashcode * 397) + Nullable.GetHashCode();
                if(isset.is_array)
                    hashcode = (hashcode * 397) + Is_array.GetHashCode();
                if(isset.precision)
                    hashcode = (hashcode * 397) + Precision.GetHashCode();
                if(isset.scale)
                    hashcode = (hashcode * 397) + Scale.GetHashCode();
                if(isset.comp_param)
                    hashcode = (hashcode * 397) + Comp_param.GetHashCode();
                if(isset.size)
                    hashcode = (hashcode * 397) + Size.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TTypeInfo(");
            bool __first = true;
            if (isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type);
            }
            if (isset.encoding)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Encoding: ");
                sb.Append(Encoding);
            }
            if (isset.nullable)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Nullable: ");
                sb.Append(Nullable);
            }
            if (isset.is_array)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_array: ");
                sb.Append(Is_array);
            }
            if (isset.precision)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Precision: ");
                sb.Append(Precision);
            }
            if (isset.scale)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Scale: ");
                sb.Append(Scale);
            }
            if (isset.comp_param)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Comp_param: ");
                sb.Append(Comp_param);
            }
            if (isset.size)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Size: ");
                sb.Append(Size);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

