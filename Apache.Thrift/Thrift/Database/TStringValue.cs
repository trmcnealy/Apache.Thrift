using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TStringValue : TBase
    {
        private string _str_val;
        private bool   _is_null;

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

        public bool Is_null
        {
            get
            {
                return _is_null;
            }
            set
            {
                isset.is_null = true;
                _is_null   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool str_val;
            public bool is_null;
        }

        public TStringValue()
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
                                Str_val = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Is_null = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TStringValue");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Str_val != null && isset.str_val)
                {
                    field.Name = "str_val";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Str_val, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_null)
                {
                    field.Name = "is_null";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_null, cancellationToken);
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
            var other = that as TStringValue;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.str_val == other.isset.str_val) && ((!isset.str_val) || (System.Object.Equals(Str_val, other.Str_val))))
                && ((isset.is_null == other.isset.is_null) && ((!isset.is_null) || (System.Object.Equals(Is_null, other.Is_null))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.str_val)
                    hashcode = (hashcode * 397) + Str_val.GetHashCode();
                if(isset.is_null)
                    hashcode = (hashcode * 397) + Is_null.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TStringValue(");
            bool __first = true;
            if (Str_val != null && isset.str_val)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Str_val: ");
                sb.Append(Str_val);
            }
            if (isset.is_null)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_null: ");
                sb.Append(Is_null);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

