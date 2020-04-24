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
    public class TNodeMemoryInfo : TBase
    {
        private string            _host_name;
        private long              _page_size;
        private long              _max_num_pages;
        private long              _num_pages_allocated;
        private bool              _is_allocation_capped;
        private List<TMemoryData> _node_memory_data;

        public string Host_name
        {
            get
            {
                return _host_name;
            }
            set
            {
                isset.host_name = true;
                _host_name   = value;
            }
        }

        public long Page_size
        {
            get
            {
                return _page_size;
            }
            set
            {
                isset.page_size = true;
                _page_size   = value;
            }
        }

        public long Max_num_pages
        {
            get
            {
                return _max_num_pages;
            }
            set
            {
                isset.max_num_pages = true;
                _max_num_pages   = value;
            }
        }

        public long Num_pages_allocated
        {
            get
            {
                return _num_pages_allocated;
            }
            set
            {
                isset.num_pages_allocated = true;
                _num_pages_allocated   = value;
            }
        }

        public bool Is_allocation_capped
        {
            get
            {
                return _is_allocation_capped;
            }
            set
            {
                isset.is_allocation_capped = true;
                _is_allocation_capped   = value;
            }
        }

        public List<TMemoryData> Node_memory_data
        {
            get
            {
                return _node_memory_data;
            }
            set
            {
                isset.node_memory_data = true;
                _node_memory_data   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool host_name;
            public bool page_size;
            public bool max_num_pages;
            public bool num_pages_allocated;
            public bool is_allocation_capped;
            public bool node_memory_data;
        }

        public TNodeMemoryInfo()
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
                                Host_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I64)
                            {
                                Page_size = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Max_num_pages = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I64)
                            {
                                Num_pages_allocated = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.Bool)
                            {
                                Is_allocation_capped = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list68 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Node_memory_data = new List<TMemoryData>(_list68.Count);
                                    for(int _i69 = 0; _i69 < _list68.Count; ++_i69)
                                    {
                                        TMemoryData _elem70;
                                        _elem70 = new TMemoryData();
                                        await _elem70.ReadAsync(iprot, cancellationToken);
                                        Node_memory_data.Add(_elem70);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
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
                var struc = new TStruct("TNodeMemoryInfo");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Host_name != null && isset.host_name)
                {
                    field.Name = "host_name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Host_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.page_size)
                {
                    field.Name = "page_size";
                    field.Type = TType.I64;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Page_size, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.max_num_pages)
                {
                    field.Name = "max_num_pages";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Max_num_pages, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.num_pages_allocated)
                {
                    field.Name = "num_pages_allocated";
                    field.Type = TType.I64;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Num_pages_allocated, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_allocation_capped)
                {
                    field.Name = "is_allocation_capped";
                    field.Type = TType.Bool;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_allocation_capped, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Node_memory_data != null && isset.node_memory_data)
                {
                    field.Name = "node_memory_data";
                    field.Type = TType.List;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Node_memory_data.Count), cancellationToken);
                        foreach (TMemoryData _iter71 in Node_memory_data)
                        {
                            await _iter71.WriteAsync(oprot, cancellationToken);
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
            var other = that as TNodeMemoryInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.host_name            == other.isset.host_name)            && ((!isset.host_name)            || (System.Object.Equals(Host_name,            other.Host_name))))
                && ((isset.page_size            == other.isset.page_size)            && ((!isset.page_size)            || (System.Object.Equals(Page_size,            other.Page_size))))
                && ((isset.max_num_pages        == other.isset.max_num_pages)        && ((!isset.max_num_pages)        || (System.Object.Equals(Max_num_pages,        other.Max_num_pages))))
                && ((isset.num_pages_allocated  == other.isset.num_pages_allocated)  && ((!isset.num_pages_allocated)  || (System.Object.Equals(Num_pages_allocated,  other.Num_pages_allocated))))
                && ((isset.is_allocation_capped == other.isset.is_allocation_capped) && ((!isset.is_allocation_capped) || (System.Object.Equals(Is_allocation_capped, other.Is_allocation_capped))))
                && ((isset.node_memory_data     == other.isset.node_memory_data)     && ((!isset.node_memory_data)     || (TCollections.Equals(Node_memory_data, other.Node_memory_data))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.host_name)
                    hashcode = (hashcode * 397) + Host_name.GetHashCode();
                if(isset.page_size)
                    hashcode = (hashcode * 397) + Page_size.GetHashCode();
                if(isset.max_num_pages)
                    hashcode = (hashcode * 397) + Max_num_pages.GetHashCode();
                if(isset.num_pages_allocated)
                    hashcode = (hashcode * 397) + Num_pages_allocated.GetHashCode();
                if(isset.is_allocation_capped)
                    hashcode = (hashcode * 397) + Is_allocation_capped.GetHashCode();
                if(isset.node_memory_data)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Node_memory_data);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TNodeMemoryInfo(");
            bool __first = true;
            if (Host_name != null && isset.host_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Host_name: ");
                sb.Append(Host_name);
            }
            if (isset.page_size)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Page_size: ");
                sb.Append(Page_size);
            }
            if (isset.max_num_pages)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Max_num_pages: ");
                sb.Append(Max_num_pages);
            }
            if (isset.num_pages_allocated)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_pages_allocated: ");
                sb.Append(Num_pages_allocated);
            }
            if (isset.is_allocation_capped)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_allocation_capped: ");
                sb.Append(Is_allocation_capped);
            }
            if (Node_memory_data != null && isset.node_memory_data)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Node_memory_data: ");
                sb.Append(Node_memory_data);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

