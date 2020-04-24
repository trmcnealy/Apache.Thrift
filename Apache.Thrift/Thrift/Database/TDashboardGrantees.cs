using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDashboardGrantees : TBase
    {
        private string                _name;
        private bool                  _is_user;
        private TDashboardPermissions _permissions;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                isset.name = true;
                _name   = value;
            }
        }

        public bool Is_user
        {
            get
            {
                return _is_user;
            }
            set
            {
                isset.is_user = true;
                _is_user   = value;
            }
        }

        public TDashboardPermissions Permissions
        {
            get
            {
                return _permissions;
            }
            set
            {
                isset.permissions = true;
                _permissions   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool name;
            public bool is_user;
            public bool permissions;
        }

        public TDashboardGrantees()
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
                                Name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Is_user = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Struct)
                            {
                                Permissions = new TDashboardPermissions();
                                await Permissions.ReadAsync(iprot, cancellationToken);
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
                var struc = new TStruct("TDashboardGrantees");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Name != null && isset.name)
                {
                    field.Name = "name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_user)
                {
                    field.Name = "is_user";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_user, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Permissions != null && isset.permissions)
                {
                    field.Name = "permissions";
                    field.Type = TType.Struct;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Permissions.WriteAsync(oprot, cancellationToken);
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
            var other = that as TDashboardGrantees;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.name        == other.isset.name)        && ((!isset.name)        || (System.Object.Equals(Name,        other.Name))))
                && ((isset.is_user     == other.isset.is_user)     && ((!isset.is_user)     || (System.Object.Equals(Is_user,     other.Is_user))))
                && ((isset.permissions == other.isset.permissions) && ((!isset.permissions) || (System.Object.Equals(Permissions, other.Permissions))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.name)
                    hashcode = (hashcode * 397) + Name.GetHashCode();
                if(isset.is_user)
                    hashcode = (hashcode * 397) + Is_user.GetHashCode();
                if(isset.permissions)
                    hashcode = (hashcode * 397) + Permissions.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDashboardGrantees(");
            bool __first = true;
            if (Name != null && isset.name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Name: ");
                sb.Append(Name);
            }
            if (isset.is_user)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_user: ");
                sb.Append(Is_user);
            }
            if (Permissions != null && isset.permissions)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Permissions: ");
                sb.Append(Permissions == null ? "<null>" : Permissions.ToString());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

