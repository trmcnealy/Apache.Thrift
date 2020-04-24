using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDashboard : TBase
    {
        private string _dashboard_name;
        private string _dashboard_state;
        private string _image_hash;
        private string _update_time;
        private string _dashboard_metadata;
        private int    _dashboard_id;
        private string _dashboard_owner;
        private bool   _is_dash_shared;

        public string Dashboard_name
        {
            get
            {
                return _dashboard_name;
            }
            set
            {
                isset.dashboard_name = true;
                _dashboard_name   = value;
            }
        }

        public string Dashboard_state
        {
            get
            {
                return _dashboard_state;
            }
            set
            {
                isset.dashboard_state = true;
                _dashboard_state   = value;
            }
        }

        public string Image_hash
        {
            get
            {
                return _image_hash;
            }
            set
            {
                isset.image_hash = true;
                _image_hash   = value;
            }
        }

        public string Update_time
        {
            get
            {
                return _update_time;
            }
            set
            {
                isset.update_time = true;
                _update_time   = value;
            }
        }

        public string Dashboard_metadata
        {
            get
            {
                return _dashboard_metadata;
            }
            set
            {
                isset.dashboard_metadata = true;
                _dashboard_metadata   = value;
            }
        }

        public int Dashboard_id
        {
            get
            {
                return _dashboard_id;
            }
            set
            {
                isset.dashboard_id = true;
                _dashboard_id   = value;
            }
        }

        public string Dashboard_owner
        {
            get
            {
                return _dashboard_owner;
            }
            set
            {
                isset.dashboard_owner = true;
                _dashboard_owner   = value;
            }
        }

        public bool Is_dash_shared
        {
            get
            {
                return _is_dash_shared;
            }
            set
            {
                isset.is_dash_shared = true;
                _is_dash_shared   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool dashboard_name;
            public bool dashboard_state;
            public bool image_hash;
            public bool update_time;
            public bool dashboard_metadata;
            public bool dashboard_id;
            public bool dashboard_owner;
            public bool is_dash_shared;
        }

        public TDashboard()
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
                                Dashboard_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Dashboard_state = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.String)
                            {
                                Image_hash = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.String)
                            {
                                Update_time = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.String)
                            {
                                Dashboard_metadata = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I32)
                            {
                                Dashboard_id = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.String)
                            {
                                Dashboard_owner = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.Bool)
                            {
                                Is_dash_shared = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TDashboard");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Dashboard_name != null && isset.dashboard_name)
                {
                    field.Name = "dashboard_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Dashboard_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Dashboard_state != null && isset.dashboard_state)
                {
                    field.Name = "dashboard_state";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Dashboard_state, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Image_hash != null && isset.image_hash)
                {
                    field.Name = "image_hash";
                    field.Type = TType.String;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Image_hash, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Update_time != null && isset.update_time)
                {
                    field.Name = "update_time";
                    field.Type = TType.String;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Update_time, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Dashboard_metadata != null && isset.dashboard_metadata)
                {
                    field.Name = "dashboard_metadata";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Dashboard_metadata, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.dashboard_id)
                {
                    field.Name = "dashboard_id";
                    field.Type = TType.I32;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Dashboard_id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Dashboard_owner != null && isset.dashboard_owner)
                {
                    field.Name = "dashboard_owner";
                    field.Type = TType.String;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Dashboard_owner, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_dash_shared)
                {
                    field.Name = "is_dash_shared";
                    field.Type = TType.Bool;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_dash_shared, cancellationToken);
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
            var other = that as TDashboard;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.dashboard_name     == other.isset.dashboard_name)     && ((!isset.dashboard_name)     || (System.Object.Equals(Dashboard_name,     other.Dashboard_name))))
                && ((isset.dashboard_state    == other.isset.dashboard_state)    && ((!isset.dashboard_state)    || (System.Object.Equals(Dashboard_state,    other.Dashboard_state))))
                && ((isset.image_hash         == other.isset.image_hash)         && ((!isset.image_hash)         || (System.Object.Equals(Image_hash,         other.Image_hash))))
                && ((isset.update_time        == other.isset.update_time)        && ((!isset.update_time)        || (System.Object.Equals(Update_time,        other.Update_time))))
                && ((isset.dashboard_metadata == other.isset.dashboard_metadata) && ((!isset.dashboard_metadata) || (System.Object.Equals(Dashboard_metadata, other.Dashboard_metadata))))
                && ((isset.dashboard_id       == other.isset.dashboard_id)       && ((!isset.dashboard_id)       || (System.Object.Equals(Dashboard_id,       other.Dashboard_id))))
                && ((isset.dashboard_owner    == other.isset.dashboard_owner)    && ((!isset.dashboard_owner)    || (System.Object.Equals(Dashboard_owner,    other.Dashboard_owner))))
                && ((isset.is_dash_shared     == other.isset.is_dash_shared)     && ((!isset.is_dash_shared)     || (System.Object.Equals(Is_dash_shared,     other.Is_dash_shared))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.dashboard_name)
                    hashcode = (hashcode * 397) + Dashboard_name.GetHashCode();
                if(isset.dashboard_state)
                    hashcode = (hashcode * 397) + Dashboard_state.GetHashCode();
                if(isset.image_hash)
                    hashcode = (hashcode * 397) + Image_hash.GetHashCode();
                if(isset.update_time)
                    hashcode = (hashcode * 397) + Update_time.GetHashCode();
                if(isset.dashboard_metadata)
                    hashcode = (hashcode * 397) + Dashboard_metadata.GetHashCode();
                if(isset.dashboard_id)
                    hashcode = (hashcode * 397) + Dashboard_id.GetHashCode();
                if(isset.dashboard_owner)
                    hashcode = (hashcode * 397) + Dashboard_owner.GetHashCode();
                if(isset.is_dash_shared)
                    hashcode = (hashcode * 397) + Is_dash_shared.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDashboard(");
            bool __first = true;
            if (Dashboard_name != null && isset.dashboard_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_name: ");
                sb.Append(Dashboard_name);
            }
            if (Dashboard_state != null && isset.dashboard_state)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_state: ");
                sb.Append(Dashboard_state);
            }
            if (Image_hash != null && isset.image_hash)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Image_hash: ");
                sb.Append(Image_hash);
            }
            if (Update_time != null && isset.update_time)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Update_time: ");
                sb.Append(Update_time);
            }
            if (Dashboard_metadata != null && isset.dashboard_metadata)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_metadata: ");
                sb.Append(Dashboard_metadata);
            }
            if (isset.dashboard_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_id: ");
                sb.Append(Dashboard_id);
            }
            if (Dashboard_owner != null && isset.dashboard_owner)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dashboard_owner: ");
                sb.Append(Dashboard_owner);
            }
            if (isset.is_dash_shared)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_dash_shared: ");
                sb.Append(Is_dash_shared);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

