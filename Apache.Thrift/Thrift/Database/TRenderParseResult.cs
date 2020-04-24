using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TRenderParseResult : TBase
    {
        private TMergeType _merge_type;
        private int        _node_id;
        private long       _execution_time_ms;
        private long       _render_time_ms;
        private long       _total_time_ms;

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
            public bool merge_type;
            public bool node_id;
            public bool execution_time_ms;
            public bool render_time_ms;
            public bool total_time_ms;
        }

        public TRenderParseResult()
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
                                Merge_type = (TMergeType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                Node_id = await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TRenderParseResult");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.merge_type)
                {
                    field.Name = "merge_type";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Merge_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.node_id)
                {
                    field.Name = "node_id";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Node_id, cancellationToken);
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
            var other = that as TRenderParseResult;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.merge_type        == other.isset.merge_type)        && ((!isset.merge_type)        || (System.Object.Equals(Merge_type,        other.Merge_type))))
                && ((isset.node_id           == other.isset.node_id)           && ((!isset.node_id)           || (System.Object.Equals(Node_id,           other.Node_id))))
                && ((isset.execution_time_ms == other.isset.execution_time_ms) && ((!isset.execution_time_ms) || (System.Object.Equals(Execution_time_ms, other.Execution_time_ms))))
                && ((isset.render_time_ms    == other.isset.render_time_ms)    && ((!isset.render_time_ms)    || (System.Object.Equals(Render_time_ms,    other.Render_time_ms))))
                && ((isset.total_time_ms     == other.isset.total_time_ms)     && ((!isset.total_time_ms)     || (System.Object.Equals(Total_time_ms,     other.Total_time_ms))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.merge_type)
                    hashcode = (hashcode * 397) + Merge_type.GetHashCode();
                if(isset.node_id)
                    hashcode = (hashcode * 397) + Node_id.GetHashCode();
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
            var  sb      = new StringBuilder("TRenderParseResult(");
            bool __first = true;
            if (isset.merge_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Merge_type: ");
                sb.Append(Merge_type);
            }
            if (isset.node_id)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Node_id: ");
                sb.Append(Node_id);
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

