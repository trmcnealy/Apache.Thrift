using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TGpuSpecification : TBase
    {
        private int   _num_sm;
        private long  _clock_frequency_kHz;
        private long  _memory;
        private short _compute_capability_major;
        private short _compute_capability_minor;

        public int Num_sm
        {
            get
            {
                return _num_sm;
            }
            set
            {
                isset.num_sm = true;
                _num_sm   = value;
            }
        }

        public long Clock_frequency_kHz
        {
            get
            {
                return _clock_frequency_kHz;
            }
            set
            {
                isset.clock_frequency_kHz = true;
                _clock_frequency_kHz   = value;
            }
        }

        public long Memory
        {
            get
            {
                return _memory;
            }
            set
            {
                isset.memory = true;
                _memory   = value;
            }
        }

        public short Compute_capability_major
        {
            get
            {
                return _compute_capability_major;
            }
            set
            {
                isset.compute_capability_major = true;
                _compute_capability_major   = value;
            }
        }

        public short Compute_capability_minor
        {
            get
            {
                return _compute_capability_minor;
            }
            set
            {
                isset.compute_capability_minor = true;
                _compute_capability_minor   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool num_sm;
            public bool clock_frequency_kHz;
            public bool memory;
            public bool compute_capability_major;
            public bool compute_capability_minor;
        }

        public TGpuSpecification()
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
                            if (field.Type == TType.I32)
                            {
                                Num_sm = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Clock_frequency_kHz = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Memory = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I16)
                            {
                                Compute_capability_major = await iprot.ReadI16Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I16)
                            {
                                Compute_capability_minor = await iprot.ReadI16Async(cancellationToken);
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
                var struc = new TStruct("TGpuSpecification");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.num_sm)
                {
                    field.Name = "num_sm";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Num_sm, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.clock_frequency_kHz)
                {
                    field.Name = "clock_frequency_kHz";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Clock_frequency_kHz, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.memory)
                {
                    field.Name = "memory";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Memory, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.compute_capability_major)
                {
                    field.Name = "compute_capability_major";
                    field.Type = TType.I16;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI16Async(Compute_capability_major, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.compute_capability_minor)
                {
                    field.Name = "compute_capability_minor";
                    field.Type = TType.I16;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI16Async(Compute_capability_minor, cancellationToken);
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
            var other = that as TGpuSpecification;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.num_sm                   == other.isset.num_sm)                   && ((!isset.num_sm)                   || (System.Object.Equals(Num_sm,                   other.Num_sm))))
                && ((isset.clock_frequency_kHz      == other.isset.clock_frequency_kHz)      && ((!isset.clock_frequency_kHz)      || (System.Object.Equals(Clock_frequency_kHz,      other.Clock_frequency_kHz))))
                && ((isset.memory                   == other.isset.memory)                   && ((!isset.memory)                   || (System.Object.Equals(Memory,                   other.Memory))))
                && ((isset.compute_capability_major == other.isset.compute_capability_major) && ((!isset.compute_capability_major) || (System.Object.Equals(Compute_capability_major, other.Compute_capability_major))))
                && ((isset.compute_capability_minor == other.isset.compute_capability_minor) && ((!isset.compute_capability_minor) || (System.Object.Equals(Compute_capability_minor, other.Compute_capability_minor))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.num_sm)
                    hashcode = (hashcode * 397) + Num_sm.GetHashCode();
                if(isset.clock_frequency_kHz)
                    hashcode = (hashcode * 397) + Clock_frequency_kHz.GetHashCode();
                if(isset.memory)
                    hashcode = (hashcode * 397) + Memory.GetHashCode();
                if(isset.compute_capability_major)
                    hashcode = (hashcode * 397) + Compute_capability_major.GetHashCode();
                if(isset.compute_capability_minor)
                    hashcode = (hashcode * 397) + Compute_capability_minor.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TGpuSpecification(");
            bool __first = true;
            if (isset.num_sm)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_sm: ");
                sb.Append(Num_sm);
            }
            if (isset.clock_frequency_kHz)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Clock_frequency_kHz: ");
                sb.Append(Clock_frequency_kHz);
            }
            if (isset.memory)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Memory: ");
                sb.Append(Memory);
            }
            if (isset.compute_capability_major)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Compute_capability_major: ");
                sb.Append(Compute_capability_major);
            }
            if (isset.compute_capability_minor)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Compute_capability_minor: ");
                sb.Append(Compute_capability_minor);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

