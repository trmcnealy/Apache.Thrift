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
    public class TTableMeta : TBase
    {
        private string          _table_name;
        private long            _num_cols;
        private bool            _is_view;
        private bool            _is_replicated;
        private long            _shard_count;
        private long            _max_rows;
        private long            _table_id;
        private long            _max_table_id;
        private List<TTypeInfo> _col_types;
        private List<string>    _col_names;

        public string Table_name
        {
            get
            {
                return _table_name;
            }
            set
            {
                isset.table_name = true;
                _table_name   = value;
            }
        }

        public long Num_cols
        {
            get
            {
                return _num_cols;
            }
            set
            {
                isset.num_cols = true;
                _num_cols   = value;
            }
        }

        public bool Is_view
        {
            get
            {
                return _is_view;
            }
            set
            {
                isset.is_view = true;
                _is_view   = value;
            }
        }

        public bool Is_replicated
        {
            get
            {
                return _is_replicated;
            }
            set
            {
                isset.is_replicated = true;
                _is_replicated   = value;
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

        public long Table_id
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

        public long Max_table_id
        {
            get
            {
                return _max_table_id;
            }
            set
            {
                isset.max_table_id = true;
                _max_table_id   = value;
            }
        }

        public List<TTypeInfo> Col_types
        {
            get
            {
                return _col_types;
            }
            set
            {
                isset.col_types = true;
                _col_types   = value;
            }
        }

        public List<string> Col_names
        {
            get
            {
                return _col_names;
            }
            set
            {
                isset.col_names = true;
                _col_names   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool table_name;
            public bool num_cols;
            public bool is_view;
            public bool is_replicated;
            public bool shard_count;
            public bool max_rows;
            public bool table_id;
            public bool max_table_id;
            public bool col_types;
            public bool col_names;
        }

        public TTableMeta()
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
                            if (field.Type == TType.String)
                            {
                                Table_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Num_cols = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Is_view = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Bool)
                            {
                                Is_replicated = await iprot.ReadBoolAsync(cancellationToken);
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
                            if (field.Type == TType.I64)
                            {
                                Max_rows = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.I64)
                            {
                                Table_id = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.I64)
                            {
                                Max_table_id = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 10:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list72 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Col_types = new List<TTypeInfo>(_list72.Count);
                                    for(int _i73 = 0; _i73 < _list72.Count; ++_i73)
                                    {
                                        TTypeInfo _elem74;
                                        _elem74 = new TTypeInfo();
                                        await _elem74.ReadAsync(iprot, cancellationToken);
                                        Col_types.Add(_elem74);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
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
                                    TList _list75 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Col_names = new List<string>(_list75.Count);
                                    for(int _i76 = 0; _i76 < _list75.Count; ++_i76)
                                    {
                                        string _elem77;
                                        _elem77 = await iprot.ReadStringAsync(cancellationToken);
                                        Col_names.Add(_elem77);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
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
                var struc = new TStruct("TTableMeta");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Table_name != null && isset.table_name)
                {
                    field.Name = "table_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Table_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.num_cols)
                {
                    field.Name = "num_cols";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Num_cols, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_view)
                {
                    field.Name = "is_view";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_view, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_replicated)
                {
                    field.Name = "is_replicated";
                    field.Type = TType.Bool;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_replicated, cancellationToken);
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
                if (isset.max_rows)
                {
                    field.Name = "max_rows";
                    field.Type = TType.I64;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Max_rows, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.table_id)
                {
                    field.Name = "table_id";
                    field.Type = TType.I64;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Table_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.max_table_id)
                {
                    field.Name = "max_table_id";
                    field.Type = TType.I64;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Max_table_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Col_types != null && isset.col_types)
                {
                    field.Name = "col_types";
                    field.Type = TType.List;
                    field.ID   = 10;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Col_types.Count), cancellationToken);
                        foreach (TTypeInfo _iter78 in Col_types)
                        {
                            await _iter78.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Col_names != null && isset.col_names)
                {
                    field.Name = "col_names";
                    field.Type = TType.List;
                    field.ID   = 11;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Col_names.Count), cancellationToken);
                        foreach (string _iter79 in Col_names)
                        {
                            await oprot.WriteStringAsync(_iter79, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
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
            var other = that as TTableMeta;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.table_name    == other.isset.table_name)    && ((!isset.table_name)    || (System.Object.Equals(Table_name,    other.Table_name))))
                && ((isset.num_cols      == other.isset.num_cols)      && ((!isset.num_cols)      || (System.Object.Equals(Num_cols,      other.Num_cols))))
                && ((isset.is_view       == other.isset.is_view)       && ((!isset.is_view)       || (System.Object.Equals(Is_view,       other.Is_view))))
                && ((isset.is_replicated == other.isset.is_replicated) && ((!isset.is_replicated) || (System.Object.Equals(Is_replicated, other.Is_replicated))))
                && ((isset.shard_count   == other.isset.shard_count)   && ((!isset.shard_count)   || (System.Object.Equals(Shard_count,   other.Shard_count))))
                && ((isset.max_rows      == other.isset.max_rows)      && ((!isset.max_rows)      || (System.Object.Equals(Max_rows,      other.Max_rows))))
                && ((isset.table_id      == other.isset.table_id)      && ((!isset.table_id)      || (System.Object.Equals(Table_id,      other.Table_id))))
                && ((isset.max_table_id  == other.isset.max_table_id)  && ((!isset.max_table_id)  || (System.Object.Equals(Max_table_id,  other.Max_table_id))))
                && ((isset.col_types     == other.isset.col_types)     && ((!isset.col_types)     || (TCollections.Equals(Col_types, other.Col_types))))
                && ((isset.col_names     == other.isset.col_names)     && ((!isset.col_names)     || (TCollections.Equals(Col_names, other.Col_names))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.table_name)
                    hashcode = (hashcode * 397) + Table_name.GetHashCode();
                if(isset.num_cols)
                    hashcode = (hashcode * 397) + Num_cols.GetHashCode();
                if(isset.is_view)
                    hashcode = (hashcode * 397) + Is_view.GetHashCode();
                if(isset.is_replicated)
                    hashcode = (hashcode * 397) + Is_replicated.GetHashCode();
                if(isset.shard_count)
                    hashcode = (hashcode * 397) + Shard_count.GetHashCode();
                if(isset.max_rows)
                    hashcode = (hashcode * 397) + Max_rows.GetHashCode();
                if(isset.table_id)
                    hashcode = (hashcode * 397) + Table_id.GetHashCode();
                if(isset.max_table_id)
                    hashcode = (hashcode * 397) + Max_table_id.GetHashCode();
                if(isset.col_types)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Col_types);
                if(isset.col_names)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Col_names);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TTableMeta(");
            bool __first = true;
            if (Table_name != null && isset.table_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_name: ");
                sb.Append(Table_name);
            }
            if (isset.num_cols)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_cols: ");
                sb.Append(Num_cols);
            }
            if (isset.is_view)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_view: ");
                sb.Append(Is_view);
            }
            if (isset.is_replicated)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_replicated: ");
                sb.Append(Is_replicated);
            }
            if (isset.shard_count)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Shard_count: ");
                sb.Append(Shard_count);
            }
            if (isset.max_rows)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Max_rows: ");
                sb.Append(Max_rows);
            }
            if (isset.table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_id: ");
                sb.Append(Table_id);
            }
            if (isset.max_table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Max_table_id: ");
                sb.Append(Max_table_id);
            }
            if (Col_types != null && isset.col_types)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_types: ");
                sb.Append(Col_types);
            }
            if (Col_names != null && isset.col_names)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_names: ");
                sb.Append(Col_names);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

