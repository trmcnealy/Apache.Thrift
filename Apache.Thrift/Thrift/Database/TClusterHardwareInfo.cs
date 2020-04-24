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
    public class TClusterHardwareInfo : TBase
    {
        private List<THardwareInfo> _hardware_info;

        public List<THardwareInfo> Hardware_info
        {
            get { return _hardware_info; }
            set
            {
                isset.hardware_info = true;
                _hardware_info        = value;
            }
        }

        public Isset isset;

        public struct Isset
        {
            public bool hardware_info;
        }

        public TClusterHardwareInfo()
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
                            if(field.Type == TType.List)
                            {
                                {
                                    TList _list60 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Hardware_info = new List<THardwareInfo>(_list60.Count);

                                    for(int _i61 = 0; _i61 < _list60.Count; ++_i61)
                                    {
                                        THardwareInfo _elem62;
                                        _elem62 = new THardwareInfo();

                                        await _elem62.ReadAsync(iprot,
                                                                cancellationToken);

                                        Hardware_info.Add(_elem62);
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
                var struc = new TStruct("TClusterHardwareInfo");

                await oprot.WriteStructBeginAsync(struc,
                                                  cancellationToken);

                var field = new TField();

                if(Hardware_info != null && isset.hardware_info)
                {
                    field.Name = "hardware_info";
                    field.Type = TType.List;
                    field.ID   = 1;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct,
                                                                  Hardware_info.Count),
                                                        cancellationToken);

                        foreach(THardwareInfo _iter63 in Hardware_info)
                        {
                            await _iter63.WriteAsync(oprot,
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
            TClusterHardwareInfo other = that as TClusterHardwareInfo;

            if(other == null)
            {
                return false;
            }

            if(ReferenceEquals(this,
                               other))
            {
                return true;
            }

            return isset.hardware_info == other.isset.hardware_info &&
                   (!isset.hardware_info ||
                    TCollections.Equals(Hardware_info,
                                        other.Hardware_info));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;

            unchecked
            {
                if(isset.hardware_info)
                {
                    hashcode = hashcode * 397 + TCollections.GetHashCode(Hardware_info);
                }
            }

            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TClusterHardwareInfo(");
            bool __first = true;

            if(Hardware_info != null && isset.hardware_info)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("Hardware_info: ");
                sb.Append(Hardware_info);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}