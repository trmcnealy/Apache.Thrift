using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRenderStepResult : TBase
    {
        private Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<TRenderDatum>>>>> _merge_data;
        private TRawPixelData                                                                                      _raw_pixel_data;
        private long                                                                                               _execution_time_ms;
        private long                                                                                               _render_time_ms;
        private long                                                                                               _total_time_ms;

        public Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<TRenderDatum>>>>> Merge_data
        {
            get
            {
                return _merge_data;
            }
            set
            {
                isset.merge_data = true;
                _merge_data   = value;
            }
        }

        public TRawPixelData Raw_pixel_data
        {
            get
            {
                return _raw_pixel_data;
            }
            set
            {
                isset.raw_pixel_data = true;
                _raw_pixel_data   = value;
            }
        }

        public long Execution_time_ms
        {
            get
            {
                return _execution_time_ms;
            }
            set
            {
                isset.execution_time_ms = true;
                _execution_time_ms   = value;
            }
        }

        public long Render_time_ms
        {
            get
            {
                return _render_time_ms;
            }
            set
            {
                isset.render_time_ms = true;
                _render_time_ms   = value;
            }
        }

        public long Total_time_ms
        {
            get
            {
                return _total_time_ms;
            }
            set
            {
                isset.total_time_ms = true;
                _total_time_ms   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool merge_data;
            public bool raw_pixel_data;
            public bool execution_time_ms;
            public bool render_time_ms;
            public bool total_time_ms;
        }

        public TRenderStepResult()
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
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map113 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    Merge_data = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<TRenderDatum>>>>>(_map113.Count);
                                    for(int _i114 = 0; _i114 < _map113.Count; ++_i114)
                                    {
                                        string                                                                         _key115;
                                        Dictionary<string, Dictionary<string, Dictionary<string, List<TRenderDatum>>>> _val116;
                                        _key115 = await iprot.ReadStringAsync(cancellationToken);
                                        {
                                            TMap _map117 = await iprot.ReadMapBeginAsync(cancellationToken);
                                            _val116 = new Dictionary<string, Dictionary<string, Dictionary<string, List<TRenderDatum>>>>(_map117.Count);
                                            for(int _i118 = 0; _i118 < _map117.Count; ++_i118)
                                            {
                                                string                                                     _key119;
                                                Dictionary<string, Dictionary<string, List<TRenderDatum>>> _val120;
                                                _key119 = await iprot.ReadStringAsync(cancellationToken);
                                                {
                                                    TMap _map121 = await iprot.ReadMapBeginAsync(cancellationToken);
                                                    _val120 = new Dictionary<string, Dictionary<string, List<TRenderDatum>>>(_map121.Count);
                                                    for(int _i122 = 0; _i122 < _map121.Count; ++_i122)
                                                    {
                                                        string                                 _key123;
                                                        Dictionary<string, List<TRenderDatum>> _val124;
                                                        _key123 = await iprot.ReadStringAsync(cancellationToken);
                                                        {
                                                            TMap _map125 = await iprot.ReadMapBeginAsync(cancellationToken);
                                                            _val124 = new Dictionary<string, List<TRenderDatum>>(_map125.Count);
                                                            for(int _i126 = 0; _i126 < _map125.Count; ++_i126)
                                                            {
                                                                string             _key127;
                                                                List<TRenderDatum> _val128;
                                                                _key127 = await iprot.ReadStringAsync(cancellationToken);
                                                                {
                                                                    TList _list129 = await iprot.ReadListBeginAsync(cancellationToken);
                                                                    _val128 = new List<TRenderDatum>(_list129.Count);
                                                                    for(int _i130 = 0; _i130 < _list129.Count; ++_i130)
                                                                    {
                                                                        TRenderDatum _elem131;
                                                                        _elem131 = new TRenderDatum();
                                                                        await _elem131.ReadAsync(iprot, cancellationToken);
                                                                        _val128.Add(_elem131);
                                                                    }
                                                                    await iprot.ReadListEndAsync(cancellationToken);
                                                                }
                                                                _val124[_key127] = _val128;
                                                            }
                                                            await iprot.ReadMapEndAsync(cancellationToken);
                                                        }
                                                        _val120[_key123] = _val124;
                                                    }
                                                    await iprot.ReadMapEndAsync(cancellationToken);
                                                }
                                                _val116[_key119] = _val120;
                                            }
                                            await iprot.ReadMapEndAsync(cancellationToken);
                                        }
                                        Merge_data[_key115] = _val116;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Struct)
                            {
                                Raw_pixel_data = new TRawPixelData();
                                await Raw_pixel_data.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Execution_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I64)
                            {
                                Render_time_ms = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I64)
                            {
                                Total_time_ms = await iprot.ReadI64Async(cancellationToken);
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
                var struc = new TStruct("TRenderStepResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Merge_data != null && isset.merge_data)
                {
                    field.Name = "merge_data";
                    field.Type = TType.Map;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Map, Merge_data.Count), cancellationToken);
                        foreach (string _iter132 in Merge_data.Keys)
                        {
                            await oprot.WriteStringAsync(_iter132, cancellationToken);
                            {
                                await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Map, Merge_data[_iter132].Count), cancellationToken);
                                foreach (string _iter133 in Merge_data[_iter132].Keys)
                                {
                                    await oprot.WriteStringAsync(_iter133, cancellationToken);
                                    {
                                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Map, Merge_data[_iter132][_iter133].Count), cancellationToken);
                                        foreach (string _iter134 in Merge_data[_iter132][_iter133].Keys)
                                        {
                                            await oprot.WriteStringAsync(_iter134, cancellationToken);
                                            {
                                                await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.List, Merge_data[_iter132][_iter133][_iter134].Count), cancellationToken);
                                                foreach (string _iter135 in Merge_data[_iter132][_iter133][_iter134].Keys)
                                                {
                                                    await oprot.WriteStringAsync(_iter135, cancellationToken);
                                                    {
                                                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Merge_data[_iter132][_iter133][_iter134][_iter135].Count), cancellationToken);
                                                        foreach (TRenderDatum _iter136 in Merge_data[_iter132][_iter133][_iter134][_iter135])
                                                        {
                                                            await _iter136.WriteAsync(oprot, cancellationToken);
                                                        }
                                                        await oprot.WriteListEndAsync(cancellationToken);
                                                    }
                                                }
                                                await oprot.WriteMapEndAsync(cancellationToken);
                                            }
                                        }
                                        await oprot.WriteMapEndAsync(cancellationToken);
                                    }
                                }
                                await oprot.WriteMapEndAsync(cancellationToken);
                            }
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Raw_pixel_data != null && isset.raw_pixel_data)
                {
                    field.Name = "raw_pixel_data";
                    field.Type = TType.Struct;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Raw_pixel_data.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.execution_time_ms)
                {
                    field.Name = "execution_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Execution_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.render_time_ms)
                {
                    field.Name = "render_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Render_time_ms, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.total_time_ms)
                {
                    field.Name = "total_time_ms";
                    field.Type = TType.I64;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Total_time_ms, cancellationToken);
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
            var other = that as TRenderStepResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.merge_data        == other.isset.merge_data)        && ((!isset.merge_data)        || (System.Object.Equals(Merge_data,        other.Merge_data))))
                && ((isset.raw_pixel_data    == other.isset.raw_pixel_data)    && ((!isset.raw_pixel_data)    || (System.Object.Equals(Raw_pixel_data,    other.Raw_pixel_data))))
                && ((isset.execution_time_ms == other.isset.execution_time_ms) && ((!isset.execution_time_ms) || (System.Object.Equals(Execution_time_ms, other.Execution_time_ms))))
                && ((isset.render_time_ms    == other.isset.render_time_ms)    && ((!isset.render_time_ms)    || (System.Object.Equals(Render_time_ms,    other.Render_time_ms))))
                && ((isset.total_time_ms     == other.isset.total_time_ms)     && ((!isset.total_time_ms)     || (System.Object.Equals(Total_time_ms,     other.Total_time_ms))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.merge_data)
                    hashcode = (hashcode * 397) + Merge_data.GetHashCode();
                if(isset.raw_pixel_data)
                    hashcode = (hashcode * 397) + Raw_pixel_data.GetHashCode();
                if(isset.execution_time_ms)
                    hashcode = (hashcode * 397) + Execution_time_ms.GetHashCode();
                if(isset.render_time_ms)
                    hashcode = (hashcode * 397) + Render_time_ms.GetHashCode();
                if(isset.total_time_ms)
                    hashcode = (hashcode * 397) + Total_time_ms.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TRenderStepResult(");
            bool __first = true;
            if (Merge_data != null && isset.merge_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Merge_data: ");
                sb.Append(Merge_data);
            }
            if (Raw_pixel_data != null && isset.raw_pixel_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Raw_pixel_data: ");
                sb.Append(Raw_pixel_data == null ? "<null>" : Raw_pixel_data.ToString());
            }
            if (isset.execution_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Execution_time_ms: ");
                sb.Append(Execution_time_ms);
            }
            if (isset.render_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Render_time_ms: ");
                sb.Append(Render_time_ms);
            }
            if (isset.total_time_ms)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Total_time_ms: ");
                sb.Append(Total_time_ms);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

