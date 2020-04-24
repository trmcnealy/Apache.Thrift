using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TSessionInfo : TBase
    {
        private string _user;
        private string _database;
        private long   _start_time;
        private bool   _is_super;

        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                isset.user = true;
                _user   = value;
            }
        }

        public string Database
        {
            get
            {
                return _database;
            }
            set
            {
                isset.database = true;
                _database   = value;
            }
        }

        public long Start_time
        {
            get
            {
                return _start_time;
            }
            set
            {
                isset.start_time = true;
                _start_time   = value;
            }
        }

        public bool Is_super
        {
            get
            {
                return _is_super;
            }
            set
            {
                isset.is_super = true;
                _is_super   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool user;
            public bool database;
            public bool start_time;
            public bool is_super;
        }

        public TSessionInfo()
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
                                User = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Database = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Start_time = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Is_super = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TSessionInfo");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (User != null && isset.user)
                {
                    field.Name = "user";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(User, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Database != null && isset.database)
                {
                    field.Name = "database";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Database, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.start_time)
                {
                    field.Name = "start_time";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Start_time, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_super)
                {
                    field.Name = "is_super";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_super, cancellationToken);
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
            var other = that as TSessionInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.user       == other.isset.user)       && ((!isset.user)       || (System.Object.Equals(User,       other.User))))
                && ((isset.database   == other.isset.database)   && ((!isset.database)   || (System.Object.Equals(Database,   other.Database))))
                && ((isset.start_time == other.isset.start_time) && ((!isset.start_time) || (System.Object.Equals(Start_time, other.Start_time))))
                && ((isset.is_super   == other.isset.is_super)   && ((!isset.is_super)   || (System.Object.Equals(Is_super,   other.Is_super))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.user)
                    hashcode = (hashcode * 397) + User.GetHashCode();
                if(isset.database)
                    hashcode = (hashcode * 397) + Database.GetHashCode();
                if(isset.start_time)
                    hashcode = (hashcode * 397) + Start_time.GetHashCode();
                if(isset.is_super)
                    hashcode = (hashcode * 397) + Is_super.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TSessionInfo(");
            bool __first = true;
            if (User != null && isset.user)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("User: ");
                sb.Append(User);
            }
            if (Database != null && isset.database)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Database: ");
                sb.Append(Database);
            }
            if (isset.start_time)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Start_time: ");
                sb.Append(Start_time);
            }
            if (isset.is_super)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_super: ");
                sb.Append(Is_super);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

