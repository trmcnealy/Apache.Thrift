using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TFrontendView : TBase
    {
        private string _view_name;
        private string _view_state;
        private string _image_hash;
        private string _update_time;
        private string _view_metadata;

        public string View_name
        {
            get
            {
                return _view_name;
            }
            set
            {
                isset.view_name = true;
                _view_name   = value;
            }
        }

        public string View_state
        {
            get
            {
                return _view_state;
            }
            set
            {
                isset.view_state = true;
                _view_state   = value;
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

        public string View_metadata
        {
            get
            {
                return _view_metadata;
            }
            set
            {
                isset.view_metadata = true;
                _view_metadata   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool view_name;
            public bool view_state;
            public bool image_hash;
            public bool update_time;
            public bool view_metadata;
        }

        public TFrontendView()
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
                                View_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                View_state = await iprot.ReadStringAsync(cancellationToken);
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
                                View_metadata = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TFrontendView");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (View_name != null && isset.view_name)
                {
                    field.Name = "view_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(View_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (View_state != null && isset.view_state)
                {
                    field.Name = "view_state";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(View_state, cancellationToken);
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
                if (View_metadata != null && isset.view_metadata)
                {
                    field.Name = "view_metadata";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(View_metadata, cancellationToken);
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
            var other = that as TFrontendView;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.view_name     == other.isset.view_name)     && ((!isset.view_name)     || (System.Object.Equals(View_name,     other.View_name))))
                && ((isset.view_state    == other.isset.view_state)    && ((!isset.view_state)    || (System.Object.Equals(View_state,    other.View_state))))
                && ((isset.image_hash    == other.isset.image_hash)    && ((!isset.image_hash)    || (System.Object.Equals(Image_hash,    other.Image_hash))))
                && ((isset.update_time   == other.isset.update_time)   && ((!isset.update_time)   || (System.Object.Equals(Update_time,   other.Update_time))))
                && ((isset.view_metadata == other.isset.view_metadata) && ((!isset.view_metadata) || (System.Object.Equals(View_metadata, other.View_metadata))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.view_name)
                    hashcode = (hashcode * 397) + View_name.GetHashCode();
                if(isset.view_state)
                    hashcode = (hashcode * 397) + View_state.GetHashCode();
                if(isset.image_hash)
                    hashcode = (hashcode * 397) + Image_hash.GetHashCode();
                if(isset.update_time)
                    hashcode = (hashcode * 397) + Update_time.GetHashCode();
                if(isset.view_metadata)
                    hashcode = (hashcode * 397) + View_metadata.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TFrontendView(");
            bool __first = true;
            if (View_name != null && isset.view_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_name: ");
                sb.Append(View_name);
            }
            if (View_state != null && isset.view_state)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_state: ");
                sb.Append(View_state);
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
            if (View_metadata != null && isset.view_metadata)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("View_metadata: ");
                sb.Append(View_metadata);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

