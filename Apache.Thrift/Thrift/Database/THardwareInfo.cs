using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class THardwareInfo : TBase
    {
        private short                   _num_gpu_hw;
        private short                   _num_cpu_hw;
        private short                   _num_gpu_allocated;
        private short                   _start_gpu;
        private string                  _host_name;
        private List<TGpuSpecification> _gpu_info;

        public short Num_gpu_hw
        {
            get { return _num_gpu_hw; }
            set
            {
                isset.num_gpu_hw = true;
                _num_gpu_hw        = value;
            }
        }

        public short Num_cpu_hw
        {
            get { return _num_cpu_hw; }
            set
            {
                isset.num_cpu_hw = true;
                _num_cpu_hw        = value;
            }
        }

        public short Num_gpu_allocated
        {
            get { return _num_gpu_allocated; }
            set
            {
                isset.num_gpu_allocated = true;
                _num_gpu_allocated        = value;
            }
        }

        public short Start_gpu
        {
            get { return _start_gpu; }
            set
            {
                isset.start_gpu = true;
                _start_gpu        = value;
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

        public List<TGpuSpecification> Gpu_info
        {
            get { return _gpu_info; }
            set
            {
                isset.gpu_info = true;
                _gpu_info        = value;
            }
        }

        public Isset isset;

        public struct Isset
        {
            public bool num_gpu_hw;
            public bool num_cpu_hw;
            public bool num_gpu_allocated;
            public bool start_gpu;
            public bool host_name;
            public bool gpu_info;
        }

        public THardwareInfo()
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
                            if(field.Type == TType.I16)
                            {
                                Num_gpu_hw = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 2:
                            if(field.Type == TType.I16)
                            {
                                Num_cpu_hw = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 3:
                            if(field.Type == TType.I16)
                            {
                                Num_gpu_allocated = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 4:
                            if(field.Type == TType.I16)
                            {
                                Start_gpu = await iprot.ReadI16Async(cancellationToken);
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
                                Host_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 6:
                            if(field.Type == TType.List)
                            {
                                {
                                    TList _list56 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Gpu_info = new List<TGpuSpecification>(_list56.Count);

                                    for(int _i57 = 0; _i57 < _list56.Count; ++_i57)
                                    {
                                        TGpuSpecification _elem58;
                                        _elem58 = new TGpuSpecification();

                                        await _elem58.ReadAsync(iprot,
                                                                cancellationToken);

                                        Gpu_info.Add(_elem58);
                                    }

                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
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
                var struc = new TStruct("THardwareInfo");

                await oprot.WriteStructBeginAsync(struc,
                                                  cancellationToken);

                var field = new TField();

                if(isset.num_gpu_hw)
                {
                    field.Name = "num_gpu_hw";
                    field.Type = TType.I16;
                    field.ID   = 1;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI16Async(Num_gpu_hw,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.num_cpu_hw)
                {
                    field.Name = "num_cpu_hw";
                    field.Type = TType.I16;
                    field.ID   = 2;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI16Async(Num_cpu_hw,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.num_gpu_allocated)
                {
                    field.Name = "num_gpu_allocated";
                    field.Type = TType.I16;
                    field.ID   = 3;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI16Async(Num_gpu_allocated,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(isset.start_gpu)
                {
                    field.Name = "start_gpu";
                    field.Type = TType.I16;
                    field.ID   = 4;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteI16Async(Start_gpu,
                                              cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Host_name != null && isset.host_name)
                {
                    field.Name = "host_name";
                    field.Type = TType.String;
                    field.ID   = 5;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(Host_name,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(Gpu_info != null && isset.gpu_info)
                {
                    field.Name = "gpu_info";
                    field.Type = TType.List;
                    field.ID   = 6;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct,
                                                                  Gpu_info.Count),
                                                        cancellationToken);

                        foreach(TGpuSpecification _iter59 in Gpu_info)
                        {
                            await _iter59.WriteAsync(oprot,
                                                     cancellationToken);
                        }

                        await oprot.WriteListEndAsync(cancellationToken);
                    }

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
            THardwareInfo other = that as THardwareInfo;

            if(other == null)
            {
                return false;
            }

            if(ReferenceEquals(this,
                               other))
            {
                return true;
            }

            return isset.num_gpu_hw == other.isset.num_gpu_hw &&
                   (!isset.num_gpu_hw ||
                    Equals(Num_gpu_hw,
                           other.Num_gpu_hw))                     &&
                   isset.num_cpu_hw == other.isset.num_cpu_hw &&
                   (!isset.num_cpu_hw ||
                    Equals(Num_cpu_hw,
                           other.Num_cpu_hw))                                   &&
                   isset.num_gpu_allocated == other.isset.num_gpu_allocated &&
                   (!isset.num_gpu_allocated ||
                    Equals(Num_gpu_allocated,
                           other.Num_gpu_allocated))            &&
                   isset.start_gpu == other.isset.start_gpu &&
                   (!isset.start_gpu ||
                    Equals(Start_gpu,
                           other.Start_gpu))                    &&
                   isset.host_name == other.isset.host_name &&
                   (!isset.host_name ||
                    Equals(Host_name,
                           other.Host_name))                  &&
                   isset.gpu_info == other.isset.gpu_info &&
                   (!isset.gpu_info ||
                    TCollections.Equals(Gpu_info,
                                        other.Gpu_info));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;

            unchecked
            {
                if(isset.num_gpu_hw)
                {
                    hashcode = hashcode * 397 + Num_gpu_hw.GetHashCode();
                }

                if(isset.num_cpu_hw)
                {
                    hashcode = hashcode * 397 + Num_cpu_hw.GetHashCode();
                }

                if(isset.num_gpu_allocated)
                {
                    hashcode = hashcode * 397 + Num_gpu_allocated.GetHashCode();
                }

                if(isset.start_gpu)
                {
                    hashcode = hashcode * 397 + Start_gpu.GetHashCode();
                }

                if(isset.host_name)
                {
                    hashcode = hashcode * 397 + Host_name.GetHashCode();
                }

                if(isset.gpu_info)
                {
                    hashcode = hashcode * 397 + TCollections.GetHashCode(Gpu_info);
                }
            }

            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("THardwareInfo(");
            bool __first = true;

            if(isset.num_gpu_hw)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Num_gpu_hw: ");
                sb.Append(Num_gpu_hw);
            }

            if(isset.num_cpu_hw)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Num_cpu_hw: ");
                sb.Append(Num_cpu_hw);
            }

            if(isset.num_gpu_allocated)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Num_gpu_allocated: ");
                sb.Append(Num_gpu_allocated);
            }

            if(isset.start_gpu)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Start_gpu: ");
                sb.Append(Start_gpu);
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

            if(Gpu_info != null && isset.gpu_info)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Gpu_info: ");
                sb.Append(Gpu_info);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}