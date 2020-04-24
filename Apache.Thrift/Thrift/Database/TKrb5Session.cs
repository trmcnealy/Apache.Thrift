using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TKrb5Session : TBase
    {
        private string _sessionId;
        private string _krbToken;

        public string SessionId
        {
            get { return _sessionId; }
            set
            {
                isset.sessionId = true;
                _sessionId        = value;
            }
        }

        public string KrbToken
        {
            get { return _krbToken; }
            set
            {
                isset.krbToken = true;
                _krbToken        = value;
            }
        }

        public Isset isset;

        public struct Isset
        {
            public bool sessionId;
            public bool krbToken;
        }

        public TKrb5Session()
        {
        }

        public async Task ReadAsync(TProtocol         iprot,
                                    CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();

            try
            {
                TField field;
                await iprot.ReadStructBeginAsync(cancellationToken);

                while(true)
                {
                    field = await iprot.ReadFieldBeginAsync(cancellationToken);

                    if(field.Type == TType.Stop)
                    {
                        break;
                    }

                    switch(field.ID)
                    {
                        case 1:
                            if(field.Type == TType.String)
                            {
                                SessionId = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        case 2:
                            if(field.Type == TType.String)
                            {
                                KrbToken = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot,
                                                              field.Type,
                                                              cancellationToken);
                            }

                            break;
                        default:
                            await TProtocolUtil.SkipAsync(iprot,
                                                          field.Type,
                                                          cancellationToken);

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

        public async Task WriteAsync(TProtocol         oprot,
                                     CancellationToken cancellationToken)
        {
            oprot.IncrementRecursionDepth();

            try
            {
                var struc = new TStruct("TKrb5Session");

                await oprot.WriteStructBeginAsync(struc,
                                                  cancellationToken);

                var field = new TField();

                if(SessionId != null && isset.sessionId)
                {
                    field.Name = "sessionId";
                    field.Type = TType.String;
                    field.ID   = 1;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(SessionId,
                                                 cancellationToken);

                    await oprot.WriteFieldEndAsync(cancellationToken);
                }

                if(KrbToken != null && isset.krbToken)
                {
                    field.Name = "krbToken";
                    field.Type = TType.String;
                    field.ID   = 2;

                    await oprot.WriteFieldBeginAsync(field,
                                                     cancellationToken);

                    await oprot.WriteStringAsync(KrbToken,
                                                 cancellationToken);

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
            TKrb5Session other = that as TKrb5Session;

            if(other == null)
            {
                return false;
            }

            if(ReferenceEquals(this,
                               other))
            {
                return true;
            }

            return isset.sessionId == other.isset.sessionId &&
                   (!isset.sessionId ||
                    Equals(SessionId,
                           other.SessionId))                  &&
                   isset.krbToken == other.isset.krbToken &&
                   (!isset.krbToken ||
                    Equals(KrbToken,
                           other.KrbToken));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;

            unchecked
            {
                if(isset.sessionId)
                {
                    hashcode = hashcode * 397 + SessionId.GetHashCode();
                }

                if(isset.krbToken)
                {
                    hashcode = hashcode * 397 + KrbToken.GetHashCode();
                }
            }

            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TKrb5Session(");
            bool __first = true;

            if(SessionId != null && isset.sessionId)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("SessionId: ");
                sb.Append(SessionId);
            }

            if(KrbToken != null && isset.krbToken)
            {
                if(!__first)
                {
                    sb.Append(", ");
                }

                __first = false;
                sb.Append("KrbToken: ");
                sb.Append(KrbToken);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}