using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TColumnRange : TBase
    {
        private TExpressionRangeType _type;
        private int                  _col_id;
        private int                  _table_id;
        private bool                 _has_nulls;
        private long                 _int_min;
        private long                 _int_max;
        private long                 _bucket;
        private double               _fp_min;
        private double               _fp_max;

        /// <summary>
        /// 
        /// <seealso cref="TExpressionRangeType"/>
        /// </summary>
        public TExpressionRangeType Type
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

        public int Col_id
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

        public bool Has_nulls
        {
            get
            {
                return _has_nulls;
            }
            set
            {
                isset.has_nulls = true;
                _has_nulls   = value;
            }
        }

        public long Int_min
        {
            get
            {
                return _int_min;
            }
            set
            {
                isset.int_min = true;
                _int_min   = value;
            }
        }

        public long Int_max
        {
            get
            {
                return _int_max;
            }
            set
            {
                isset.int_max = true;
                _int_max   = value;
            }
        }

        public long Bucket
        {
            get
            {
                return _bucket;
            }
            set
            {
                isset.bucket = true;
                _bucket   = value;
            }
        }

        public double Fp_min
        {
            get
            {
                return _fp_min;
            }
            set
            {
                isset.fp_min = true;
                _fp_min   = value;
            }
        }

        public double Fp_max
        {
            get
            {
                return _fp_max;
            }
            set
            {
                isset.fp_max = true;
                _fp_max   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool type;
            public bool col_id;
            public bool table_id;
            public bool has_nulls;
            public bool int_min;
            public bool int_max;
            public bool bucket;
            public bool fp_min;
            public bool fp_max;
        }

        public TColumnRange()
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
                                Type = (TExpressionRangeType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Col_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I32)
                            {
                                Table_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Has_nulls = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I64)
                            {
                                Int_min = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I64)
                            {
                                Int_max = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.I64)
                            {
                                Bucket = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.Double)
                            {
                                Fp_min = await iprot.ReadDoubleAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.Double)
                            {
                                Fp_max = await iprot.ReadDoubleAsync(cancellationToken);
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
                var struc = new TStruct("TColumnRange");
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
                if (isset.col_id)
                {
                    field.Name = "col_id";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Col_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.table_id)
                {
                    field.Name = "table_id";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Table_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.has_nulls)
                {
                    field.Name = "has_nulls";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Has_nulls, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.int_min)
                {
                    field.Name = "int_min";
                    field.Type = TType.I64;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Int_min, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.int_max)
                {
                    field.Name = "int_max";
                    field.Type = TType.I64;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Int_max, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.bucket)
                {
                    field.Name = "bucket";
                    field.Type = TType.I64;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Bucket, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.fp_min)
                {
                    field.Name = "fp_min";
                    field.Type = TType.Double;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteDoubleAsync(Fp_min, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.fp_max)
                {
                    field.Name = "fp_max";
                    field.Type = TType.Double;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteDoubleAsync(Fp_max, cancellationToken);
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
            var other = that as TColumnRange;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.type      == other.isset.type)      && ((!isset.type)      || (System.Object.Equals(Type,      other.Type))))
                && ((isset.col_id    == other.isset.col_id)    && ((!isset.col_id)    || (System.Object.Equals(Col_id,    other.Col_id))))
                && ((isset.table_id  == other.isset.table_id)  && ((!isset.table_id)  || (System.Object.Equals(Table_id,  other.Table_id))))
                && ((isset.has_nulls == other.isset.has_nulls) && ((!isset.has_nulls) || (System.Object.Equals(Has_nulls, other.Has_nulls))))
                && ((isset.int_min   == other.isset.int_min)   && ((!isset.int_min)   || (System.Object.Equals(Int_min,   other.Int_min))))
                && ((isset.int_max   == other.isset.int_max)   && ((!isset.int_max)   || (System.Object.Equals(Int_max,   other.Int_max))))
                && ((isset.bucket    == other.isset.bucket)    && ((!isset.bucket)    || (System.Object.Equals(Bucket,    other.Bucket))))
                && ((isset.fp_min    == other.isset.fp_min)    && ((!isset.fp_min)    || (System.Object.Equals(Fp_min,    other.Fp_min))))
                && ((isset.fp_max    == other.isset.fp_max)    && ((!isset.fp_max)    || (System.Object.Equals(Fp_max,    other.Fp_max))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.col_id)
                    hashcode = (hashcode * 397) + Col_id.GetHashCode();
                if(isset.table_id)
                    hashcode = (hashcode * 397) + Table_id.GetHashCode();
                if(isset.has_nulls)
                    hashcode = (hashcode * 397) + Has_nulls.GetHashCode();
                if(isset.int_min)
                    hashcode = (hashcode * 397) + Int_min.GetHashCode();
                if(isset.int_max)
                    hashcode = (hashcode * 397) + Int_max.GetHashCode();
                if(isset.bucket)
                    hashcode = (hashcode * 397) + Bucket.GetHashCode();
                if(isset.fp_min)
                    hashcode = (hashcode * 397) + Fp_min.GetHashCode();
                if(isset.fp_max)
                    hashcode = (hashcode * 397) + Fp_max.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TColumnRange(");
            bool __first = true;
            if (isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type);
            }
            if (isset.col_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_id: ");
                sb.Append(Col_id);
            }
            if (isset.table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_id: ");
                sb.Append(Table_id);
            }
            if (isset.has_nulls)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Has_nulls: ");
                sb.Append(Has_nulls);
            }
            if (isset.int_min)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Int_min: ");
                sb.Append(Int_min);
            }
            if (isset.int_max)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Int_max: ");
                sb.Append(Int_max);
            }
            if (isset.bucket)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Bucket: ");
                sb.Append(Bucket);
            }
            if (isset.fp_min)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Fp_min: ");
                sb.Append(Fp_min);
            }
            if (isset.fp_max)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Fp_max: ");
                sb.Append(Fp_max);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

