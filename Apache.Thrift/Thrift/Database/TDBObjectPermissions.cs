using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDBObjectPermissions : TBase
    {
        private TDatabasePermissions  _database_permissions_;
        private TTablePermissions     _table_permissions_;
        private TDashboardPermissions _dashboard_permissions_;
        private TViewPermissions      _view_permissions_;

        public TDatabasePermissions Database_permissions_
        {
            get
            {
                return _database_permissions_;
            }
            set
            {
                isset.database_permissions_ = true;
                _database_permissions_   = value;
            }
        }

        public TTablePermissions Table_permissions_
        {
            get
            {
                return _table_permissions_;
            }
            set
            {
                isset.table_permissions_ = true;
                _table_permissions_   = value;
            }
        }

        public TDashboardPermissions Dashboard_permissions_
        {
            get
            {
                return _dashboard_permissions_;
            }
            set
            {
                isset.dashboard_permissions_ = true;
                _dashboard_permissions_   = value;
            }
        }

        public TViewPermissions View_permissions_
        {
            get
            {
                return _view_permissions_;
            }
            set
            {
                isset.view_permissions_ = true;
                _view_permissions_   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool database_permissions_;
            public bool table_permissions_;
            public bool dashboard_permissions_;
            public bool view_permissions_;
        }

        public TDBObjectPermissions()
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
                                Database_permissions_ = new TDatabasePermissions();
                                await Database_permissions_.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Struct)
                            {
                                Table_permissions_ = new TTablePermissions();
                                await Table_permissions_.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Struct)
                            {
                                Dashboard_permissions_ = new TDashboardPermissions();
                                await Dashboard_permissions_.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Struct)
                            {
                                View_permissions_ = new TViewPermissions();
                                await View_permissions_.ReadAsync(iprot, cancellationToken);
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
                var struc = new TStruct("TDBObjectPermissions");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Database_permissions_ != null && isset.database_permissions_)
                {
                    field.Name = "database_permissions_";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Database_permissions_.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Table_permissions_ != null && isset.table_permissions_)
                {
                    field.Name = "table_permissions_";
                    field.Type = TType.Struct;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Table_permissions_.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Dashboard_permissions_ != null && isset.dashboard_permissions_)
                {
                    field.Name = "dashboard_permissions_";
                    field.Type = TType.Struct;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Dashboard_permissions_.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (View_permissions_ != null && isset.view_permissions_)
                {
                    field.Name = "view_permissions_";
                    field.Type = TType.Struct;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await View_permissions_.WriteAsync(oprot, cancellationToken);
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
            var other = that as TDBObjectPermissions;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.database_permissions_  == other.isset.database_permissions_)  && ((!isset.database_permissions_)  || (System.Object.Equals(Database_permissions_,  other.Database_permissions_))))
                && ((isset.table_permissions_     == other.isset.table_permissions_)     && ((!isset.table_permissions_)     || (System.Object.Equals(Table_permissions_,     other.Table_permissions_))))
                && ((isset.dashboard_permissions_ == other.isset.dashboard_permissions_) && ((!isset.dashboard_permissions_) || (System.Object.Equals(Dashboard_permissions_, other.Dashboard_permissions_))))
                && ((isset.view_permissions_      == other.isset.view_permissions_)      && ((!isset.view_permissions_)      || (System.Object.Equals(View_permissions_,      other.View_permissions_))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.database_permissions_)
                    hashcode = (hashcode * 397) + Database_permissions_.GetHashCode();
                if(isset.table_permissions_)
                    hashcode = (hashcode * 397) + Table_permissions_.GetHashCode();
                if(isset.dashboard_permissions_)
                    hashcode = (hashcode * 397) + Dashboard_permissions_.GetHashCode();
                if(isset.view_permissions_)
                    hashcode = (hashcode * 397) + View_permissions_.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDBObjectPermissions(");
            bool __first = true;
            if (Database_permissions_ != null && isset.database_permissions_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Database_permissions_: ");
                sb.Append(Database_permissions_ == null ? "<null>" : Database_permissions_.ToString());
            }
            if (Table_permissions_ != null && isset.table_permissions_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_permissions_: ");
                sb.Append(Table_permissions_ == null ? "<null>" : Table_permissions_.ToString());
            }
            if (Dashboard_permissions_ != null && isset.dashboard_permissions_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_permissions_: ");
                sb.Append(Dashboard_permissions_ == null ? "<null>" : Dashboard_permissions_.ToString());
            }
            if (View_permissions_ != null && isset.view_permissions_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_permissions_: ");
                sb.Append(View_permissions_ == null ? "<null>" : View_permissions_.ToString());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

