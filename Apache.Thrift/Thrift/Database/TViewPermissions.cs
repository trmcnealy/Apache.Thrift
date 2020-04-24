using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TViewPermissions : TBase
    {
        private bool _create_;
        private bool _drop_;
        private bool _select_;
        private bool _insert_;
        private bool _update_;
        private bool _delete_;

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

        public bool Drop_
        {
            get
            {
                return _drop_;
            }
            set
            {
                isset.drop_ = true;
                _drop_   = value;
            }
        }

        public bool Select_
        {
            get
            {
                return _select_;
            }
            set
            {
                isset.select_ = true;
                _select_   = value;
            }
        }

        public bool Insert_
        {
            get
            {
                return _insert_;
            }
            set
            {
                isset.insert_ = true;
                _insert_   = value;
            }
        }

        public bool Update_
        {
            get
            {
                return _update_;
            }
            set
            {
                isset.update_ = true;
                _update_   = value;
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


        public Isset isset;
        public struct Isset
        {
            public bool create_;
            public bool drop_;
            public bool select_;
            public bool insert_;
            public bool update_;
            public bool delete_;
        }

        public TViewPermissions()
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
                                Drop_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Bool)
                            {
                                Select_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Insert_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Bool)
                            {
                                Update_ = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Bool)
                            {
                                Delete_ = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TViewPermissions");
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
                if (isset.drop_)
                {
                    field.Name = "drop_";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Drop_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.select_)
                {
                    field.Name = "select_";
                    field.Type = TType.Bool;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Select_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.insert_)
                {
                    field.Name = "insert_";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Insert_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.update_)
                {
                    field.Name = "update_";
                    field.Type = TType.Bool;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Update_, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.delete_)
                {
                    field.Name = "delete_";
                    field.Type = TType.Bool;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Delete_, cancellationToken);
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
            var other = that as TViewPermissions;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.create_ == other.isset.create_) && ((!isset.create_) || (System.Object.Equals(Create_, other.Create_))))
                && ((isset.drop_   == other.isset.drop_)   && ((!isset.drop_)   || (System.Object.Equals(Drop_,   other.Drop_))))
                && ((isset.select_ == other.isset.select_) && ((!isset.select_) || (System.Object.Equals(Select_, other.Select_))))
                && ((isset.insert_ == other.isset.insert_) && ((!isset.insert_) || (System.Object.Equals(Insert_, other.Insert_))))
                && ((isset.update_ == other.isset.update_) && ((!isset.update_) || (System.Object.Equals(Update_, other.Update_))))
                && ((isset.delete_ == other.isset.delete_) && ((!isset.delete_) || (System.Object.Equals(Delete_, other.Delete_))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.create_)
                    hashcode = (hashcode * 397) + Create_.GetHashCode();
                if(isset.drop_)
                    hashcode = (hashcode * 397) + Drop_.GetHashCode();
                if(isset.select_)
                    hashcode = (hashcode * 397) + Select_.GetHashCode();
                if(isset.insert_)
                    hashcode = (hashcode * 397) + Insert_.GetHashCode();
                if(isset.update_)
                    hashcode = (hashcode * 397) + Update_.GetHashCode();
                if(isset.delete_)
                    hashcode = (hashcode * 397) + Delete_.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TViewPermissions(");
            bool __first = true;
            if (isset.create_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Create_: ");
                sb.Append(Create_);
            }
            if (isset.drop_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Drop_: ");
                sb.Append(Drop_);
            }
            if (isset.select_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Select_: ");
                sb.Append(Select_);
            }
            if (isset.insert_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Insert_: ");
                sb.Append(Insert_);
            }
            if (isset.update_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Update_: ");
                sb.Append(Update_);
            }
            if (isset.delete_)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Delete_: ");
                sb.Append(Delete_);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

