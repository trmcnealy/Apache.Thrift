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
    public class TPendingQuery : TBase
    {
        private long                        _id;
        private List<TColumnRange>          _column_ranges;
        private List<TDictionaryGeneration> _dictionary_generations;
        private List<TTableGeneration>      _table_generations;

        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                isset.id = true;
                _id   = value;
            }
        }

        public List<TColumnRange> Column_ranges
        {
            get
            {
                return _column_ranges;
            }
            set
            {
                isset.column_ranges = true;
                _column_ranges   = value;
            }
        }

        public List<TDictionaryGeneration> Dictionary_generations
        {
            get
            {
                return _dictionary_generations;
            }
            set
            {
                isset.dictionary_generations = true;
                _dictionary_generations   = value;
            }
        }

        public List<TTableGeneration> Table_generations
        {
            get
            {
                return _table_generations;
            }
            set
            {
                isset.table_generations = true;
                _table_generations   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool id;
            public bool column_ranges;
            public bool dictionary_generations;
            public bool table_generations;
        }

        public TPendingQuery()
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
                                Id = await iprot.ReadI64Async(cancellationToken);
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
                                    TList _list84 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Column_ranges = new List<TColumnRange>(_list84.Count);
                                    for(int _i85 = 0; _i85 < _list84.Count; ++_i85)
                                    {
                                        TColumnRange _elem86;
                                        _elem86 = new TColumnRange();
                                        await _elem86.ReadAsync(iprot, cancellationToken);
                                        Column_ranges.Add(_elem86);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list87 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Dictionary_generations = new List<TDictionaryGeneration>(_list87.Count);
                                    for(int _i88 = 0; _i88 < _list87.Count; ++_i88)
                                    {
                                        TDictionaryGeneration _elem89;
                                        _elem89 = new TDictionaryGeneration();
                                        await _elem89.ReadAsync(iprot, cancellationToken);
                                        Dictionary_generations.Add(_elem89);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list90 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Table_generations = new List<TTableGeneration>(_list90.Count);
                                    for(int _i91 = 0; _i91 < _list90.Count; ++_i91)
                                    {
                                        TTableGeneration _elem92;
                                        _elem92 = new TTableGeneration();
                                        await _elem92.ReadAsync(iprot, cancellationToken);
                                        Table_generations.Add(_elem92);
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
                var struc = new TStruct("TPendingQuery");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.id)
                {
                    field.Name = "id";
                    field.Type = TType.I64;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Id, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Column_ranges != null && isset.column_ranges)
                {
                    field.Name = "column_ranges";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Column_ranges.Count), cancellationToken);
                        foreach (TColumnRange _iter93 in Column_ranges)
                        {
                            await _iter93.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Dictionary_generations != null && isset.dictionary_generations)
                {
                    field.Name = "dictionary_generations";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Dictionary_generations.Count), cancellationToken);
                        foreach (TDictionaryGeneration _iter94 in Dictionary_generations)
                        {
                            await _iter94.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Table_generations != null && isset.table_generations)
                {
                    field.Name = "table_generations";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Table_generations.Count), cancellationToken);
                        foreach (TTableGeneration _iter95 in Table_generations)
                        {
                            await _iter95.WriteAsync(oprot, cancellationToken);
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
            var other = that as TPendingQuery;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.id                     == other.isset.id)                     && ((!isset.id)                     || (System.Object.Equals(Id, other.Id))))
                && ((isset.column_ranges          == other.isset.column_ranges)          && ((!isset.column_ranges)          || (TCollections.Equals(Column_ranges,          other.Column_ranges))))
                && ((isset.dictionary_generations == other.isset.dictionary_generations) && ((!isset.dictionary_generations) || (TCollections.Equals(Dictionary_generations, other.Dictionary_generations))))
                && ((isset.table_generations      == other.isset.table_generations)      && ((!isset.table_generations)      || (TCollections.Equals(Table_generations,      other.Table_generations))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.id)
                    hashcode = (hashcode * 397) + Id.GetHashCode();
                if(isset.column_ranges)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Column_ranges);
                if(isset.dictionary_generations)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Dictionary_generations);
                if(isset.table_generations)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Table_generations);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TPendingQuery(");
            bool __first = true;
            if (isset.id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Id: ");
                sb.Append(Id);
            }
            if (Column_ranges != null && isset.column_ranges)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Column_ranges: ");
                sb.Append(Column_ranges);
            }
            if (Dictionary_generations != null && isset.dictionary_generations)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Dictionary_generations: ");
                sb.Append(Dictionary_generations);
            }
            if (Table_generations != null && isset.table_generations)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Table_generations: ");
                sb.Append(Table_generations);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

