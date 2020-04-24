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
    public class TDatumVal : TBase
    {
        private long         _int_val;
        private double       _real_val;
        private string       _str_val;
        private List<TDatum> _arr_val;

        public long Int_val
        {
            get
            {
                return _int_val;
            }
            set
            {
                isset.int_val = true;
                _int_val   = value;
            }
        }

        public double Real_val
        {
            get
            {
                return _real_val;
            }
            set
            {
                isset.real_val = true;
                _real_val   = value;
            }
        }

        public string Str_val
        {
            get
            {
                return _str_val;
            }
            set
            {
                isset.str_val = true;
                _str_val   = value;
            }
        }

        public List<TDatum> Arr_val
        {
            get
            {
                return _arr_val;
            }
            set
            {
                isset.arr_val = true;
                _arr_val   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool int_val;
            public bool real_val;
            public bool str_val;
            public bool arr_val;
        }

        public TDatumVal()
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
                            if (field.Type == TType.I64)
                            {
                                Int_val = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Double)
                            {
                                Real_val = await iprot.ReadDoubleAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.String)
                            {
                                Str_val = await iprot.ReadStringAsync(cancellationToken);
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
                                    TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Arr_val = new List<TDatum>(_list0.Count);
                                    for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                                    {
                                        TDatum _elem2;
                                        _elem2 = new TDatum();
                                        await _elem2.ReadAsync(iprot, cancellationToken);
                                        Arr_val.Add(_elem2);
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
                var struc = new TStruct("TDatumVal");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.int_val)
                {
                    field.Name = "int_val";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Int_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.real_val)
                {
                    field.Name = "real_val";
                    field.Type = TType.Double;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteDoubleAsync(Real_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Str_val != null && isset.str_val)
                {
                    field.Name = "str_val";
                    field.Type = TType.String;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Str_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Arr_val != null && isset.arr_val)
                {
                    field.Name = "arr_val";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Arr_val.Count), cancellationToken);
                        foreach (TDatum _iter3 in Arr_val)
                        {
                            await _iter3.WriteAsync(oprot, cancellationToken);
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
            var other = that as TDatumVal;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.int_val  == other.isset.int_val)  && ((!isset.int_val)  || (System.Object.Equals(Int_val,  other.Int_val))))
                && ((isset.real_val == other.isset.real_val) && ((!isset.real_val) || (System.Object.Equals(Real_val, other.Real_val))))
                && ((isset.str_val  == other.isset.str_val)  && ((!isset.str_val)  || (System.Object.Equals(Str_val,  other.Str_val))))
                && ((isset.arr_val  == other.isset.arr_val)  && ((!isset.arr_val)  || (TCollections.Equals(Arr_val, other.Arr_val))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.int_val)
                    hashcode = (hashcode * 397) + Int_val.GetHashCode();
                if(isset.real_val)
                    hashcode = (hashcode * 397) + Real_val.GetHashCode();
                if(isset.str_val)
                    hashcode = (hashcode * 397) + Str_val.GetHashCode();
                if(isset.arr_val)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Arr_val);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDatumVal(");
            bool __first = true;
            if (isset.int_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Int_val: ");
                sb.Append(Int_val);
            }
            if (isset.real_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Real_val: ");
                sb.Append(Real_val);
            }
            if (Str_val != null && isset.str_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Str_val: ");
                sb.Append(Str_val);
            }
            if (Arr_val != null && isset.arr_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Arr_val: ");
                sb.Append(Arr_val);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

