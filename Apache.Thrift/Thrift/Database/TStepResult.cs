using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TStepResult : TBase
    {
        private TSerializedRows   _serialized_rows;
        private bool              _execution_finished;
        private TMergeType        _merge_type;
        private bool              _sharded;
        private List<TColumnType> _row_desc;
        private int               _node_id;

        public TSerializedRows Serialized_rows
        {
            get
            {
                return _serialized_rows;
            }
            set
            {
                isset.serialized_rows = true;
                _serialized_rows   = value;
            }
        }

        public bool Execution_finished
        {
            get
            {
                return _execution_finished;
            }
            set
            {
                isset.execution_finished = true;
                _execution_finished   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TMergeType"/>
        /// </summary>
        public TMergeType Merge_type
        {
            get
            {
                return _merge_type;
            }
            set
            {
                isset.merge_type = true;
                _merge_type   = value;
            }
        }

        public bool Sharded
        {
            get
            {
                return _sharded;
            }
            set
            {
                isset.sharded = true;
                _sharded   = value;
            }
        }

        public List<TColumnType> Row_desc
        {
            get
            {
                return _row_desc;
            }
            set
            {
                isset.row_desc = true;
                _row_desc   = value;
            }
        }

        public int Node_id
        {
            get
            {
                return _node_id;
            }
            set
            {
                isset.node_id = true;
                _node_id   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool serialized_rows;
            public bool execution_finished;
            public bool merge_type;
            public bool sharded;
            public bool row_desc;
            public bool node_id;
        }

        public TStepResult()
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
                            if (field.Type == TType.Struct)
                            {
                                Serialized_rows = new TSerializedRows();
                                await Serialized_rows.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Bool)
                            {
                                Execution_finished = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I32)
                            {
                                Merge_type = (TMergeType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Sharded = await iprot.ReadBoolAsync(cancellationToken);
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
                                    TList _list32 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Row_desc = new List<TColumnType>(_list32.Count);
                                    for(int _i33 = 0; _i33 < _list32.Count; ++_i33)
                                    {
                                        TColumnType _elem34;
                                        _elem34 = new TColumnType();
                                        await _elem34.ReadAsync(iprot, cancellationToken);
                                        Row_desc.Add(_elem34);
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
                                Node_id = await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TStepResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Serialized_rows != null && isset.serialized_rows)
                {
                    field.Name = "serialized_rows";
                    field.Type = TType.Struct;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Serialized_rows.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.execution_finished)
                {
                    field.Name = "execution_finished";
                    field.Type = TType.Bool;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Execution_finished, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.merge_type)
                {
                    field.Name = "merge_type";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Merge_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.sharded)
                {
                    field.Name = "sharded";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Sharded, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Row_desc != null && isset.row_desc)
                {
                    field.Name = "row_desc";
                    field.Type = TType.List;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Row_desc.Count), cancellationToken);
                        foreach (TColumnType _iter35 in Row_desc)
                        {
                            await _iter35.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.node_id)
                {
                    field.Name = "node_id";
                    field.Type = TType.I32;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Node_id, cancellationToken);
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
            var other = that as TStepResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.serialized_rows    == other.isset.serialized_rows)    && ((!isset.serialized_rows)    || (System.Object.Equals(Serialized_rows,    other.Serialized_rows))))
                && ((isset.execution_finished == other.isset.execution_finished) && ((!isset.execution_finished) || (System.Object.Equals(Execution_finished, other.Execution_finished))))
                && ((isset.merge_type         == other.isset.merge_type)         && ((!isset.merge_type)         || (System.Object.Equals(Merge_type,         other.Merge_type))))
                && ((isset.sharded            == other.isset.sharded)            && ((!isset.sharded)            || (System.Object.Equals(Sharded,            other.Sharded))))
                && ((isset.row_desc           == other.isset.row_desc)           && ((!isset.row_desc)           || (System.Object.Equals(Row_desc,           other.Row_desc))))
                && ((isset.node_id            == other.isset.node_id)            && ((!isset.node_id)            || (System.Object.Equals(Node_id,            other.Node_id))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.serialized_rows)
                    hashcode = (hashcode * 397) + Serialized_rows.GetHashCode();
                if(isset.execution_finished)
                    hashcode = (hashcode * 397) + Execution_finished.GetHashCode();
                if(isset.merge_type)
                    hashcode = (hashcode * 397) + Merge_type.GetHashCode();
                if(isset.sharded)
                    hashcode = (hashcode * 397) + Sharded.GetHashCode();
                if(isset.row_desc)
                    hashcode = (hashcode * 397) + Row_desc.GetHashCode();
                if(isset.node_id)
                    hashcode = (hashcode * 397) + Node_id.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TStepResult(");
            bool __first = true;
            if (Serialized_rows != null && isset.serialized_rows)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Serialized_rows: ");
                sb.Append(Serialized_rows == null ? "<null>" : Serialized_rows.ToString());
            }
            if (isset.execution_finished)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Execution_finished: ");
                sb.Append(Execution_finished);
            }
            if (isset.merge_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Merge_type: ");
                sb.Append(Merge_type);
            }
            if (isset.sharded)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Sharded: ");
                sb.Append(Sharded);
            }
            if (Row_desc != null && isset.row_desc)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Row_desc: ");
                sb.Append(Row_desc);
            }
            if (isset.node_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Node_id: ");
                sb.Append(Node_id);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

