using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDashboardPermissions : TBase
    {
        private bool _create_;
        private bool _delete_;
        private bool _view_;
        private bool _edit_;

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

        public bool View_
        {
            get
            {
                return _view_;
            }
            set
            {
                isset.view_ = true;
                _view_   = value;
            }
        }

        public bool Edit_
        {
            get
            {
                return _edit_;
            }
            set
            {
                isset.edit_ = true;
                _edit_   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool create_;
            public bool delete_;
            public bool view_;
            public bool edit_;
        }

        public TDashboardPermissions()
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
                                View_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Edit_ = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TDashboardPermissions");
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
                if (isset.view_)
                {
                    field.Name = "view_";
                    field.Type = TType.Bool;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(View_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.edit_)
                {
                    field.Name = "edit_";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Edit_, cancellationToken);
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
            var other = that as TDashboardPermissions;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.create_ == other.isset.create_) && ((!isset.create_) || (System.Object.Equals(Create_, other.Create_))))
                && ((isset.delete_ == other.isset.delete_) && ((!isset.delete_) || (System.Object.Equals(Delete_, other.Delete_))))
                && ((isset.view_   == other.isset.view_)   && ((!isset.view_)   || (System.Object.Equals(View_,   other.View_))))
                && ((isset.edit_   == other.isset.edit_)   && ((!isset.edit_)   || (System.Object.Equals(Edit_,   other.Edit_))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.create_)
                    hashcode = (hashcode * 397) + Create_.GetHashCode();
                if(isset.delete_)
                    hashcode = (hashcode * 397) + Delete_.GetHashCode();
                if(isset.view_)
                    hashcode = (hashcode * 397) + View_.GetHashCode();
                if(isset.edit_)
                    hashcode = (hashcode * 397) + Edit_.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDashboardPermissions(");
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
            if (isset.view_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_: ");
                sb.Append(View_);
            }
            if (isset.edit_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Edit_: ");
                sb.Append(Edit_);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

