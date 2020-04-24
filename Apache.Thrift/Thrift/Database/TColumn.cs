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
    public class TColumn : TBase
    {
        private TColumnData _data;
        private List<bool>  _nulls;

        public TColumnData Data
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

        public List<bool> Nulls
        {
            get
            {
                return _nulls;
            }
            set
            {
                isset.nulls = true;
                _nulls   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool data;
            public bool nulls;
        }

        public TColumn()
        { 
            isset  = new Isset();
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
                                Data = new TColumnData();
                                await Data.ReadAsync(iprot, cancellationToken);
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
                                    TList _list24 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Nulls = new List<bool>(_list24.Count);
                                    for(int _i25 = 0; _i25 < _list24.Count; ++_i25)
                                    {
                                        bool _elem26;
                                        _elem26 = await iprot.ReadBoolAsync(cancellationToken);
                                        Nulls.Add(_elem26);
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
                var struc = new TStruct("TColumn");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Data != null && isset.data)
                {
                    field.Name = "data";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Data.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Nulls != null && isset.nulls)
                {
                    field.Name = "nulls";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Bool, Nulls.Count), cancellationToken);
                        foreach (bool _iter27 in Nulls)
                        {
                            await oprot.WriteBoolAsync(_iter27, cancellationToken);
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
            var other = that as TColumn;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.data  == other.isset.data)  && ((!isset.data)  || (System.Object.Equals(Data, other.Data))))
                && ((isset.nulls == other.isset.nulls) && ((!isset.nulls) || (TCollections.Equals(Nulls, other.Nulls))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.data)
                    hashcode = (hashcode * 397) + Data.GetHashCode();
                if(isset.nulls)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Nulls);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TColumn(");
            bool __first = true;
            if (Data != null && isset.data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Data: ");
                sb.Append(Data == null ? "<null>" : Data.ToString());
            }
            if (Nulls != null && isset.nulls)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Nulls: ");
                sb.Append(Nulls);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

