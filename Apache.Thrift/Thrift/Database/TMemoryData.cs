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
    public class TMemoryData : TBase
    {
        private long       _slab;
        private int        _start_page;
        private long       _num_pages;
        private int        _touch;
        private List<long> _chunk_key;
        private int        _buffer_epoch;
        private bool       _is_free;

        public long Slab
        {
            get
            {
                return _slab;
            }
            set
            {
                isset.slab = true;
                _slab   = value;
            }
        }

        public int Start_page
        {
            get
            {
                return _start_page;
            }
            set
            {
                isset.start_page = true;
                _start_page   = value;
            }
        }

        public long Num_pages
        {
            get
            {
                return _num_pages;
            }
            set
            {
                isset.num_pages = true;
                _num_pages   = value;
            }
        }

        public int Touch
        {
            get
            {
                return _touch;
            }
            set
            {
                isset.touch = true;
                _touch   = value;
            }
        }

        public List<long> Chunk_key
        {
            get
            {
                return _chunk_key;
            }
            set
            {
                isset.chunk_key = true;
                _chunk_key   = value;
            }
        }

        public int Buffer_epoch
        {
            get
            {
                return _buffer_epoch;
            }
            set
            {
                isset.buffer_epoch = true;
                _buffer_epoch   = value;
            }
        }

        public bool Is_free
        {
            get
            {
                return _is_free;
            }
            set
            {
                isset.is_free = true;
                _is_free   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool slab;
            public bool start_page;
            public bool num_pages;
            public bool touch;
            public bool chunk_key;
            public bool buffer_epoch;
            public bool is_free;
        }

        public TMemoryData()
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
                            if (field.Type == TType.I64)
                            {
                                Slab = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Start_page = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I64)
                            {
                                Num_pages = await iprot.ReadI64Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                Touch = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list64 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Chunk_key = new List<long>(_list64.Count);
                                    for(int _i65 = 0; _i65 < _list64.Count; ++_i65)
                                    {
                                        long _elem66;
                                        _elem66 = await iprot.ReadI64Async(cancellationToken);
                                        Chunk_key.Add(_elem66);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.I32)
                            {
                                Buffer_epoch = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.Bool)
                            {
                                Is_free = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TMemoryData");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.slab)
                {
                    field.Name = "slab";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Slab, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.start_page)
                {
                    field.Name = "start_page";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Start_page, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.num_pages)
                {
                    field.Name = "num_pages";
                    field.Type = TType.I64;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Num_pages, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.touch)
                {
                    field.Name = "touch";
                    field.Type = TType.I32;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Touch, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Chunk_key != null && isset.chunk_key)
                {
                    field.Name = "chunk_key";
                    field.Type = TType.List;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I64, Chunk_key.Count), cancellationToken);
                        foreach (long _iter67 in Chunk_key)
                        {
                            await oprot.WriteI64Async(_iter67, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.buffer_epoch)
                {
                    field.Name = "buffer_epoch";
                    field.Type = TType.I32;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Buffer_epoch, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.is_free)
                {
                    field.Name = "is_free";
                    field.Type = TType.Bool;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Is_free, cancellationToken);
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
            var other = that as TMemoryData;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.slab         == other.isset.slab)         && ((!isset.slab)         || (System.Object.Equals(Slab,       other.Slab))))
                && ((isset.start_page   == other.isset.start_page)   && ((!isset.start_page)   || (System.Object.Equals(Start_page, other.Start_page))))
                && ((isset.num_pages    == other.isset.num_pages)    && ((!isset.num_pages)    || (System.Object.Equals(Num_pages,  other.Num_pages))))
                && ((isset.touch        == other.isset.touch)        && ((!isset.touch)        || (System.Object.Equals(Touch,      other.Touch))))
                && ((isset.chunk_key    == other.isset.chunk_key)    && ((!isset.chunk_key)    || (TCollections.Equals(Chunk_key, other.Chunk_key))))
                && ((isset.buffer_epoch == other.isset.buffer_epoch) && ((!isset.buffer_epoch) || (System.Object.Equals(Buffer_epoch, other.Buffer_epoch))))
                && ((isset.is_free      == other.isset.is_free)      && ((!isset.is_free)      || (System.Object.Equals(Is_free,      other.Is_free))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.slab)
                    hashcode = (hashcode * 397) + Slab.GetHashCode();
                if(isset.start_page)
                    hashcode = (hashcode * 397) + Start_page.GetHashCode();
                if(isset.num_pages)
                    hashcode = (hashcode * 397) + Num_pages.GetHashCode();
                if(isset.touch)
                    hashcode = (hashcode * 397) + Touch.GetHashCode();
                if(isset.chunk_key)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Chunk_key);
                if(isset.buffer_epoch)
                    hashcode = (hashcode * 397) + Buffer_epoch.GetHashCode();
                if(isset.is_free)
                    hashcode = (hashcode * 397) + Is_free.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TMemoryData(");
            bool __first = true;
            if (isset.slab)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Slab: ");
                sb.Append(Slab);
            }
            if (isset.start_page)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Start_page: ");
                sb.Append(Start_page);
            }
            if (isset.num_pages)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Num_pages: ");
                sb.Append(Num_pages);
            }
            if (isset.touch)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Touch: ");
                sb.Append(Touch);
            }
            if (Chunk_key != null && isset.chunk_key)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Chunk_key: ");
                sb.Append(Chunk_key);
            }
            if (isset.buffer_epoch)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Buffer_epoch: ");
                sb.Append(Buffer_epoch);
            }
            if (isset.is_free)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Is_free: ");
                sb.Append(Is_free);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

