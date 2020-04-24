using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TTableDetails : TBase
    {
        private List<TColumnType> _row_desc;
        private long              _fragment_size;
        private long              _page_size;
        private long              _max_rows;
        private string            _view_sql;
        private long              _shard_count;
        private string            _key_metainfo;
        private bool              _is_temporary;
        private TPartitionDetail  _partition_detail;

        public List<TColumnType> Row_desc
        {
            get
            {
                return _row_desc;
            }
            set
            {
                isset.row_desc = true;
                _row_desc   = value;
            }
        }

        public long Fragment_size
        {
            get
            {
                return _fragment_size;
            }
            set
            {
                isset.fragment_size = true;
                _fragment_size   = value;
            }
        }

        public long Page_size
        {
            get
            {
                return _page_size;
            }
            set
            {
                isset.page_size = true;
                _page_size   = value;
            }
        }

        public long Max_rows
        {
            get
            {
                return _max_rows;
            }
            set
            {
                isset.max_rows = true;
                _max_rows   = value;
            }
        }

        public string View_sql
        {
            get
            {
                return _view_sql;
            }
            set
            {
                isset.view_sql = true;
                _view_sql   = value;
            }
        }

        public long Shard_count
        {
            get
            {
                return _shard_count;
            }
            set
            {
                isset.shard_count = true;
                _shard_count   = value;
            }
        }

        public string Key_metainfo
        {
            get
            {
                return _key_metainfo;
            }
            set
            {
                isset.key_metainfo = true;
                _key_metainfo   = value;
            }
        }

        public bool Is_temporary
        {
            get
            {
                return _is_temporary;
            }
            set
            {
                isset.is_temporary = true;
                _is_temporary   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TPartitionDetail"/>
        /// </summary>
        public TPartitionDetail Partition_detail
        {
            get
            {
                return _partition_detail;
            }
            set
            {
                isset.partition_detail = true;
                _partition_detail   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool row_desc;
            public bool fragment_size;
            public bool page_size;
            public bool max_rows;
            public bool view_sql;
            public bool shard_count;
            public bool key_metainfo;
            public bool is_temporary;
            public bool partition_detail;
        }

        public TTableDetails()
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
                                    TList _list80 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Row_desc = new List<TColumnType>(_list80.Count);
                                    for(int _i81 = 0; _i81 < _list80.Count; ++_i81)
                                    {
                                        TColumnType _elem82;
                                        _elem82 = new TColumnType();
                                        await _elem82.ReadAsync(iprot, cancellationToken);
                                        Row_desc.Add(_elem82);
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
                            if (field.Type == TType.I64)
                            {
                                Fragment_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Page_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I64)
                            {
                                Max_rows = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.String)
                            {
                                View_sql = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I64)
                            {
                                Shard_count = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.String)
                            {
                                Key_metainfo = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.Bool)
                            {
                                Is_temporary = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.I32)
                            {
                                Partition_detail = (TPartitionDetail)await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TTableDetails");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Row_desc != null && isset.row_desc)
                {
                    field.Name = "row_desc";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Row_desc.Count), cancellationToken);
                        foreach (TColumnType _iter83 in Row_desc)
                        {
                            await _iter83.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.fragment_size)
                {
                    field.Name = "fragment_size";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Fragment_size, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.page_size)
                {
                    field.Name = "page_size";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Page_size, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.max_rows)
                {
                    field.Name = "max_rows";
                    field.Type = TType.I64;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Max_rows, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (View_sql != null && isset.view_sql)
                {
                    field.Name = "view_sql";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(View_sql, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.shard_count)
                {
                    field.Name = "shard_count";
                    field.Type = TType.I64;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Shard_count, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Key_metainfo != null && isset.key_metainfo)
                {
                    field.Name = "key_metainfo";
                    field.Type = TType.String;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Key_metainfo, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_temporary)
                {
                    field.Name = "is_temporary";
                    field.Type = TType.Bool;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_temporary, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.partition_detail)
                {
                    field.Name = "partition_detail";
                    field.Type = TType.I32;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Partition_detail, cancellationToken);
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
            var other = that as TTableDetails;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.row_desc         == other.isset.row_desc)         && ((!isset.row_desc)         || (System.Object.Equals(Row_desc,         other.Row_desc))))
                && ((isset.fragment_size    == other.isset.fragment_size)    && ((!isset.fragment_size)    || (System.Object.Equals(Fragment_size,    other.Fragment_size))))
                && ((isset.page_size        == other.isset.page_size)        && ((!isset.page_size)        || (System.Object.Equals(Page_size,        other.Page_size))))
                && ((isset.max_rows         == other.isset.max_rows)         && ((!isset.max_rows)         || (System.Object.Equals(Max_rows,         other.Max_rows))))
                && ((isset.view_sql         == other.isset.view_sql)         && ((!isset.view_sql)         || (System.Object.Equals(View_sql,         other.View_sql))))
                && ((isset.shard_count      == other.isset.shard_count)      && ((!isset.shard_count)      || (System.Object.Equals(Shard_count,      other.Shard_count))))
                && ((isset.key_metainfo     == other.isset.key_metainfo)     && ((!isset.key_metainfo)     || (System.Object.Equals(Key_metainfo,     other.Key_metainfo))))
                && ((isset.is_temporary     == other.isset.is_temporary)     && ((!isset.is_temporary)     || (System.Object.Equals(Is_temporary,     other.Is_temporary))))
                && ((isset.partition_detail == other.isset.partition_detail) && ((!isset.partition_detail) || (System.Object.Equals(Partition_detail, other.Partition_detail))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.row_desc)
                    hashcode = (hashcode * 397) + Row_desc.GetHashCode();
                if(isset.fragment_size)
                    hashcode = (hashcode * 397) + Fragment_size.GetHashCode();
                if(isset.page_size)
                    hashcode = (hashcode * 397) + Page_size.GetHashCode();
                if(isset.max_rows)
                    hashcode = (hashcode * 397) + Max_rows.GetHashCode();
                if(isset.view_sql)
                    hashcode = (hashcode * 397) + View_sql.GetHashCode();
                if(isset.shard_count)
                    hashcode = (hashcode * 397) + Shard_count.GetHashCode();
                if(isset.key_metainfo)
                    hashcode = (hashcode * 397) + Key_metainfo.GetHashCode();
                if(isset.is_temporary)
                    hashcode = (hashcode * 397) + Is_temporary.GetHashCode();
                if(isset.partition_detail)
                    hashcode = (hashcode * 397) + Partition_detail.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TTableDetails(");
            bool __first = true;
            if (Row_desc != null && isset.row_desc)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_desc: ");
                sb.Append(Row_desc);
            }
            if (isset.fragment_size)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Fragment_size: ");
                sb.Append(Fragment_size);
            }
            if (isset.page_size)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Page_size: ");
                sb.Append(Page_size);
            }
            if (isset.max_rows)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Max_rows: ");
                sb.Append(Max_rows);
            }
            if (View_sql != null && isset.view_sql)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_sql: ");
                sb.Append(View_sql);
            }
            if (isset.shard_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Shard_count: ");
                sb.Append(Shard_count);
            }
            if (Key_metainfo != null && isset.key_metainfo)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Key_metainfo: ");
                sb.Append(Key_metainfo);
            }
            if (isset.is_temporary)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_temporary: ");
                sb.Append(Is_temporary);
            }
            if (isset.partition_detail)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Partition_detail: ");
                sb.Append(Partition_detail);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

