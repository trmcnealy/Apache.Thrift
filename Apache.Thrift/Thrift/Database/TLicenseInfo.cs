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
    public class TLicenseInfo : TBase
    {
        private List<string> _claims;

        public List<string> Claims
        {
            get
            {
                return _claims;
            }
            set
            {
                isset.claims = true;
                _claims   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool claims;
        }

        public TLicenseInfo()
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
                                    TList _list141 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Claims = new List<string>(_list141.Count);
                                    for(int _i142 = 0; _i142 < _list141.Count; ++_i142)
                                    {
                                        string _elem143;
                                        _elem143 = await iprot.ReadStringAsync(cancellationToken);
                                        Claims.Add(_elem143);
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
                var struc = new TStruct("TLicenseInfo");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Claims != null && isset.claims)
                {
                    field.Name = "claims";
                    field.Type = TType.List;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.String, Claims.Count), cancellationToken);
                        foreach (string _iter144 in Claims)
                        {
                            await oprot.WriteStringAsync(_iter144, cancellationToken);
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
            var other = that as TLicenseInfo;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.claims == other.isset.claims) && ((!isset.claims) || (TCollections.Equals(Claims, other.Claims))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.claims)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Claims);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TLicenseInfo(");
            bool __first = true;
            if (Claims != null && isset.claims)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Claims: ");
                sb.Append(Claims);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

