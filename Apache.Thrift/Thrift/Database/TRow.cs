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
    public class TRow : TBase
    {
        private List<TDatum> _cols;

        public List<TDatum> Cols
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

        public TRow()
        {
            isset = new Isset();
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
                                    TList _list4 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Cols = new List<TDatum>(_list4.Count);
                                    for(int _i5 = 0; _i5 < _list4.Count; ++_i5)
                                    {
                                        TDatum _elem6;
                                        _elem6 = new TDatum();
                                        await _elem6.ReadAsync(iprot, cancellationToken);
                                        Cols.Add(_elem6);
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
                var struc = new TStruct("TRow");
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
                        foreach (TDatum _iter7 in Cols)
                        {
                            await _iter7.WriteAsync(oprot, cancellationToken);
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
            var other = that as TRow;
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
            var  sb      = new StringBuilder("TRow(");
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

