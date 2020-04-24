using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDetectResult : TBase
    {
        private TRowSet     _row_set;
        private TCopyParams _copy_params;

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

        public TCopyParams Copy_params
        {
            get
            {
                return _copy_params;
            }
            set
            {
                isset.copy_params = true;
                _copy_params   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool row_set;
            public bool copy_params;
        }

        public TDetectResult()
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
                                Row_set = new TRowSet();
                                await Row_set.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Struct)
                            {
                                Copy_params = new TCopyParams();
                                await Copy_params.ReadAsync(iprot, cancellationToken);
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
                var struc = new TStruct("TDetectResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Row_set != null && isset.row_set)
                {
                    field.Name = "row_set";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Row_set.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Copy_params != null && isset.copy_params)
                {
                    field.Name = "copy_params";
                    field.Type = TType.Struct;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Copy_params.WriteAsync(oprot, cancellationToken);
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
            var other = that as TDetectResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.row_set     == other.isset.row_set)     && ((!isset.row_set)     || (System.Object.Equals(Row_set,     other.Row_set))))
                && ((isset.copy_params == other.isset.copy_params) && ((!isset.copy_params) || (System.Object.Equals(Copy_params, other.Copy_params))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.row_set)
                    hashcode = (hashcode * 397) + Row_set.GetHashCode();
                if(isset.copy_params)
                    hashcode = (hashcode * 397) + Copy_params.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDetectResult(");
            bool __first = true;
            if (Row_set != null && isset.row_set)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_set: ");
                sb.Append(Row_set == null ? "<null>" : Row_set.ToString());
            }
            if (Copy_params != null && isset.copy_params)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Copy_params: ");
                sb.Append(Copy_params == null ? "<null>" : Copy_params.ToString());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

