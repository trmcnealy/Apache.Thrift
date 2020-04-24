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
    public class TDataBlockPtr : TBase
    {
        private byte[]        _fixed_len_data;
        private List<TVarLen> _var_len_data;

        public byte[] Fixed_len_data
        {
            get
            {
                return _fixed_len_data;
            }
            set
            {
                isset.fixed_len_data = true;
                _fixed_len_data   = value;
            }
        }

        public List<TVarLen> Var_len_data
        {
            get
            {
                return _var_len_data;
            }
            set
            {
                isset.var_len_data = true;
                _var_len_data   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool fixed_len_data;
            public bool var_len_data;
        }

        public TDataBlockPtr()
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
                                Fixed_len_data = await iprot.ReadBinaryAsync(cancellationToken);
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
                                    TList _list96 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Var_len_data = new List<TVarLen>(_list96.Count);
                                    for(int _i97 = 0; _i97 < _list96.Count; ++_i97)
                                    {
                                        TVarLen _elem98;
                                        _elem98 = new TVarLen();
                                        await _elem98.ReadAsync(iprot, cancellationToken);
                                        Var_len_data.Add(_elem98);
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
                var struc = new TStruct("TDataBlockPtr");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Fixed_len_data != null && isset.fixed_len_data)
                {
                    field.Name = "fixed_len_data";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Fixed_len_data, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Var_len_data != null && isset.var_len_data)
                {
                    field.Name = "var_len_data";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Var_len_data.Count), cancellationToken);
                        foreach (TVarLen _iter99 in Var_len_data)
                        {
                            await _iter99.WriteAsync(oprot, cancellationToken);
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
            var other = that as TDataBlockPtr;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.fixed_len_data == other.isset.fixed_len_data) && ((!isset.fixed_len_data) || (TCollections.Equals(Fixed_len_data, other.Fixed_len_data))))
                && ((isset.var_len_data   == other.isset.var_len_data)   && ((!isset.var_len_data)   || (TCollections.Equals(Var_len_data,   other.Var_len_data))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.fixed_len_data)
                    hashcode = (hashcode * 397) + Fixed_len_data.GetHashCode();
                if(isset.var_len_data)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Var_len_data);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDataBlockPtr(");
            bool __first = true;
            if (Fixed_len_data != null && isset.fixed_len_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Fixed_len_data: ");
                sb.Append(Fixed_len_data);
            }
            if (Var_len_data != null && isset.var_len_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Var_len_data: ");
                sb.Append(Var_len_data);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

