using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TGeoFileLayerInfo : TBase
    {
        private string                _name;
        private TGeoFileLayerContents _contents;

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

        /// <summary>
        /// 
        /// <seealso cref="TGeoFileLayerContents"/>
        /// </summary>
        public TGeoFileLayerContents Contents
        {
            get
            {
                return _contents;
            }
            set
            {
                isset.contents = true;
                _contents   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool name;
            public bool contents;
        }

        public TGeoFileLayerInfo()
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
                            if (field.Type == TType.I32)
                            {
                                Contents = (TGeoFileLayerContents)await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TGeoFileLayerInfo");
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
                if (isset.contents)
                {
                    field.Name = "contents";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Contents, cancellationToken);
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
            var other = that as TGeoFileLayerInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.name     == other.isset.name)     && ((!isset.name)     || (System.Object.Equals(Name,     other.Name))))
                && ((isset.contents == other.isset.contents) && ((!isset.contents) || (System.Object.Equals(Contents, other.Contents))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.name)
                    hashcode = (hashcode * 397) + Name.GetHashCode();
                if(isset.contents)
                    hashcode = (hashcode * 397) + Contents.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TGeoFileLayerInfo(");
            bool __first = true;
            if (Name != null && isset.name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Name: ");
                sb.Append(Name);
            }
            if (isset.contents)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Contents: ");
                sb.Append(Contents);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

