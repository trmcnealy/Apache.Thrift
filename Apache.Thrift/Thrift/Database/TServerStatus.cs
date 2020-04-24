using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TServerStatus : TBase
    {
        private bool   _read_only;
        private string _version;
        private bool   _rendering_enabled;
        private long   _start_time;
        private string _edition;
        private string _host_name;
        private bool   _poly_rendering_enabled;
        private TRole  _role;

        public bool Read_only
        {
            get { return _read_only; }
            set
            {
                isset.read_only = true;
                _read_only        = value;
            }
        }

        public string Version
        {
            get { return _version; }
            set
            {
                isset.version = true;
                _version        = value;
            }
        }

        public bool Rendering_enabled
        {
            get { return _rendering_enabled; }
            set
            {
                isset.rendering_enabled = true;
                _rendering_enabled        = value;
            }
        }

        public long Start_time
        {
            get { return _start_time; }
            set
            {
                isset.start_time = true;
                _start_time        = value;
            }
        }

        public string Edition
        {
            get { return _edition; }
            set
            {
                isset.edition = true;
                _edition        = value;
            }
        }

        public string Host_name
        {
            get { return _host_name; }
            set
            {
                isset.host_name = true;
                _host_name        = value;
            }
        }

        public bool Poly_rendering_enabled
        {
            get { return _poly_rendering_enabled; }
            set
            {
                isset.poly_rendering_enabled = true;
                _poly_rendering_enabled        = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TRole"/>
        /// </summary>
        public TRole Role
        {
            get { return _role; }
            set
            {
                isset.role = true;
                _role        = value;
            }
        }

        public Isset isset;

        public struct Isset
        {
            public bool read_only;
            public bool version;
            public bool rendering_enabled;
            public bool start_time;
            public bool edition;
            public bool host_name;
            public bool poly_rendering_enabled;
            public bool role;
        }

        public TServerStatus()
        {
        }

        public async Task ReadAsync(TProtocol         iprot,
                                    CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();

            try
            {
                TField field;
                await iprot.ReadStructBeginAsync(cancellationToken);

                while(true)
                {
                    field = await iprot.ReadFieldBeginAsync(cancellationToken);

                    if(field.Type == TType.Stop)
                    {
                        break;
                    }

                    switch(field.ID)
                    {
                        case 1:
                            if(field.Type == TType.Bool)
                            {
                                Read_only = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 2:
                            if(field.Type == TType.String)
                            {
                                Version = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 3:
                            if(field.Type == TType.Bool)
                            {
                                Rendering_enabled = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 4:
                            if(field.Type == TType.I64)
                            {
                                Start_time = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 5:
                            if(field.Type == TType.String)
                            {
                                Edition = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 6:
                            if(field.Type == TType.String)
                            {
                                Host_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 7:
                            if(field.Type == TType.Bool)
                            {
                                Poly_rendering_enabled = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 8:
                            if(field.Type == TType.I32)
                            {
                                Role = (TRole)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        default:
                            await TProtocolUtil.SkipAsync(iprot,
                                                          field.Type,
                                                          cancellationToken);

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

        public async Task WriteAsync(TProtocol         oprot,
                                     CancellationToken cancellationToken)
        {
            oprot.IncrementRecursionDepth();

            try
            {
                var struc = new TStruct("TServerStatus");

                await oprot.WriteStructBeginAsync(struc,
                                                  cancellationToken);

                var field = new TField();

                if(isset.read_only)
                {
                    field.Name = "read_only";
                    field.Type = TType.Bool;
                    field.ID   = 1;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteBoolAsync(Read_only,
                                               cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Version != null && isset.version)
                {
                    field.Name = "version";
                    field.Type = TType.String;
                    field.ID   = 2;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(Version,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.rendering_enabled)
                {
                    field.Name = "rendering_enabled";
                    field.Type = TType.Bool;
                    field.ID   = 3;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteBoolAsync(Rendering_enabled,
                                               cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.start_time)
                {
                    field.Name = "start_time";
                    field.Type = TType.I64;
                    field.ID   = 4;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI64Async(Start_time,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Edition != null && isset.edition)
                {
                    field.Name = "edition";
                    field.Type = TType.String;
                    field.ID   = 5;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(Edition,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Host_name != null && isset.host_name)
                {
                    field.Name = "host_name";
                    field.Type = TType.String;
                    field.ID   = 6;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(Host_name,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.poly_rendering_enabled)
                {
                    field.Name = "poly_rendering_enabled";
                    field.Type = TType.Bool;
                    field.ID   = 7;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteBoolAsync(Poly_rendering_enabled,
                                               cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.role)
                {
                    field.Name = "role";
                    field.Type = TType.I32;
                    field.ID   = 8;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI32Async((int)Role,
                                              cancellationToken);

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
            TServerStatus other = that as TServerStatus;

            if(other == null)
            {
                return false;
            }

            if(ReferenceEquals(this,
                               other))
            {
                return true;
            }

            return isset.read_only == other.isset.read_only &&
                   (!isset.read_only ||
                    Equals(Read_only,
                           other.Read_only))                &&
                   isset.version == other.isset.version &&
                   (!isset.version ||
                    Equals(Version,
                           other.Version))                                      &&
                   isset.rendering_enabled == other.isset.rendering_enabled &&
                   (!isset.rendering_enabled ||
                    Equals(Rendering_enabled,
                           other.Rendering_enabled))              &&
                   isset.start_time == other.isset.start_time &&
                   (!isset.start_time ||
                    Equals(Start_time,
                           other.Start_time))               &&
                   isset.edition == other.isset.edition &&
                   (!isset.edition ||
                    Equals(Edition,
                           other.Edition))                      &&
                   isset.host_name == other.isset.host_name &&
                   (!isset.host_name ||
                    Equals(Host_name,
                           other.Host_name))                                              &&
                   isset.poly_rendering_enabled == other.isset.poly_rendering_enabled &&
                   (!isset.poly_rendering_enabled ||
                    Equals(Poly_rendering_enabled,
                           other.Poly_rendering_enabled)) &&
                   isset.role == other.isset.role     &&
                   (!isset.role ||
                    Equals(Role,
                           other.Role));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;

            unchecked
            {
                if(isset.read_only)
                {
                    hashcode = hashcode * 397 + Read_only.GetHashCode();
                }

                if(isset.version)
                {
                    hashcode = hashcode * 397 + Version.GetHashCode();
                }

                if(isset.rendering_enabled)
                {
                    hashcode = hashcode * 397 + Rendering_enabled.GetHashCode();
                }

                if(isset.start_time)
                {
                    hashcode = hashcode * 397 + Start_time.GetHashCode();
                }

                if(isset.edition)
                {
                    hashcode = hashcode * 397 + Edition.GetHashCode();
                }

                if(isset.host_name)
                {
                    hashcode = hashcode * 397 + Host_name.GetHashCode();
                }

                if(isset.poly_rendering_enabled)
                {
                    hashcode = hashcode * 397 + Poly_rendering_enabled.GetHashCode();
                }

                if(isset.role)
                {
                    hashcode = hashcode * 397 + Role.GetHashCode();
                }
            }

            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TServerStatus(");
            bool __first = true;

            if(isset.read_only)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Read_only: ");
                sb.Append(Read_only);
            }

            if(Version != null && isset.version)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Version: ");
                sb.Append(Version);
            }

            if(isset.rendering_enabled)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Rendering_enabled: ");
                sb.Append(Rendering_enabled);
            }

            if(isset.start_time)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Start_time: ");
                sb.Append(Start_time);
            }

            if(Edition != null && isset.edition)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Edition: ");
                sb.Append(Edition);
            }

            if(Host_name != null && isset.host_name)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Host_name: ");
                sb.Append(Host_name);
            }

            if(isset.poly_rendering_enabled)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Poly_rendering_enabled: ");
                sb.Append(Poly_rendering_enabled);
            }

            if(isset.role)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Role: ");
                sb.Append(Role);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}