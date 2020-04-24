using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRawPixelData : TBase
    {
        private int                                       _width;
        private int                                       _height;
        private Dictionary<int, TRawRenderPassDataResult> _render_pass_map;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                isset.width = true;
                _width   = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                isset.height = true;
                _height   = value;
            }
        }

        public Dictionary<int, TRawRenderPassDataResult> Render_pass_map
        {
            get
            {
                return _render_pass_map;
            }
            set
            {
                isset.render_pass_map = true;
                _render_pass_map   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool width;
            public bool height;
            public bool render_pass_map;
        }

        public TRawPixelData()
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
                                Width = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Height = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map108 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    Render_pass_map = new Dictionary<int, TRawRenderPassDataResult>(_map108.Count);
                                    for(int _i109 = 0; _i109 < _map108.Count; ++_i109)
                                    {
                                        int                      _key110;
                                        TRawRenderPassDataResult _val111;
                                        _key110 = await iprot.ReadI32Async(cancellationToken);
                                        _val111 = new TRawRenderPassDataResult();
                                        await _val111.ReadAsync(iprot, cancellationToken);
                                        Render_pass_map[_key110] = _val111;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
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
                var struc = new TStruct("TRawPixelData");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.width)
                {
                    field.Name = "width";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Width, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.height)
                {
                    field.Name = "height";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Height, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Render_pass_map != null && isset.render_pass_map)
                {
                    field.Name = "render_pass_map";
                    field.Type = TType.Map;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.Struct, Render_pass_map.Count), cancellationToken);
                        foreach (int _iter112 in Render_pass_map.Keys)
                        {
                            await oprot.WriteI32Async(_iter112, cancellationToken);
                            await Render_pass_map[_iter112].WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
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
            var other = that as TRawPixelData;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.width           == other.isset.width)           && ((!isset.width)           || (System.Object.Equals(Width,           other.Width))))
                && ((isset.height          == other.isset.height)          && ((!isset.height)          || (System.Object.Equals(Height,          other.Height))))
                && ((isset.render_pass_map == other.isset.render_pass_map) && ((!isset.render_pass_map) || (System.Object.Equals(Render_pass_map, other.Render_pass_map))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.width)
                    hashcode = (hashcode * 397) + Width.GetHashCode();
                if(isset.height)
                    hashcode = (hashcode * 397) + Height.GetHashCode();
                if(isset.render_pass_map)
                    hashcode = (hashcode * 397) + Render_pass_map.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRawPixelData(");
            bool __first = true;
            if (isset.width)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Width: ");
                sb.Append(Width);
            }
            if (isset.height)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Height: ");
                sb.Append(Height);
            }
            if (Render_pass_map != null && isset.render_pass_map)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Render_pass_map: ");
                sb.Append(Render_pass_map);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

