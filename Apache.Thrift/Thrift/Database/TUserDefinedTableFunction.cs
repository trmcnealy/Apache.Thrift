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
    public class TUserDefinedTableFunction : TBase
    {
        private string                 _name;
        private TOutputBufferSizeType  _sizerType;
        private int                    _sizerArgPos;
        private List<TExtArgumentType> _inputArgTypes;
        private List<TExtArgumentType> _outputArgTypes;
        private List<TExtArgumentType> _sqlArgTypes;

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

        /// <summary>
        /// 
        /// <seealso cref="TOutputBufferSizeType"/>
        /// </summary>
        public TOutputBufferSizeType SizerType
        {
            get
            {
                return _sizerType;
            }
            set
            {
                isset.sizerType = true;
                _sizerType   = value;
            }
        }

        public int SizerArgPos
        {
            get
            {
                return _sizerArgPos;
            }
            set
            {
                isset.sizerArgPos = true;
                _sizerArgPos   = value;
            }
        }

        public List<TExtArgumentType> InputArgTypes
        {
            get
            {
                return _inputArgTypes;
            }
            set
            {
                isset.inputArgTypes = true;
                _inputArgTypes   = value;
            }
        }

        public List<TExtArgumentType> OutputArgTypes
        {
            get
            {
                return _outputArgTypes;
            }
            set
            {
                isset.outputArgTypes = true;
                _outputArgTypes   = value;
            }
        }

        public List<TExtArgumentType> SqlArgTypes
        {
            get
            {
                return _sqlArgTypes;
            }
            set
            {
                isset.sqlArgTypes = true;
                _sqlArgTypes   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool name;
            public bool sizerType;
            public bool sizerArgPos;
            public bool inputArgTypes;
            public bool outputArgTypes;
            public bool sqlArgTypes;
        }

        public TUserDefinedTableFunction()
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
                            if (field.Type == TType.I32)
                            {
                                SizerType = (TOutputBufferSizeType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I32)
                            {
                                SizerArgPos = await iprot.ReadI32Async(cancellationToken);
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
                                    TList _list4 = await iprot.ReadListBeginAsync(cancellationToken);
                                    InputArgTypes = new List<TExtArgumentType>(_list4.Count);
                                    for(int _i5 = 0; _i5 < _list4.Count; ++_i5)
                                    {
                                        TExtArgumentType _elem6;
                                        _elem6 = (TExtArgumentType)await iprot.ReadI32Async(cancellationToken);
                                        InputArgTypes.Add(_elem6);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
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
                                    TList _list7 = await iprot.ReadListBeginAsync(cancellationToken);
                                    OutputArgTypes = new List<TExtArgumentType>(_list7.Count);
                                    for(int _i8 = 0; _i8 < _list7.Count; ++_i8)
                                    {
                                        TExtArgumentType _elem9;
                                        _elem9 = (TExtArgumentType)await iprot.ReadI32Async(cancellationToken);
                                        OutputArgTypes.Add(_elem9);
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
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list10 = await iprot.ReadListBeginAsync(cancellationToken);
                                    SqlArgTypes = new List<TExtArgumentType>(_list10.Count);
                                    for(int _i11 = 0; _i11 < _list10.Count; ++_i11)
                                    {
                                        TExtArgumentType _elem12;
                                        _elem12 = (TExtArgumentType)await iprot.ReadI32Async(cancellationToken);
                                        SqlArgTypes.Add(_elem12);
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
                var struc = new TStruct("TUserDefinedTableFunction");
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
                if (isset.sizerType)
                {
                    field.Name = "sizerType";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)SizerType, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.sizerArgPos)
                {
                    field.Name = "sizerArgPos";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(SizerArgPos, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (InputArgTypes != null && isset.inputArgTypes)
                {
                    field.Name = "inputArgTypes";
                    field.Type = TType.List;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, InputArgTypes.Count), cancellationToken);
                        foreach (TExtArgumentType _iter13 in InputArgTypes)
                        {
                            await oprot.WriteI32Async((int)_iter13, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (OutputArgTypes != null && isset.outputArgTypes)
                {
                    field.Name = "outputArgTypes";
                    field.Type = TType.List;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, OutputArgTypes.Count), cancellationToken);
                        foreach (TExtArgumentType _iter14 in OutputArgTypes)
                        {
                            await oprot.WriteI32Async((int)_iter14, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (SqlArgTypes != null && isset.sqlArgTypes)
                {
                    field.Name = "sqlArgTypes";
                    field.Type = TType.List;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.I32, SqlArgTypes.Count), cancellationToken);
                        foreach (TExtArgumentType _iter15 in SqlArgTypes)
                        {
                            await oprot.WriteI32Async((int)_iter15, cancellationToken);
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
            var other = that as TUserDefinedTableFunction;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.name           == other.isset.name)           && ((!isset.name)           || (System.Object.Equals(Name,        other.Name))))
                && ((isset.sizerType      == other.isset.sizerType)      && ((!isset.sizerType)      || (System.Object.Equals(SizerType,   other.SizerType))))
                && ((isset.sizerArgPos    == other.isset.sizerArgPos)    && ((!isset.sizerArgPos)    || (System.Object.Equals(SizerArgPos, other.SizerArgPos))))
                && ((isset.inputArgTypes  == other.isset.inputArgTypes)  && ((!isset.inputArgTypes)  || (TCollections.Equals(InputArgTypes,  other.InputArgTypes))))
                && ((isset.outputArgTypes == other.isset.outputArgTypes) && ((!isset.outputArgTypes) || (TCollections.Equals(OutputArgTypes, other.OutputArgTypes))))
                && ((isset.sqlArgTypes    == other.isset.sqlArgTypes)    && ((!isset.sqlArgTypes)    || (TCollections.Equals(SqlArgTypes,    other.SqlArgTypes))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.name)
                    hashcode = (hashcode * 397) + Name.GetHashCode();
                if(isset.sizerType)
                    hashcode = (hashcode * 397) + SizerType.GetHashCode();
                if(isset.sizerArgPos)
                    hashcode = (hashcode * 397) + SizerArgPos.GetHashCode();
                if(isset.inputArgTypes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(InputArgTypes);
                if(isset.outputArgTypes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(OutputArgTypes);
                if(isset.sqlArgTypes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(SqlArgTypes);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TUserDefinedTableFunction(");
            bool __first = true;
            if (Name != null && isset.name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Name: ");
                sb.Append(Name);
            }
            if (isset.sizerType)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("SizerType: ");
                sb.Append(SizerType);
            }
            if (isset.sizerArgPos)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("SizerArgPos: ");
                sb.Append(SizerArgPos);
            }
            if (InputArgTypes != null && isset.inputArgTypes)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("InputArgTypes: ");
                sb.Append(InputArgTypes);
            }
            if (OutputArgTypes != null && isset.outputArgTypes)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("OutputArgTypes: ");
                sb.Append(OutputArgTypes);
            }
            if (SqlArgTypes != null && isset.sqlArgTypes)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("SqlArgTypes: ");
                sb.Append(SqlArgTypes);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

