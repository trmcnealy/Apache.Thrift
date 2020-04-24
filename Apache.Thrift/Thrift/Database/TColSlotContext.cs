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
    public class TColSlotContext : TBase
    {
        private List<TSlotSize> _slot_sizes;
        private List<List<int>> _col_to_slot_map;

        public List<TSlotSize> Slot_sizes
        {
            get
            {
                return _slot_sizes;
            }
            set
            {
                isset.slot_sizes = true;
                _slot_sizes   = value;
            }
        }

        public List<List<int>> Col_to_slot_map
        {
            get
            {
                return _col_to_slot_map;
            }
            set
            {
                isset.col_to_slot_map = true;
                _col_to_slot_map   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool slot_sizes;
            public bool col_to_slot_map;
        }

        public TColSlotContext()
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
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Slot_sizes = new List<TSlotSize>(_list0.Count);
                                    for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                                    {
                                        TSlotSize _elem2;
                                        _elem2 = new TSlotSize();
                                        await _elem2.ReadAsync(iprot, cancellationToken);
                                        Slot_sizes.Add(_elem2);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list3 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Col_to_slot_map = new List<List<int>>(_list3.Count);
                                    for(int _i4 = 0; _i4 < _list3.Count; ++_i4)
                                    {
                                        List<int> _elem5;
                                        {
                                            TList _list6 = await iprot.ReadListBeginAsync(cancellationToken);
                                            _elem5 = new List<int>(_list6.Count);
                                            for(int _i7 = 0; _i7 < _list6.Count; ++_i7)
                                            {
                                                int _elem8;
                                                _elem8 = await iprot.ReadI32Async(cancellationToken);
                                                _elem5.Add(_elem8);
                                            }
                                            await iprot.ReadListEndAsync(cancellationToken);
                                        }
                                        Col_to_slot_map.Add(_elem5);
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
                var struc = new TStruct("TColSlotContext");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Slot_sizes != null && isset.slot_sizes)
                {
                    field.Name = "slot_sizes";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Slot_sizes.Count), cancellationToken);
                        foreach (TSlotSize _iter9 in Slot_sizes)
                        {
                            await _iter9.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Col_to_slot_map != null && isset.col_to_slot_map)
                {
                    field.Name = "col_to_slot_map";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.List, Col_to_slot_map.Count), cancellationToken);
                        foreach (List<int> _iter10 in Col_to_slot_map)
                        {
                            {
                                await oprot.WriteListBeginAsync(new TList(TType.I32, _iter10.Count), cancellationToken);
                                foreach (int _iter11 in _iter10)
                                {
                                    await oprot.WriteI32Async(_iter11, cancellationToken);
                                }
                                await oprot.WriteListEndAsync(cancellationToken);
                            }
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
            var other = that as TColSlotContext;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.slot_sizes      == other.isset.slot_sizes)      && ((!isset.slot_sizes)      || (TCollections.Equals(Slot_sizes,      other.Slot_sizes))))
                && ((isset.col_to_slot_map == other.isset.col_to_slot_map) && ((!isset.col_to_slot_map) || (TCollections.Equals(Col_to_slot_map, other.Col_to_slot_map))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.slot_sizes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Slot_sizes);
                if(isset.col_to_slot_map)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Col_to_slot_map);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TColSlotContext(");
            bool __first = true;
            if (Slot_sizes != null && isset.slot_sizes)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Slot_sizes: ");
                sb.Append(Slot_sizes);
            }
            if (Col_to_slot_map != null && isset.col_to_slot_map)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Col_to_slot_map: ");
                sb.Append(Col_to_slot_map);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

