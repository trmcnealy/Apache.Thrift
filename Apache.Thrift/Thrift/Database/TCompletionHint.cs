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
    public class TCompletionHint : TBase
    {
        private TCompletionHintType _type;
        private List<string>        _hints;
        private string              _replaced;

        /// <summary>
        /// 
        /// <seealso cref="TCompletionHintType"/>
        /// </summary>
        public TCompletionHintType Type
        {
            get
            {
                return _type;
            }
            set
            {
                isset.type = true;
                _type   = value;
            }
        }

        public List<string> Hints
        {
            get
            {
                return _hints;
            }
            set
            {
                isset.hints = true;
                _hints   = value;
            }
        }

        public string Replaced
        {
            get
            {
                return _replaced;
            }
            set
            {
                isset.replaced = true;
                _replaced   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool type;
            public bool hints;
            public bool replaced;
        }

        public TCompletionHint()
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
                                Type = (TCompletionHintType)await iprot.ReadI32Async(cancellationToken);
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
                                    TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Hints = new List<string>(_list0.Count);
                                    for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                                    {
                                        string _elem2;
                                        _elem2 = await iprot.ReadStringAsync(cancellationToken);
                                        Hints.Add(_elem2);
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
                            if (field.Type == TType.String)
                            {
                                Replaced = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TCompletionHint");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (isset.type)
                {
                    field.Name = "type";
                    field.Type = TType.I32;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Hints != null && isset.hints)
                {
                    field.Name = "hints";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Hints.Count), cancellationToken);
                        foreach (string _iter3 in Hints)
                        {
                            await oprot.WriteStringAsync(_iter3, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Replaced != null && isset.replaced)
                {
                    field.Name = "replaced";
                    field.Type = TType.String;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Replaced, cancellationToken);
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
            var other = that as TCompletionHint;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.type     == other.isset.type)     && ((!isset.type)     || (System.Object.Equals(Type, other.Type))))
                && ((isset.hints    == other.isset.hints)    && ((!isset.hints)    || (TCollections.Equals(Hints, other.Hints))))
                && ((isset.replaced == other.isset.replaced) && ((!isset.replaced) || (System.Object.Equals(Replaced, other.Replaced))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.type)
                    hashcode = (hashcode * 397) + Type.GetHashCode();
                if(isset.hints)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Hints);
                if(isset.replaced)
                    hashcode = (hashcode * 397) + Replaced.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCompletionHint(");
            bool __first = true;
            if (isset.type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Type: ");
                sb.Append(Type);
            }
            if (Hints != null && isset.hints)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Hints: ");
                sb.Append(Hints);
            }
            if (Replaced != null && isset.replaced)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Replaced: ");
                sb.Append(Replaced);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

