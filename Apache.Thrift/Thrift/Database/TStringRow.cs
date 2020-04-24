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
    public class TStringRow : TBase
    {
        private List<TStringValue> _cols;

        public List<TStringValue> Cols
        {
            get
            {
                return _cols;
            }
            set
            {
                isset.cols = true;
                _cols   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool cols;
        }

        public TStringRow()
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
                                    Cols = new List<TStringValue>(_list28.Count);
                                    for(int _i29 = 0; _i29 < _list28.Count; ++_i29)
                                    {
                                        TStringValue _elem30;
                                        _elem30 = new TStringValue();
                                        await _elem30.ReadAsync(iprot, cancellationToken);
                                        Cols.Add(_elem30);
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
                var struc = new TStruct("TStringRow");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Cols != null && isset.cols)
                {
                    field.Name = "cols";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Cols.Count), cancellationToken);
                        foreach (TStringValue _iter31 in Cols)
                        {
                            await _iter31.WriteAsync(oprot, cancellationToken);
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
            var other = that as TStringRow;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.cols == other.isset.cols) && ((!isset.cols) || (TCollections.Equals(Cols, other.Cols))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.cols)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Cols);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TStringRow(");
            bool __first = true;
            if (Cols != null && isset.cols)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Cols: ");
                sb.Append(Cols);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

