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
    public class TUserDefinedFunction : TBase
    {
        private string                 _name;
        private List<TExtArgumentType> _argTypes;
        private TExtArgumentType       _retType;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                isset.name = true;
                _name   = value;
            }
        }

        public List<TExtArgumentType> ArgTypes
        {
            get
            {
                return _argTypes;
            }
            set
            {
                isset.argTypes = true;
                _argTypes   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TExtArgumentType"/>
        /// </summary>
        public TExtArgumentType RetType
        {
            get
            {
                return _retType;
            }
            set
            {
                isset.retType = true;
                _retType   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool name;
            public bool argTypes;
            public bool retType;
        }

        public TUserDefinedFunction()
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
                                Name = await iprot.ReadStringAsync(cancellationToken);
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
                                    ArgTypes = new List<TExtArgumentType>(_list0.Count);
                                    for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                                    {
                                        TExtArgumentType _elem2;
                                        _elem2 = (TExtArgumentType)await iprot.ReadI32Async(cancellationToken);
                                        ArgTypes.Add(_elem2);
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
                            if (field.Type == TType.I32)
                            {
                                RetType = (TExtArgumentType)await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TUserDefinedFunction");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Name != null && isset.name)
                {
                    field.Name = "name";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (ArgTypes != null && isset.argTypes)
                {
                    field.Name = "argTypes";
                    field.Type = TType.List;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, ArgTypes.Count), cancellationToken);
                        foreach (TExtArgumentType _iter3 in ArgTypes)
                        {
                            await oprot.WriteI32Async((int)_iter3, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.retType)
                {
                    field.Name = "retType";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)RetType, cancellationToken);
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
            var other = that as TUserDefinedFunction;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.name     == other.isset.name)     && ((!isset.name)     || (System.Object.Equals(Name, other.Name))))
                && ((isset.argTypes == other.isset.argTypes) && ((!isset.argTypes) || (TCollections.Equals(ArgTypes, other.ArgTypes))))
                && ((isset.retType  == other.isset.retType)  && ((!isset.retType)  || (System.Object.Equals(RetType, other.RetType))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.name)
                    hashcode = (hashcode * 397) + Name.GetHashCode();
                if(isset.argTypes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(ArgTypes);
                if(isset.retType)
                    hashcode = (hashcode * 397) + RetType.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TUserDefinedFunction(");
            bool __first = true;
            if (Name != null && isset.name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Name: ");
                sb.Append(Name);
            }
            if (ArgTypes != null && isset.argTypes)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("ArgTypes: ");
                sb.Append(ArgTypes);
            }
            if (isset.retType)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("RetType: ");
                sb.Append(RetType);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

