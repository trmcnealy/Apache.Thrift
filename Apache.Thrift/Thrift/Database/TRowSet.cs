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
    public class TRowSet : TBase
    {
        private List<TColumnType> _row_desc;
        private List<TRow>        _rows;
        private List<TColumn>     _columns;
        private bool              _is_columnar;

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

        public List<TRow> Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                isset.rows = true;
                _rows   = value;
            }
        }

        public List<TColumn> Columns
        {
            get
            {
                return _columns;
            }
            set
            {
                isset.columns = true;
                _columns   = value;
            }
        }

        public bool Is_columnar
        {
            get
            {
                return _is_columnar;
            }
            set
            {
                isset.is_columnar = true;
                _is_columnar   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool row_desc;
            public bool rows;
            public bool columns;
            public bool is_columnar;
        }

        public TRowSet()
        {
            isset= new Isset();
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
                                    TList _list36 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Row_desc = new List<TColumnType>(_list36.Count);
                                    for(int _i37 = 0; _i37 < _list36.Count; ++_i37)
                                    {
                                        TColumnType _elem38;
                                        _elem38 = new TColumnType();
                                        await _elem38.ReadAsync(iprot, cancellationToken);
                                        Row_desc.Add(_elem38);
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
                                    TList _list39 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Rows = new List<TRow>(_list39.Count);
                                    for(int _i40 = 0; _i40 < _list39.Count; ++_i40)
                                    {
                                        TRow _elem41;
                                        _elem41 = new TRow();
                                        await _elem41.ReadAsync(iprot, cancellationToken);
                                        Rows.Add(_elem41);
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
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list42 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Columns = new List<TColumn>(_list42.Count);
                                    for(int _i43 = 0; _i43 < _list42.Count; ++_i43)
                                    {
                                        TColumn _elem44;
                                        _elem44 = new TColumn();
                                        await _elem44.ReadAsync(iprot, cancellationToken);
                                        Columns.Add(_elem44);
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
                            if (field.Type == TType.Bool)
                            {
                                Is_columnar = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TRowSet");
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
                        foreach (TColumnType _iter45 in Row_desc)
                        {
                            await _iter45.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Rows != null && isset.rows)
                {
                    field.Name = "rows";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Rows.Count), cancellationToken);
                        foreach (TRow _iter46 in Rows)
                        {
                            await _iter46.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Columns != null && isset.columns)
                {
                    field.Name = "columns";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
                        foreach (TColumn _iter47 in Columns)
                        {
                            await _iter47.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_columnar)
                {
                    field.Name = "is_columnar";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_columnar, cancellationToken);
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
            var other = that as TRowSet;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.row_desc    == other.isset.row_desc)    && ((!isset.row_desc)    || (System.Object.Equals(Row_desc, other.Row_desc))))
                && ((isset.rows        == other.isset.rows)        && ((!isset.rows)        || (TCollections.Equals(Rows,    other.Rows))))
                && ((isset.columns     == other.isset.columns)     && ((!isset.columns)     || (TCollections.Equals(Columns, other.Columns))))
                && ((isset.is_columnar == other.isset.is_columnar) && ((!isset.is_columnar) || (System.Object.Equals(Is_columnar, other.Is_columnar))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.row_desc)
                    hashcode = (hashcode * 397) + Row_desc.GetHashCode();
                if(isset.rows)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Rows);
                if(isset.columns)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
                if(isset.is_columnar)
                    hashcode = (hashcode * 397) + Is_columnar.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRowSet(");
            bool __first = true;
            if (Row_desc != null && isset.row_desc)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_desc: ");
                sb.Append(Row_desc);
            }
            if (Rows != null && isset.rows)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Rows: ");
                sb.Append(Rows);
            }
            if (Columns != null && isset.columns)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Columns: ");
                sb.Append(Columns);
            }
            if (isset.is_columnar)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_columnar: ");
                sb.Append(Is_columnar);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

