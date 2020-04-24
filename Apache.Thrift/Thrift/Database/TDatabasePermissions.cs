using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDatabasePermissions : TBase
    {
        private bool _create_;
        private bool _delete_;
        private bool _view_sql_editor_;
        private bool _access_;

        public bool Create_
        {
            get
            {
                return _create_;
            }
            set
            {
                isset.create_ = true;
                _create_   = value;
            }
        }

        public bool Delete_
        {
            get
            {
                return _delete_;
            }
            set
            {
                isset.delete_ = true;
                _delete_   = value;
            }
        }

        public bool View_sql_editor_
        {
            get
            {
                return _view_sql_editor_;
            }
            set
            {
                isset.view_sql_editor_ = true;
                _view_sql_editor_   = value;
            }
        }

        public bool Access_
        {
            get
            {
                return _access_;
            }
            set
            {
                isset.access_ = true;
                _access_   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool create_;
            public bool delete_;
            public bool view_sql_editor_;
            public bool access_;
        }

        public TDatabasePermissions()
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
                            if (field.Type == TType.Bool)
                            {
                                Create_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Delete_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Bool)
                            {
                                View_sql_editor_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Access_ = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TDatabasePermissions");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.create_)
                {
                    field.Name = "create_";
                    field.Type = TType.Bool;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Create_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.delete_)
                {
                    field.Name = "delete_";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Delete_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.view_sql_editor_)
                {
                    field.Name = "view_sql_editor_";
                    field.Type = TType.Bool;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(View_sql_editor_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.access_)
                {
                    field.Name = "access_";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Access_, cancellationToken);
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
            var other = that as TDatabasePermissions;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.create_          == other.isset.create_)          && ((!isset.create_)          || (System.Object.Equals(Create_,          other.Create_))))
                && ((isset.delete_          == other.isset.delete_)          && ((!isset.delete_)          || (System.Object.Equals(Delete_,          other.Delete_))))
                && ((isset.view_sql_editor_ == other.isset.view_sql_editor_) && ((!isset.view_sql_editor_) || (System.Object.Equals(View_sql_editor_, other.View_sql_editor_))))
                && ((isset.access_          == other.isset.access_)          && ((!isset.access_)          || (System.Object.Equals(Access_,          other.Access_))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.create_)
                    hashcode = (hashcode * 397) + Create_.GetHashCode();
                if(isset.delete_)
                    hashcode = (hashcode * 397) + Delete_.GetHashCode();
                if(isset.view_sql_editor_)
                    hashcode = (hashcode * 397) + View_sql_editor_.GetHashCode();
                if(isset.access_)
                    hashcode = (hashcode * 397) + Access_.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDatabasePermissions(");
            bool __first = true;
            if (isset.create_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Create_: ");
                sb.Append(Create_);
            }
            if (isset.delete_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Delete_: ");
                sb.Append(Delete_);
            }
            if (isset.view_sql_editor_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_sql_editor_: ");
                sb.Append(View_sql_editor_);
            }
            if (isset.access_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Access_: ");
                sb.Append(Access_);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

