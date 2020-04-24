using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRawRenderPassDataResult : TBase
    {
        private int    _num_pixel_channels;
        private int    _num_pixel_samples;
        private byte[] _pixels;
        private byte[] _row_ids_A;
        private byte[] _row_ids_B;
        private byte[] _table_ids;
        private byte[] _accum_data;
        private int    _accum_depth;

        public int Num_pixel_channels
        {
            get
            {
                return _num_pixel_channels;
            }
            set
            {
                isset.num_pixel_channels = true;
                _num_pixel_channels   = value;
            }
        }

        public int Num_pixel_samples
        {
            get
            {
                return _num_pixel_samples;
            }
            set
            {
                isset.num_pixel_samples = true;
                _num_pixel_samples   = value;
            }
        }

        public byte[] Pixels
        {
            get
            {
                return _pixels;
            }
            set
            {
                isset.pixels = true;
                _pixels   = value;
            }
        }

        public byte[] Row_ids_A
        {
            get
            {
                return _row_ids_A;
            }
            set
            {
                isset.row_ids_A = true;
                _row_ids_A   = value;
            }
        }

        public byte[] Row_ids_B
        {
            get
            {
                return _row_ids_B;
            }
            set
            {
                isset.row_ids_B = true;
                _row_ids_B   = value;
            }
        }

        public byte[] Table_ids
        {
            get
            {
                return _table_ids;
            }
            set
            {
                isset.table_ids = true;
                _table_ids   = value;
            }
        }

        public byte[] Accum_data
        {
            get
            {
                return _accum_data;
            }
            set
            {
                isset.accum_data = true;
                _accum_data   = value;
            }
        }

        public int Accum_depth
        {
            get
            {
                return _accum_depth;
            }
            set
            {
                isset.accum_depth = true;
                _accum_depth   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool num_pixel_channels;
            public bool num_pixel_samples;
            public bool pixels;
            public bool row_ids_A;
            public bool row_ids_B;
            public bool table_ids;
            public bool accum_data;
            public bool accum_depth;
        }

        public TRawRenderPassDataResult()
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
                                Num_pixel_channels = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Num_pixel_samples = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.String)
                            {
                                Pixels = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.String)
                            {
                                Row_ids_A = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.String)
                            {
                                Row_ids_B = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.String)
                            {
                                Table_ids = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.String)
                            {
                                Accum_data = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.I32)
                            {
                                Accum_depth = await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TRawRenderPassDataResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.num_pixel_channels)
                {
                    field.Name = "num_pixel_channels";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Num_pixel_channels, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.num_pixel_samples)
                {
                    field.Name = "num_pixel_samples";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Num_pixel_samples, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Pixels != null && isset.pixels)
                {
                    field.Name = "pixels";
                    field.Type = TType.String;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Pixels, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Row_ids_A != null && isset.row_ids_A)
                {
                    field.Name = "row_ids_A";
                    field.Type = TType.String;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Row_ids_A, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Row_ids_B != null && isset.row_ids_B)
                {
                    field.Name = "row_ids_B";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Row_ids_B, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Table_ids != null && isset.table_ids)
                {
                    field.Name = "table_ids";
                    field.Type = TType.String;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Table_ids, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Accum_data != null && isset.accum_data)
                {
                    field.Name = "accum_data";
                    field.Type = TType.String;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Accum_data, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.accum_depth)
                {
                    field.Name = "accum_depth";
                    field.Type = TType.I32;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Accum_depth, cancellationToken);
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
            var other = that as TRawRenderPassDataResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.num_pixel_channels == other.isset.num_pixel_channels) && ((!isset.num_pixel_channels) || (System.Object.Equals(Num_pixel_channels, other.Num_pixel_channels))))
                && ((isset.num_pixel_samples  == other.isset.num_pixel_samples)  && ((!isset.num_pixel_samples)  || (System.Object.Equals(Num_pixel_samples,  other.Num_pixel_samples))))
                && ((isset.pixels             == other.isset.pixels)             && ((!isset.pixels)             || (TCollections.Equals(Pixels,     other.Pixels))))
                && ((isset.row_ids_A          == other.isset.row_ids_A)          && ((!isset.row_ids_A)          || (TCollections.Equals(Row_ids_A,  other.Row_ids_A))))
                && ((isset.row_ids_B          == other.isset.row_ids_B)          && ((!isset.row_ids_B)          || (TCollections.Equals(Row_ids_B,  other.Row_ids_B))))
                && ((isset.table_ids          == other.isset.table_ids)          && ((!isset.table_ids)          || (TCollections.Equals(Table_ids,  other.Table_ids))))
                && ((isset.accum_data         == other.isset.accum_data)         && ((!isset.accum_data)         || (TCollections.Equals(Accum_data, other.Accum_data))))
                && ((isset.accum_depth        == other.isset.accum_depth)        && ((!isset.accum_depth)        || (System.Object.Equals(Accum_depth, other.Accum_depth))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.num_pixel_channels)
                    hashcode = (hashcode * 397) + Num_pixel_channels.GetHashCode();
                if(isset.num_pixel_samples)
                    hashcode = (hashcode * 397) + Num_pixel_samples.GetHashCode();
                if(isset.pixels)
                    hashcode = (hashcode * 397) + Pixels.GetHashCode();
                if(isset.row_ids_A)
                    hashcode = (hashcode * 397) + Row_ids_A.GetHashCode();
                if(isset.row_ids_B)
                    hashcode = (hashcode * 397) + Row_ids_B.GetHashCode();
                if(isset.table_ids)
                    hashcode = (hashcode * 397) + Table_ids.GetHashCode();
                if(isset.accum_data)
                    hashcode = (hashcode * 397) + Accum_data.GetHashCode();
                if(isset.accum_depth)
                    hashcode = (hashcode * 397) + Accum_depth.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRawRenderPassDataResult(");
            bool __first = true;
            if (isset.num_pixel_channels)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_pixel_channels: ");
                sb.Append(Num_pixel_channels);
            }
            if (isset.num_pixel_samples)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_pixel_samples: ");
                sb.Append(Num_pixel_samples);
            }
            if (Pixels != null && isset.pixels)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Pixels: ");
                sb.Append(Pixels);
            }
            if (Row_ids_A != null && isset.row_ids_A)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_ids_A: ");
                sb.Append(Row_ids_A);
            }
            if (Row_ids_B != null && isset.row_ids_B)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_ids_B: ");
                sb.Append(Row_ids_B);
            }
            if (Table_ids != null && isset.table_ids)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_ids: ");
                sb.Append(Table_ids);
            }
            if (Accum_data != null && isset.accum_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Accum_data: ");
                sb.Append(Accum_data);
            }
            if (isset.accum_depth)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Accum_depth: ");
                sb.Append(Accum_depth);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

