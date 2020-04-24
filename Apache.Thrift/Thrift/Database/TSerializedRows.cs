using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TSerializedRows : TBase
    {
        private List<byte[]>               _buffers;
        private List<long>                 _buffer_lengths;
        private long                       _buffers_total_size;
        private int                        _total_compression_time_ms;
        private TResultSetBufferDescriptor _descriptor;
        private List<TTargetInfo>          _targets;
        private List<long>                 _target_init_vals;
        private List<byte[]>               _varlen_buffer;
        private List<TCountDistinctSet>    _count_distinct_sets;
        private string                     _explanation;

        public List<byte[]> Buffers
        {
            get
            {
                return _buffers;
            }
            set
            {
                isset.buffers = true;
                _buffers   = value;
            }
        }

        public List<long> Buffer_lengths
        {
            get
            {
                return _buffer_lengths;
            }
            set
            {
                isset.buffer_lengths = true;
                _buffer_lengths   = value;
            }
        }

        public long Buffers_total_size
        {
            get
            {
                return _buffers_total_size;
            }
            set
            {
                isset.buffers_total_size = true;
                _buffers_total_size   = value;
            }
        }

        public int Total_compression_time_ms
        {
            get
            {
                return _total_compression_time_ms;
            }
            set
            {
                isset.total_compression_time_ms = true;
                _total_compression_time_ms   = value;
            }
        }

        public TResultSetBufferDescriptor Descriptor
        {
            get
            {
                return _descriptor;
            }
            set
            {
                isset.descriptor = true;
                _descriptor   = value;
            }
        }

        public List<TTargetInfo> Targets
        {
            get
            {
                return _targets;
            }
            set
            {
                isset.targets = true;
                _targets   = value;
            }
        }

        public List<long> Target_init_vals
        {
            get
            {
                return _target_init_vals;
            }
            set
            {
                isset.target_init_vals = true;
                _target_init_vals   = value;
            }
        }

        public List<byte[]> Varlen_buffer
        {
            get
            {
                return _varlen_buffer;
            }
            set
            {
                isset.varlen_buffer = true;
                _varlen_buffer   = value;
            }
        }

        public List<TCountDistinctSet> Count_distinct_sets
        {
            get
            {
                return _count_distinct_sets;
            }
            set
            {
                isset.count_distinct_sets = true;
                _count_distinct_sets   = value;
            }
        }

        public string Explanation
        {
            get
            {
                return _explanation;
            }
            set
            {
                isset.explanation = true;
                _explanation   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool buffers;
            public bool buffer_lengths;
            public bool buffers_total_size;
            public bool total_compression_time_ms;
            public bool descriptor;
            public bool targets;
            public bool target_init_vals;
            public bool varlen_buffer;
            public bool count_distinct_sets;
            public bool explanation;
        }

        public TSerializedRows()
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
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list28 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Buffers = new List<byte[]>(_list28.Count);
                                    for(int _i29 = 0; _i29 < _list28.Count; ++_i29)
                                    {
                                        byte[] _elem30;
                                        _elem30 = await iprot.ReadBinaryAsync(cancellationToken);
                                        Buffers.Add(_elem30);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list31 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Buffer_lengths = new List<long>(_list31.Count);
                                    for(int _i32 = 0; _i32 < _list31.Count; ++_i32)
                                    {
                                        long _elem33;
                                        _elem33 = await iprot.ReadI64Async(cancellationToken);
                                        Buffer_lengths.Add(_elem33);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Buffers_total_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                Total_compression_time_ms = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Struct)
                            {
                                Descriptor = new TResultSetBufferDescriptor();
                                await Descriptor.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list34 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Targets = new List<TTargetInfo>(_list34.Count);
                                    for(int _i35 = 0; _i35 < _list34.Count; ++_i35)
                                    {
                                        TTargetInfo _elem36;
                                        _elem36 = new TTargetInfo();
                                        await _elem36.ReadAsync(iprot, cancellationToken);
                                        Targets.Add(_elem36);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list37 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Target_init_vals = new List<long>(_list37.Count);
                                    for(int _i38 = 0; _i38 < _list37.Count; ++_i38)
                                    {
                                        long _elem39;
                                        _elem39 = await iprot.ReadI64Async(cancellationToken);
                                        Target_init_vals.Add(_elem39);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list40 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Varlen_buffer = new List<byte[]>(_list40.Count);
                                    for(int _i41 = 0; _i41 < _list40.Count; ++_i41)
                                    {
                                        byte[] _elem42;
                                        _elem42 = await iprot.ReadBinaryAsync(cancellationToken);
                                        Varlen_buffer.Add(_elem42);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list43 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Count_distinct_sets = new List<TCountDistinctSet>(_list43.Count);
                                    for(int _i44 = 0; _i44 < _list43.Count; ++_i44)
                                    {
                                        TCountDistinctSet _elem45;
                                        _elem45 = new TCountDistinctSet();
                                        await _elem45.ReadAsync(iprot, cancellationToken);
                                        Count_distinct_sets.Add(_elem45);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 10:
                            if (field.Type == TType.String)
                            {
                                Explanation = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TSerializedRows");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Buffers != null && isset.buffers)
                {
                    field.Name = "buffers";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Buffers.Count), cancellationToken);
                        foreach (byte[] _iter46 in Buffers)
                        {
                            await oprot.WriteBinaryAsync(_iter46, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Buffer_lengths != null && isset.buffer_lengths)
                {
                    field.Name = "buffer_lengths";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Buffer_lengths.Count), cancellationToken);
                        foreach (long _iter47 in Buffer_lengths)
                        {
                            await oprot.WriteI64Async(_iter47, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.buffers_total_size)
                {
                    field.Name = "buffers_total_size";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Buffers_total_size, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.total_compression_time_ms)
                {
                    field.Name = "total_compression_time_ms";
                    field.Type = TType.I32;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Total_compression_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Descriptor != null && isset.descriptor)
                {
                    field.Name = "descriptor";
                    field.Type = TType.Struct;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Descriptor.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Targets != null && isset.targets)
                {
                    field.Name = "targets";
                    field.Type = TType.List;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Targets.Count), cancellationToken);
                        foreach (TTargetInfo _iter48 in Targets)
                        {
                            await _iter48.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Target_init_vals != null && isset.target_init_vals)
                {
                    field.Name = "target_init_vals";
                    field.Type = TType.List;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Target_init_vals.Count), cancellationToken);
                        foreach (long _iter49 in Target_init_vals)
                        {
                            await oprot.WriteI64Async(_iter49, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Varlen_buffer != null && isset.varlen_buffer)
                {
                    field.Name = "varlen_buffer";
                    field.Type = TType.List;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Varlen_buffer.Count), cancellationToken);
                        foreach (byte[] _iter50 in Varlen_buffer)
                        {
                            await oprot.WriteBinaryAsync(_iter50, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Count_distinct_sets != null && isset.count_distinct_sets)
                {
                    field.Name = "count_distinct_sets";
                    field.Type = TType.List;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Count_distinct_sets.Count), cancellationToken);
                        foreach (TCountDistinctSet _iter51 in Count_distinct_sets)
                        {
                            await _iter51.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Explanation != null && isset.explanation)
                {
                    field.Name = "explanation";
                    field.Type = TType.String;
                    field.ID   = 10;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Explanation, cancellationToken);
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
            var other = that as TSerializedRows;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.buffers                   == other.isset.buffers)                   && ((!isset.buffers)                   || (TCollections.Equals(Buffers,        other.Buffers))))
                && ((isset.buffer_lengths            == other.isset.buffer_lengths)            && ((!isset.buffer_lengths)            || (TCollections.Equals(Buffer_lengths, other.Buffer_lengths))))
                && ((isset.buffers_total_size        == other.isset.buffers_total_size)        && ((!isset.buffers_total_size)        || (System.Object.Equals(Buffers_total_size,        other.Buffers_total_size))))
                && ((isset.total_compression_time_ms == other.isset.total_compression_time_ms) && ((!isset.total_compression_time_ms) || (System.Object.Equals(Total_compression_time_ms, other.Total_compression_time_ms))))
                && ((isset.descriptor                == other.isset.descriptor)                && ((!isset.descriptor)                || (System.Object.Equals(Descriptor,                other.Descriptor))))
                && ((isset.targets                   == other.isset.targets)                   && ((!isset.targets)                   || (TCollections.Equals(Targets,             other.Targets))))
                && ((isset.target_init_vals          == other.isset.target_init_vals)          && ((!isset.target_init_vals)          || (TCollections.Equals(Target_init_vals,    other.Target_init_vals))))
                && ((isset.varlen_buffer             == other.isset.varlen_buffer)             && ((!isset.varlen_buffer)             || (TCollections.Equals(Varlen_buffer,       other.Varlen_buffer))))
                && ((isset.count_distinct_sets       == other.isset.count_distinct_sets)       && ((!isset.count_distinct_sets)       || (TCollections.Equals(Count_distinct_sets, other.Count_distinct_sets))))
                && ((isset.explanation               == other.isset.explanation)               && ((!isset.explanation)               || (System.Object.Equals(Explanation, other.Explanation))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.buffers)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Buffers);
                if(isset.buffer_lengths)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Buffer_lengths);
                if(isset.buffers_total_size)
                    hashcode = (hashcode * 397) + Buffers_total_size.GetHashCode();
                if(isset.total_compression_time_ms)
                    hashcode = (hashcode * 397) + Total_compression_time_ms.GetHashCode();
                if(isset.descriptor)
                    hashcode = (hashcode * 397) + Descriptor.GetHashCode();
                if(isset.targets)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Targets);
                if(isset.target_init_vals)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Target_init_vals);
                if(isset.varlen_buffer)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Varlen_buffer);
                if(isset.count_distinct_sets)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Count_distinct_sets);
                if(isset.explanation)
                    hashcode = (hashcode * 397) + Explanation.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TSerializedRows(");
            bool __first = true;
            if (Buffers != null && isset.buffers)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Buffers: ");
                sb.Append(Buffers);
            }
            if (Buffer_lengths != null && isset.buffer_lengths)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Buffer_lengths: ");
                sb.Append(Buffer_lengths);
            }
            if (isset.buffers_total_size)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Buffers_total_size: ");
                sb.Append(Buffers_total_size);
            }
            if (isset.total_compression_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Total_compression_time_ms: ");
                sb.Append(Total_compression_time_ms);
            }
            if (Descriptor != null && isset.descriptor)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Descriptor: ");
                sb.Append(Descriptor == null ? "<null>" : Descriptor.ToString());
            }
            if (Targets != null && isset.targets)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Targets: ");
                sb.Append(Targets);
            }
            if (Target_init_vals != null && isset.target_init_vals)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Target_init_vals: ");
                sb.Append(Target_init_vals);
            }
            if (Varlen_buffer != null && isset.varlen_buffer)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Varlen_buffer: ");
                sb.Append(Varlen_buffer);
            }
            if (Count_distinct_sets != null && isset.count_distinct_sets)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Count_distinct_sets: ");
                sb.Append(Count_distinct_sets);
            }
            if (Explanation != null && isset.explanation)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Explanation: ");
                sb.Append(Explanation);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

