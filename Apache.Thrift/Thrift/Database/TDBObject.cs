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
    public class TDBObject : TBase
    {
        private string        _objectName;
        private TDBObjectType _objectType;
        private List<bool>    _privs;
        private string        _grantee;
        private TDBObjectType _privilegeObjectType;

        public string ObjectName
        {
            get
            {
                return _objectName;
            }
            set
            {
                isset.objectName = true;
                _objectName   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TDBObjectType"/>
        /// </summary>
        public TDBObjectType ObjectType
        {
            get
            {
                return _objectType;
            }
            set
            {
                isset.objectType = true;
                _objectType   = value;
            }
        }

        public List<bool> Privs
        {
            get
            {
                return _privs;
            }
            set
            {
                isset.privs = true;
                _privs   = value;
            }
        }

        public string Grantee
        {
            get
            {
                return _grantee;
            }
            set
            {
                isset.grantee = true;
                _grantee   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TDBObjectType"/>
        /// </summary>
        public TDBObjectType PrivilegeObjectType
        {
            get
            {
                return _privilegeObjectType;
            }
            set
            {
                isset.privilegeObjectType = true;
                _privilegeObjectType   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool objectName;
            public bool objectType;
            public bool privs;
            public bool grantee;
            public bool privilegeObjectType;
        }

        public TDBObject()
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
                                ObjectName = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.I32)
                            {
                                ObjectType = (TDBObjectType)await iprot.ReadI32Async(cancellationToken);
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
                                    TList _list137 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Privs = new List<bool>(_list137.Count);
                                    for(int _i138 = 0; _i138 < _list137.Count; ++_i138)
                                    {
                                        bool _elem139;
                                        _elem139 = await iprot.ReadBoolAsync(cancellationToken);
                                        Privs.Add(_elem139);
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
                            if (field.Type == TType.String)
                            {
                                Grantee = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I32)
                            {
                                PrivilegeObjectType = (TDBObjectType)await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TDBObject");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (ObjectName != null && isset.objectName)
                {
                    field.Name = "objectName";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(ObjectName, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.objectType)
                {
                    field.Name = "objectType";
                    field.Type = TType.I32;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)ObjectType, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Privs != null && isset.privs)
                {
                    field.Name = "privs";
                    field.Type = TType.List;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Bool, Privs.Count), cancellationToken);
                        foreach (bool _iter140 in Privs)
                        {
                            await oprot.WriteBoolAsync(_iter140, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Grantee != null && isset.grantee)
                {
                    field.Name = "grantee";
                    field.Type = TType.String;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Grantee, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.privilegeObjectType)
                {
                    field.Name = "privilegeObjectType";
                    field.Type = TType.I32;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)PrivilegeObjectType, cancellationToken);
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
            var other = that as TDBObject;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.objectName          == other.isset.objectName)          && ((!isset.objectName)          || (System.Object.Equals(ObjectName, other.ObjectName))))
                && ((isset.objectType          == other.isset.objectType)          && ((!isset.objectType)          || (System.Object.Equals(ObjectType, other.ObjectType))))
                && ((isset.privs               == other.isset.privs)               && ((!isset.privs)               || (TCollections.Equals(Privs, other.Privs))))
                && ((isset.grantee             == other.isset.grantee)             && ((!isset.grantee)             || (System.Object.Equals(Grantee,             other.Grantee))))
                && ((isset.privilegeObjectType == other.isset.privilegeObjectType) && ((!isset.privilegeObjectType) || (System.Object.Equals(PrivilegeObjectType, other.PrivilegeObjectType))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.objectName)
                    hashcode = (hashcode * 397) + ObjectName.GetHashCode();
                if(isset.objectType)
                    hashcode = (hashcode * 397) + ObjectType.GetHashCode();
                if(isset.privs)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Privs);
                if(isset.grantee)
                    hashcode = (hashcode * 397) + Grantee.GetHashCode();
                if(isset.privilegeObjectType)
                    hashcode = (hashcode * 397) + PrivilegeObjectType.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TDBObject(");
            bool __first = true;
            if (ObjectName != null && isset.objectName)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("ObjectName: ");
                sb.Append(ObjectName);
            }
            if (isset.objectType)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("ObjectType: ");
                sb.Append(ObjectType);
            }
            if (Privs != null && isset.privs)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Privs: ");
                sb.Append(Privs);
            }
            if (Grantee != null && isset.grantee)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Grantee: ");
                sb.Append(Grantee);
            }
            if (isset.privilegeObjectType)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("PrivilegeObjectType: ");
                sb.Append(PrivilegeObjectType);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

