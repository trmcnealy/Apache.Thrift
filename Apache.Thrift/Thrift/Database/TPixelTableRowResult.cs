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
    public class TPixelTableRowResult : TBase
    {
        private TPixel     _pixel;
        private string     _vega_table_name;
        private List<long> _table_id;
        private List<long> _row_id;
        private TRowSet    _row_set;
        private string     _nonce;

        public TPixel Pixel
        {
            get
            {
                return _pixel;
            }
            set
            {
                isset.pixel = true;
                _pixel   = value;
            }
        }

        public string Vega_table_name
        {
            get
            {
                return _vega_table_name;
            }
            set
            {
                isset.vega_table_name = true;
                _vega_table_name   = value;
            }
        }

        public List<long> Table_id
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

        public List<long> Row_id
        {
            get
            {
                return _row_id;
            }
            set
            {
                isset.row_id = true;
                _row_id   = value;
            }
        }

        public TRowSet Row_set
        {
            get
            {
                return _row_set;
            }
            set
            {
                isset.row_set = true;
                _row_set   = value;
            }
        }

        public string Nonce
        {
            get
            {
                return _nonce;
            }
            set
            {
                isset.nonce = true;
                _nonce   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool pixel;
            public bool vega_table_name;
            public bool table_id;
            public bool row_id;
            public bool row_set;
            public bool nonce;
        }

        public TPixelTableRowResult()
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
                            if (field.Type == TType.Struct)
                            {
                                Pixel = new TPixel();
                                await Pixel.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Vega_table_name = await iprot.ReadStringAsync(cancellationToken);
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
                                    TList _list48 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Table_id = new List<long>(_list48.Count);
                                    for(int _i49 = 0; _i49 < _list48.Count; ++_i49)
                                    {
                                        long _elem50;
                                        _elem50 = await iprot.ReadI64Async(cancellationToken);
                                        Table_id.Add(_elem50);
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
                                    TList _list51 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Row_id = new List<long>(_list51.Count);
                                    for(int _i52 = 0; _i52 < _list51.Count; ++_i52)
                                    {
                                        long _elem53;
                                        _elem53 = await iprot.ReadI64Async(cancellationToken);
                                        Row_id.Add(_elem53);
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
                            if (field.Type == TType.Struct)
                            {
                                Row_set = new TRowSet();
                                await Row_set.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.String)
                            {
                                Nonce = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TPixelTableRowResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Pixel != null && isset.pixel)
                {
                    field.Name = "pixel";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Pixel.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Vega_table_name != null && isset.vega_table_name)
                {
                    field.Name = "vega_table_name";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Vega_table_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Table_id != null && isset.table_id)
                {
                    field.Name = "table_id";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Table_id.Count), cancellationToken);
                        foreach (long _iter54 in Table_id)
                        {
                            await oprot.WriteI64Async(_iter54, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Row_id != null && isset.row_id)
                {
                    field.Name = "row_id";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Row_id.Count), cancellationToken);
                        foreach (long _iter55 in Row_id)
                        {
                            await oprot.WriteI64Async(_iter55, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Row_set != null && isset.row_set)
                {
                    field.Name = "row_set";
                    field.Type = TType.Struct;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Row_set.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Nonce != null && isset.nonce)
                {
                    field.Name = "nonce";
                    field.Type = TType.String;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Nonce, cancellationToken);
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
            var other = that as TPixelTableRowResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.pixel           == other.isset.pixel)           && ((!isset.pixel)           || (System.Object.Equals(Pixel,           other.Pixel))))
                && ((isset.vega_table_name == other.isset.vega_table_name) && ((!isset.vega_table_name) || (System.Object.Equals(Vega_table_name, other.Vega_table_name))))
                && ((isset.table_id        == other.isset.table_id)        && ((!isset.table_id)        || (TCollections.Equals(Table_id, other.Table_id))))
                && ((isset.row_id          == other.isset.row_id)          && ((!isset.row_id)          || (TCollections.Equals(Row_id,   other.Row_id))))
                && ((isset.row_set         == other.isset.row_set)         && ((!isset.row_set)         || (System.Object.Equals(Row_set, other.Row_set))))
                && ((isset.nonce           == other.isset.nonce)           && ((!isset.nonce)           || (System.Object.Equals(Nonce,   other.Nonce))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.pixel)
                    hashcode = (hashcode * 397) + Pixel.GetHashCode();
                if(isset.vega_table_name)
                    hashcode = (hashcode * 397) + Vega_table_name.GetHashCode();
                if(isset.table_id)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Table_id);
                if(isset.row_id)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Row_id);
                if(isset.row_set)
                    hashcode = (hashcode * 397) + Row_set.GetHashCode();
                if(isset.nonce)
                    hashcode = (hashcode * 397) + Nonce.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TPixelTableRowResult(");
            bool __first = true;
            if (Pixel != null && isset.pixel)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Pixel: ");
                sb.Append(Pixel == null ? "<null>" : Pixel.ToString());
            }
            if (Vega_table_name != null && isset.vega_table_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Vega_table_name: ");
                sb.Append(Vega_table_name);
            }
            if (Table_id != null && isset.table_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_id: ");
                sb.Append(Table_id);
            }
            if (Row_id != null && isset.row_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_id: ");
                sb.Append(Row_id);
            }
            if (Row_set != null && isset.row_set)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_set: ");
                sb.Append(Row_set == null ? "<null>" : Row_set.ToString());
            }
            if (Nonce != null && isset.nonce)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Nonce: ");
                sb.Append(Nonce);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

