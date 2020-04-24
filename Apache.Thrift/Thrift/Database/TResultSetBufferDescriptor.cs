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
    public class TResultSetBufferDescriptor : TBase
    {
        private TResultSetLayout               _layout;
        private bool                           _keyless;
        private int                            _entry_count;
        private int                            _idx_target_as_key;
        private long                           _min_val;
        private long                           _max_val;
        private long                           _bucket;
        private List<short>                    _group_col_widths;
        private short                          _key_bytewidth;
        private TColSlotContext                _col_slot_context;
        private List<int>                      _target_groupby_indices;
        private List<TCountDistinctDescriptor> _count_distinct_descriptors;
        private bool                           _force_4byte_float;

        /// <summary>
        /// 
        /// <seealso cref="TResultSetLayout"/>
        /// </summary>
        public TResultSetLayout Layout
        {
            get
            {
                return _layout;
            }
            set
            {
                isset.layout = true;
                _layout   = value;
            }
        }

        public bool Keyless
        {
            get
            {
                return _keyless;
            }
            set
            {
                isset.keyless = true;
                _keyless   = value;
            }
        }

        public int Entry_count
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

        public int Idx_target_as_key
        {
            get
            {
                return _idx_target_as_key;
            }
            set
            {
                isset.idx_target_as_key = true;
                _idx_target_as_key   = value;
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

        public long Max_val
        {
            get
            {
                return _max_val;
            }
            set
            {
                isset.max_val = true;
                _max_val   = value;
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

        public List<short> Group_col_widths
        {
            get
            {
                return _group_col_widths;
            }
            set
            {
                isset.group_col_widths = true;
                _group_col_widths   = value;
            }
        }

        public short Key_bytewidth
        {
            get
            {
                return _key_bytewidth;
            }
            set
            {
                isset.key_bytewidth = true;
                _key_bytewidth   = value;
            }
        }

        public TColSlotContext Col_slot_context
        {
            get
            {
                return _col_slot_context;
            }
            set
            {
                isset.col_slot_context = true;
                _col_slot_context   = value;
            }
        }

        public List<int> Target_groupby_indices
        {
            get
            {
                return _target_groupby_indices;
            }
            set
            {
                isset.target_groupby_indices = true;
                _target_groupby_indices   = value;
            }
        }

        public List<TCountDistinctDescriptor> Count_distinct_descriptors
        {
            get
            {
                return _count_distinct_descriptors;
            }
            set
            {
                isset.count_distinct_descriptors = true;
                _count_distinct_descriptors   = value;
            }
        }

        public bool Force_4byte_float
        {
            get
            {
                return _force_4byte_float;
            }
            set
            {
                isset.force_4byte_float = true;
                _force_4byte_float   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool layout;
            public bool keyless;
            public bool entry_count;
            public bool idx_target_as_key;
            public bool min_val;
            public bool max_val;
            public bool bucket;
            public bool group_col_widths;
            public bool key_bytewidth;
            public bool col_slot_context;
            public bool target_groupby_indices;
            public bool count_distinct_descriptors;
            public bool force_4byte_float;
        }

        public TResultSetBufferDescriptor()
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
                                Layout = (TResultSetLayout)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Keyless = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I32)
                            {
                                Entry_count = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                Idx_target_as_key = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I64)
                            {
                                Min_val = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I64)
                            {
                                Max_val = await iprot.ReadI64Async(cancellationToken);
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
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list12 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Group_col_widths = new List<short>(_list12.Count);
                                    for(int _i13 = 0; _i13 < _list12.Count; ++_i13)
                                    {
                                        short _elem14;
                                        _elem14 = await iprot.ReadI16Async(cancellationToken);
                                        Group_col_widths.Add(_elem14);
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
                            if (field.Type == TType.I16)
                            {
                                Key_bytewidth = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 10:
                            if (field.Type == TType.Struct)
                            {
                                Col_slot_context = new TColSlotContext();
                                await Col_slot_context.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 11:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list15 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Target_groupby_indices = new List<int>(_list15.Count);
                                    for(int _i16 = 0; _i16 < _list15.Count; ++_i16)
                                    {
                                        int _elem17;
                                        _elem17 = await iprot.ReadI32Async(cancellationToken);
                                        Target_groupby_indices.Add(_elem17);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 12:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list18 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Count_distinct_descriptors = new List<TCountDistinctDescriptor>(_list18.Count);
                                    for(int _i19 = 0; _i19 < _list18.Count; ++_i19)
                                    {
                                        TCountDistinctDescriptor _elem20;
                                        _elem20 = new TCountDistinctDescriptor();
                                        await _elem20.ReadAsync(iprot, cancellationToken);
                                        Count_distinct_descriptors.Add(_elem20);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 13:
                            if (field.Type == TType.Bool)
                            {
                                Force_4byte_float = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TResultSetBufferDescriptor");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.layout)
                {
                    field.Name = "layout";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Layout, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.keyless)
                {
                    field.Name = "keyless";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Keyless, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.entry_count)
                {
                    field.Name = "entry_count";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Entry_count, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.idx_target_as_key)
                {
                    field.Name = "idx_target_as_key";
                    field.Type = TType.I32;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Idx_target_as_key, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.min_val)
                {
                    field.Name = "min_val";
                    field.Type = TType.I64;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Min_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.max_val)
                {
                    field.Name = "max_val";
                    field.Type = TType.I64;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Max_val, cancellationToken);
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
                if (Group_col_widths != null && isset.group_col_widths)
                {
                    field.Name = "group_col_widths";
                    field.Type = TType.List;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I16, Group_col_widths.Count), cancellationToken);
                        foreach (short _iter21 in Group_col_widths)
                        {
                            await oprot.WriteI16Async(_iter21, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.key_bytewidth)
                {
                    field.Name = "key_bytewidth";
                    field.Type = TType.I16;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI16Async(Key_bytewidth, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Col_slot_context != null && isset.col_slot_context)
                {
                    field.Name = "col_slot_context";
                    field.Type = TType.Struct;
                    field.ID   = 10;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Col_slot_context.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Target_groupby_indices != null && isset.target_groupby_indices)
                {
                    field.Name = "target_groupby_indices";
                    field.Type = TType.List;
                    field.ID   = 11;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, Target_groupby_indices.Count), cancellationToken);
                        foreach (int _iter22 in Target_groupby_indices)
                        {
                            await oprot.WriteI32Async(_iter22, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Count_distinct_descriptors != null && isset.count_distinct_descriptors)
                {
                    field.Name = "count_distinct_descriptors";
                    field.Type = TType.List;
                    field.ID   = 12;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Count_distinct_descriptors.Count), cancellationToken);
                        foreach (TCountDistinctDescriptor _iter23 in Count_distinct_descriptors)
                        {
                            await _iter23.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.force_4byte_float)
                {
                    field.Name = "force_4byte_float";
                    field.Type = TType.Bool;
                    field.ID   = 13;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Force_4byte_float, cancellationToken);
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
            var other = that as TResultSetBufferDescriptor;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.layout                     == other.isset.layout)                     && ((!isset.layout)                     || (System.Object.Equals(Layout,            other.Layout))))
                && ((isset.keyless                    == other.isset.keyless)                    && ((!isset.keyless)                    || (System.Object.Equals(Keyless,           other.Keyless))))
                && ((isset.entry_count                == other.isset.entry_count)                && ((!isset.entry_count)                || (System.Object.Equals(Entry_count,       other.Entry_count))))
                && ((isset.idx_target_as_key          == other.isset.idx_target_as_key)          && ((!isset.idx_target_as_key)          || (System.Object.Equals(Idx_target_as_key, other.Idx_target_as_key))))
                && ((isset.min_val                    == other.isset.min_val)                    && ((!isset.min_val)                    || (System.Object.Equals(Min_val,           other.Min_val))))
                && ((isset.max_val                    == other.isset.max_val)                    && ((!isset.max_val)                    || (System.Object.Equals(Max_val,           other.Max_val))))
                && ((isset.bucket                     == other.isset.bucket)                     && ((!isset.bucket)                     || (System.Object.Equals(Bucket,            other.Bucket))))
                && ((isset.group_col_widths           == other.isset.group_col_widths)           && ((!isset.group_col_widths)           || (TCollections.Equals(Group_col_widths, other.Group_col_widths))))
                && ((isset.key_bytewidth              == other.isset.key_bytewidth)              && ((!isset.key_bytewidth)              || (System.Object.Equals(Key_bytewidth,    other.Key_bytewidth))))
                && ((isset.col_slot_context           == other.isset.col_slot_context)           && ((!isset.col_slot_context)           || (System.Object.Equals(Col_slot_context, other.Col_slot_context))))
                && ((isset.target_groupby_indices     == other.isset.target_groupby_indices)     && ((!isset.target_groupby_indices)     || (TCollections.Equals(Target_groupby_indices, other.Target_groupby_indices))))
                && ((isset.count_distinct_descriptors == other.isset.count_distinct_descriptors) && ((!isset.count_distinct_descriptors) || (System.Object.Equals(Count_distinct_descriptors, other.Count_distinct_descriptors))))
                && ((isset.force_4byte_float          == other.isset.force_4byte_float)          && ((!isset.force_4byte_float)          || (System.Object.Equals(Force_4byte_float,          other.Force_4byte_float))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.layout)
                    hashcode = (hashcode * 397) + Layout.GetHashCode();
                if(isset.keyless)
                    hashcode = (hashcode * 397) + Keyless.GetHashCode();
                if(isset.entry_count)
                    hashcode = (hashcode * 397) + Entry_count.GetHashCode();
                if(isset.idx_target_as_key)
                    hashcode = (hashcode * 397) + Idx_target_as_key.GetHashCode();
                if(isset.min_val)
                    hashcode = (hashcode * 397) + Min_val.GetHashCode();
                if(isset.max_val)
                    hashcode = (hashcode * 397) + Max_val.GetHashCode();
                if(isset.bucket)
                    hashcode = (hashcode * 397) + Bucket.GetHashCode();
                if(isset.group_col_widths)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Group_col_widths);
                if(isset.key_bytewidth)
                    hashcode = (hashcode * 397) + Key_bytewidth.GetHashCode();
                if(isset.col_slot_context)
                    hashcode = (hashcode * 397) + Col_slot_context.GetHashCode();
                if(isset.target_groupby_indices)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Target_groupby_indices);
                if(isset.count_distinct_descriptors)
                    hashcode = (hashcode * 397) + Count_distinct_descriptors.GetHashCode();
                if(isset.force_4byte_float)
                    hashcode = (hashcode * 397) + Force_4byte_float.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TResultSetBufferDescriptor(");
            bool __first = true;
            if (isset.layout)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Layout: ");
                sb.Append(Layout);
            }
            if (isset.keyless)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Keyless: ");
                sb.Append(Keyless);
            }
            if (isset.entry_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Entry_count: ");
                sb.Append(Entry_count);
            }
            if (isset.idx_target_as_key)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Idx_target_as_key: ");
                sb.Append(Idx_target_as_key);
            }
            if (isset.min_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Min_val: ");
                sb.Append(Min_val);
            }
            if (isset.max_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Max_val: ");
                sb.Append(Max_val);
            }
            if (isset.bucket)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Bucket: ");
                sb.Append(Bucket);
            }
            if (Group_col_widths != null && isset.group_col_widths)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Group_col_widths: ");
                sb.Append(Group_col_widths);
            }
            if (isset.key_bytewidth)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Key_bytewidth: ");
                sb.Append(Key_bytewidth);
            }
            if (Col_slot_context != null && isset.col_slot_context)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_slot_context: ");
                sb.Append(Col_slot_context == null ? "<null>" : Col_slot_context.ToString());
            }
            if (Target_groupby_indices != null && isset.target_groupby_indices)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Target_groupby_indices: ");
                sb.Append(Target_groupby_indices);
            }
            if (Count_distinct_descriptors != null && isset.count_distinct_descriptors)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Count_distinct_descriptors: ");
                sb.Append(Count_distinct_descriptors);
            }
            if (isset.force_4byte_float)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Force_4byte_float: ");
                sb.Append(Force_4byte_float);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

