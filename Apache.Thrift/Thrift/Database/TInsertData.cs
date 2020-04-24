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
    public class TInsertData : TBase
    {
        private int                 _db_id;
        private int                 _table_id;
        private List<int>           _column_ids;
        private List<TDataBlockPtr> _data;
        private long                _num_rows;

        public int Db_id
        {
            get
            {
                return _db_id;
            }
            set
            {
                isset.db_id = true;
                _db_id   = value;
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

        public List<int> Column_ids
        {
            get
            {
                return _column_ids;
            }
            set
            {
                isset.column_ids = true;
                _column_ids   = value;
            }
        }

        public List<TDataBlockPtr> Data
        {
            get
            {
                return _data;
            }
            set
            {
                isset.data = true;
                _data   = value;
            }
        }

        public long Num_rows
        {
            get
            {
                return _num_rows;
            }
            set
            {
                isset.num_rows = true;
                _num_rows   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool db_id;
            public bool table_id;
            public bool column_ids;
            public bool data;
            public bool num_rows;
        }

        public TInsertData()
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
                                Db_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Table_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list100 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Column_ids = new List<int>(_list100.Count);
                                    for(int _i101 = 0; _i101 < _list100.Count; ++_i101)
                                    {
                                        int _elem102;
                                        _elem102 = await iprot.ReadI32Async(cancellationToken);
                                        Column_ids.Add(_elem102);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list103 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Data = new List<TDataBlockPtr>(_list103.Count);
                                    for(int _i104 = 0; _i104 < _list103.Count; ++_i104)
                                    {
                                        TDataBlockPtr _elem105;
                                        _elem105 = new TDataBlockPtr();
                                        await _elem105.ReadAsync(iprot, cancellationToken);
                                        Data.Add(_elem105);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I64)
                            {
                                Num_rows = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TInsertData");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.db_id)
                {
                    field.Name = "db_id";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Db_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.table_id)
                {
                    field.Name = "table_id";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Table_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Column_ids != null && isset.column_ids)
                {
                    field.Name = "column_ids";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, Column_ids.Count), cancellationToken);
                        foreach (int _iter106 in Column_ids)
                        {
                            await oprot.WriteI32Async(_iter106, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Data != null && isset.data)
                {
                    field.Name = "data";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Data.Count), cancellationToken);
                        foreach (TDataBlockPtr _iter107 in Data)
                        {
                            await _iter107.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.num_rows)
                {
                    field.Name = "num_rows";
                    field.Type = TType.I64;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Num_rows, cancellationToken);
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
            var other = that as TInsertData;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.db_id      == other.isset.db_id)      && ((!isset.db_id)      || (System.Object.Equals(Db_id,    other.Db_id))))
                && ((isset.table_id   == other.isset.table_id)   && ((!isset.table_id)   || (System.Object.Equals(Table_id, other.Table_id))))
                && ((isset.column_ids == other.isset.column_ids) && ((!isset.column_ids) || (TCollections.Equals(Column_ids, other.Column_ids))))
                && ((isset.data       == other.isset.data)       && ((!isset.data)       || (TCollections.Equals(Data,       other.Data))))
                && ((isset.num_rows   == other.isset.num_rows)   && ((!isset.num_rows)   || (System.Object.Equals(Num_rows, other.Num_rows))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.db_id)
                    hashcode = (hashcode * 397) + Db_id.GetHashCode();
                if(isset.table_id)
                    hashcode = (hashcode * 397) + Table_id.GetHashCode();
                if(isset.column_ids)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Column_ids);
                if(isset.data)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Data);
                if(isset.num_rows)
                    hashcode = (hashcode * 397) + Num_rows.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TInsertData(");
            bool __first = true;
            if (isset.db_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Db_id: ");
                sb.Append(Db_id);
            }
            if (isset.table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_id: ");
                sb.Append(Table_id);
            }
            if (Column_ids != null && isset.column_ids)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Column_ids: ");
                sb.Append(Column_ids);
            }
            if (Data != null && isset.data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Data: ");
                sb.Append(Data);
            }
            if (isset.num_rows)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_rows: ");
                sb.Append(Num_rows);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

