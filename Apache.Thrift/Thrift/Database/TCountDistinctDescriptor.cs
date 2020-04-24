using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TCountDistinctDescriptor : TBase
    {
        private TCountDistinctImplType _impl_type;
        private long                   _min_val;
        private long                   _bitmap_sz_bits;
        private bool                   _approximate;
        private TDeviceType            _device_type;
        private long                   _sub_bitmap_count;

        /// <summary>
        /// 
        /// <seealso cref="TCountDistinctImplType"/>
        /// </summary>
        public TCountDistinctImplType Impl_type
        {
            get
            {
                return _impl_type;
            }
            set
            {
                isset.impl_type = true;
                _impl_type   = value;
            }
        }

        public long Min_val
        {
            get
            {
                return _min_val;
            }
            set
            {
                isset.min_val = true;
                _min_val   = value;
            }
        }

        public long Bitmap_sz_bits
        {
            get
            {
                return _bitmap_sz_bits;
            }
            set
            {
                isset.bitmap_sz_bits = true;
                _bitmap_sz_bits   = value;
            }
        }

        public bool Approximate
        {
            get
            {
                return _approximate;
            }
            set
            {
                isset.approximate = true;
                _approximate   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TDeviceType"/>
        /// </summary>
        public TDeviceType Device_type
        {
            get
            {
                return _device_type;
            }
            set
            {
                isset.device_type = true;
                _device_type   = value;
            }
        }

        public long Sub_bitmap_count
        {
            get
            {
                return _sub_bitmap_count;
            }
            set
            {
                isset.sub_bitmap_count = true;
                _sub_bitmap_count   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool impl_type;
            public bool min_val;
            public bool bitmap_sz_bits;
            public bool approximate;
            public bool device_type;
            public bool sub_bitmap_count;
        }

        public TCountDistinctDescriptor()
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
                                Impl_type = (TCountDistinctImplType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Min_val = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Bitmap_sz_bits = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Approximate = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I32)
                            {
                                Device_type = (TDeviceType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I64)
                            {
                                Sub_bitmap_count = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TCountDistinctDescriptor");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.impl_type)
                {
                    field.Name = "impl_type";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Impl_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.min_val)
                {
                    field.Name = "min_val";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Min_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.bitmap_sz_bits)
                {
                    field.Name = "bitmap_sz_bits";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Bitmap_sz_bits, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.approximate)
                {
                    field.Name = "approximate";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Approximate, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.device_type)
                {
                    field.Name = "device_type";
                    field.Type = TType.I32;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Device_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.sub_bitmap_count)
                {
                    field.Name = "sub_bitmap_count";
                    field.Type = TType.I64;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Sub_bitmap_count, cancellationToken);
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
            var other = that as TCountDistinctDescriptor;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.impl_type        == other.isset.impl_type)        && ((!isset.impl_type)        || (System.Object.Equals(Impl_type,        other.Impl_type))))
                && ((isset.min_val          == other.isset.min_val)          && ((!isset.min_val)          || (System.Object.Equals(Min_val,          other.Min_val))))
                && ((isset.bitmap_sz_bits   == other.isset.bitmap_sz_bits)   && ((!isset.bitmap_sz_bits)   || (System.Object.Equals(Bitmap_sz_bits,   other.Bitmap_sz_bits))))
                && ((isset.approximate      == other.isset.approximate)      && ((!isset.approximate)      || (System.Object.Equals(Approximate,      other.Approximate))))
                && ((isset.device_type      == other.isset.device_type)      && ((!isset.device_type)      || (System.Object.Equals(Device_type,      other.Device_type))))
                && ((isset.sub_bitmap_count == other.isset.sub_bitmap_count) && ((!isset.sub_bitmap_count) || (System.Object.Equals(Sub_bitmap_count, other.Sub_bitmap_count))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.impl_type)
                    hashcode = (hashcode * 397) + Impl_type.GetHashCode();
                if(isset.min_val)
                    hashcode = (hashcode * 397) + Min_val.GetHashCode();
                if(isset.bitmap_sz_bits)
                    hashcode = (hashcode * 397) + Bitmap_sz_bits.GetHashCode();
                if(isset.approximate)
                    hashcode = (hashcode * 397) + Approximate.GetHashCode();
                if(isset.device_type)
                    hashcode = (hashcode * 397) + Device_type.GetHashCode();
                if(isset.sub_bitmap_count)
                    hashcode = (hashcode * 397) + Sub_bitmap_count.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCountDistinctDescriptor(");
            bool __first = true;
            if (isset.impl_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Impl_type: ");
                sb.Append(Impl_type);
            }
            if (isset.min_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Min_val: ");
                sb.Append(Min_val);
            }
            if (isset.bitmap_sz_bits)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Bitmap_sz_bits: ");
                sb.Append(Bitmap_sz_bits);
            }
            if (isset.approximate)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Approximate: ");
                sb.Append(Approximate);
            }
            if (isset.device_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Device_type: ");
                sb.Append(Device_type);
            }
            if (isset.sub_bitmap_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Sub_bitmap_count: ");
                sb.Append(Sub_bitmap_count);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

