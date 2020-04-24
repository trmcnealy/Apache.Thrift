using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDBInfo : TBase
    {
        private string _db_name;
        private string _db_owner;

        public string Db_name
        {
            get
            {
                return _db_name;
            }
            set
            {
                isset.db_name = true;
                _db_name   = value;
            }
        }

        public string Db_owner
        {
            get
            {
                return _db_owner;
            }
            set
            {
                isset.db_owner = true;
                _db_owner   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool db_name;
            public bool db_owner;
        }

        public TDBInfo()
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
                                Db_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Db_owner = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TDBInfo");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Db_name != null && isset.db_name)
                {
                    field.Name = "db_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Db_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Db_owner != null && isset.db_owner)
                {
                    field.Name = "db_owner";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Db_owner, cancellationToken);
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
            var other = that as TDBInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.db_name  == other.isset.db_name)  && ((!isset.db_name)  || (System.Object.Equals(Db_name,  other.Db_name))))
                && ((isset.db_owner == other.isset.db_owner) && ((!isset.db_owner) || (System.Object.Equals(Db_owner, other.Db_owner))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.db_name)
                    hashcode = (hashcode * 397) + Db_name.GetHashCode();
                if(isset.db_owner)
                    hashcode = (hashcode * 397) + Db_owner.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDBInfo(");
            bool __first = true;
            if (Db_name != null && isset.db_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Db_name: ");
                sb.Append(Db_name);
            }
            if (Db_owner != null && isset.db_owner)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Db_owner: ");
                sb.Append(Db_owner);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

