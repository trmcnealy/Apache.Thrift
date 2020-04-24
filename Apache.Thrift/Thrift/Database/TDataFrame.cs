using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TDataFrame : TBase
    {
        private byte[] _sm_handle;
        private long   _sm_size;
        private byte[] _df_handle;
        private long   _df_size;
        private long   _execution_time_ms;
        private long   _arrow_conversion_time_ms;

        public byte[] Sm_handle
        {
            get { return _sm_handle; }
            set
            {
                isset.sm_handle = true;
                _sm_handle        = value;
            }
        }

        public long Sm_size
        {
            get { return _sm_size; }
            set
            {
                isset.sm_size = true;
                _sm_size        = value;
            }
        }

        public byte[] Df_handle
        {
            get { return _df_handle; }
            set
            {
                isset.df_handle = true;
                _df_handle        = value;
            }
        }

        public long Df_size
        {
            get { return _df_size; }
            set
            {
                isset.df_size = true;
                _df_size        = value;
            }
        }

        public long Execution_time_ms
        {
            get { return _execution_time_ms; }
            set
            {
                isset.execution_time_ms = true;
                _execution_time_ms        = value;
            }
        }

        public long Arrow_conversion_time_ms
        {
            get { return _arrow_conversion_time_ms; }
            set
            {
                isset.arrow_conversion_time_ms = true;
                _arrow_conversion_time_ms        = value;
            }
        }

        public Isset isset;

        public struct Isset
        {
            public bool sm_handle;
            public bool sm_size;
            public bool df_handle;
            public bool df_size;
            public bool execution_time_ms;
            public bool arrow_conversion_time_ms;
        }

        public TDataFrame()
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
                            if(field.Type == TType.String)
                            {
                                Sm_handle = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 2:
                            if(field.Type == TType.I64)
                            {
                                Sm_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 3:
                            if(field.Type == TType.String)
                            {
                                Df_handle = await iprot.ReadBinaryAsync(cancellationToken);
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
                                Df_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 5:
                            if(field.Type == TType.I64)
                            {
                                Execution_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 6:
                            if(field.Type == TType.I64)
                            {
                                Arrow_conversion_time_ms = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TDataFrame");

                await oprot.WriteStructBeginAsync(struc,
                                                  cancellationToken);

                var field = new TField();

                if(Sm_handle != null && isset.sm_handle)
                {
                    field.Name = "sm_handle";
                    field.Type = TType.String;
                    field.ID   = 1;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteBinaryAsync(Sm_handle,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.sm_size)
                {
                    field.Name = "sm_size";
                    field.Type = TType.I64;
                    field.ID   = 2;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI64Async(Sm_size,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Df_handle != null && isset.df_handle)
                {
                    field.Name = "df_handle";
                    field.Type = TType.String;
                    field.ID   = 3;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteBinaryAsync(Df_handle,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.df_size)
                {
                    field.Name = "df_size";
                    field.Type = TType.I64;
                    field.ID   = 4;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI64Async(Df_size,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.execution_time_ms)
                {
                    field.Name = "execution_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 5;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI64Async(Execution_time_ms,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.arrow_conversion_time_ms)
                {
                    field.Name = "arrow_conversion_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 6;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI64Async(Arrow_conversion_time_ms,
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
            TDataFrame other = that as TDataFrame;

            if(other == null)
            {
                return false;
            }

            if(ReferenceEquals(this,
                               other))
            {
                return true;
            }

            return isset.sm_handle == other.isset.sm_handle &&
                   (!isset.sm_handle ||
                    TCollections.Equals(Sm_handle,
                                        other.Sm_handle))   &&
                   isset.sm_size == other.isset.sm_size &&
                   (!isset.sm_size ||
                    Equals(Sm_size,
                           other.Sm_size))                      &&
                   isset.df_handle == other.isset.df_handle &&
                   (!isset.df_handle ||
                    TCollections.Equals(Df_handle,
                                        other.Df_handle))   &&
                   isset.df_size == other.isset.df_size &&
                   (!isset.df_size ||
                    Equals(Df_size,
                           other.Df_size))                                      &&
                   isset.execution_time_ms == other.isset.execution_time_ms &&
                   (!isset.execution_time_ms ||
                    Equals(Execution_time_ms,
                           other.Execution_time_ms))                                          &&
                   isset.arrow_conversion_time_ms == other.isset.arrow_conversion_time_ms &&
                   (!isset.arrow_conversion_time_ms ||
                    Equals(Arrow_conversion_time_ms,
                           other.Arrow_conversion_time_ms));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;

            unchecked
            {
                if(isset.sm_handle)
                {
                    hashcode = hashcode * 397 + Sm_handle.GetHashCode();
                }

                if(isset.sm_size)
                {
                    hashcode = hashcode * 397 + Sm_size.GetHashCode();
                }

                if(isset.df_handle)
                {
                    hashcode = hashcode * 397 + Df_handle.GetHashCode();
                }

                if(isset.df_size)
                {
                    hashcode = hashcode * 397 + Df_size.GetHashCode();
                }

                if(isset.execution_time_ms)
                {
                    hashcode = hashcode * 397 + Execution_time_ms.GetHashCode();
                }

                if(isset.arrow_conversion_time_ms)
                {
                    hashcode = hashcode * 397 + Arrow_conversion_time_ms.GetHashCode();
                }
            }

            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDataFrame(");
            bool __first = true;

            if(Sm_handle != null && isset.sm_handle)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Sm_handle: ");
                sb.Append(Sm_handle);
            }

            if(isset.sm_size)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Sm_size: ");
                sb.Append(Sm_size);
            }

            if(Df_handle != null && isset.df_handle)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Df_handle: ");
                sb.Append(Df_handle);
            }

            if(isset.df_size)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Df_size: ");
                sb.Append(Df_size);
            }

            if(isset.execution_time_ms)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Execution_time_ms: ");
                sb.Append(Execution_time_ms);
            }

            if(isset.arrow_conversion_time_ms)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Arrow_conversion_time_ms: ");
                sb.Append(Arrow_conversion_time_ms);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}