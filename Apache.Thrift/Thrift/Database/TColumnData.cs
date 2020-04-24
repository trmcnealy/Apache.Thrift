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
    public class TColumnData : TBase
    {
        private List<long>    _int_col;
        private List<double>  _real_col;
        private List<string>  _str_col;
        private List<TColumn> _arr_col;

        public List<long> Int_col
        {
            get
            {
                return _int_col;
            }
            set
            {
                isset.int_col = true;
                _int_col   = value;
            }
        }

        public List<double> Real_col
        {
            get
            {
                return _real_col;
            }
            set
            {
                isset.real_col = true;
                _real_col   = value;
            }
        }

        public List<string> Str_col
        {
            get
            {
                return _str_col;
            }
            set
            {
                isset.str_col = true;
                _str_col   = value;
            }
        }

        public List<TColumn> Arr_col
        {
            get
            {
                return _arr_col;
            }
            set
            {
                isset.arr_col = true;
                _arr_col   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool int_col;
            public bool real_col;
            public bool str_col;
            public bool arr_col;
        }

        public TColumnData()
        {
            isset     = new Isset();
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
                                    TList _list8 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Int_col = new List<long>(_list8.Count);
                                    for(int _i9 = 0; _i9 < _list8.Count; ++_i9)
                                    {
                                        long _elem10;
                                        _elem10 = await iprot.ReadI64Async(cancellationToken);
                                        Int_col.Add(_elem10);
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
                                    TList _list11 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Real_col = new List<double>(_list11.Count);
                                    for(int _i12 = 0; _i12 < _list11.Count; ++_i12)
                                    {
                                        double _elem13;
                                        _elem13 = await iprot.ReadDoubleAsync(cancellationToken);
                                        Real_col.Add(_elem13);
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
                                    TList _list14 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Str_col = new List<string>(_list14.Count);
                                    for(int _i15 = 0; _i15 < _list14.Count; ++_i15)
                                    {
                                        string _elem16;
                                        _elem16 = await iprot.ReadStringAsync(cancellationToken);
                                        Str_col.Add(_elem16);
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
                                    TList _list17 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Arr_col = new List<TColumn>(_list17.Count);
                                    for(int _i18 = 0; _i18 < _list17.Count; ++_i18)
                                    {
                                        TColumn _elem19;
                                        _elem19 = new TColumn();
                                        await _elem19.ReadAsync(iprot, cancellationToken);
                                        Arr_col.Add(_elem19);
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
                var struc = new TStruct("TColumnData");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Int_col != null && isset.int_col)
                {
                    field.Name = "int_col";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Int_col.Count), cancellationToken);
                        foreach (long _iter20 in Int_col)
                        {
                            await oprot.WriteI64Async(_iter20, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Real_col != null && isset.real_col)
                {
                    field.Name = "real_col";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Double, Real_col.Count), cancellationToken);
                        foreach (double _iter21 in Real_col)
                        {
                            await oprot.WriteDoubleAsync(_iter21, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Str_col != null && isset.str_col)
                {
                    field.Name = "str_col";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Str_col.Count), cancellationToken);
                        foreach (string _iter22 in Str_col)
                        {
                            await oprot.WriteStringAsync(_iter22, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Arr_col != null && isset.arr_col)
                {
                    field.Name = "arr_col";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Arr_col.Count), cancellationToken);
                        foreach (TColumn _iter23 in Arr_col)
                        {
                            await _iter23.WriteAsync(oprot, cancellationToken);
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
            var other = that as TColumnData;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.int_col  == other.isset.int_col)  && ((!isset.int_col)  || (TCollections.Equals(Int_col,  other.Int_col))))
                && ((isset.real_col == other.isset.real_col) && ((!isset.real_col) || (TCollections.Equals(Real_col, other.Real_col))))
                && ((isset.str_col  == other.isset.str_col)  && ((!isset.str_col)  || (TCollections.Equals(Str_col,  other.Str_col))))
                && ((isset.arr_col  == other.isset.arr_col)  && ((!isset.arr_col)  || (TCollections.Equals(Arr_col,  other.Arr_col))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.int_col)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Int_col);
                if(isset.real_col)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Real_col);
                if(isset.str_col)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Str_col);
                if(isset.arr_col)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Arr_col);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TColumnData(");
            bool __first = true;
            if (Int_col != null && isset.int_col)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Int_col: ");
                sb.Append(Int_col);
            }
            if (Real_col != null && isset.real_col)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Real_col: ");
                sb.Append(Real_col);
            }
            if (Str_col != null && isset.str_col)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Str_col: ");
                sb.Append(Str_col);
            }
            if (Arr_col != null && isset.arr_col)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Arr_col: ");
                sb.Append(Arr_col);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

