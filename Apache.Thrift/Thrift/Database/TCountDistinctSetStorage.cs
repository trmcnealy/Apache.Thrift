using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Collections;
using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TCountDistinctSetStorage : TBase
    {
        private byte[]         _bitmap;
        private THashSet<long> _sparse_set;

        public byte[] Bitmap
        {
            get
            {
                return _bitmap;
            }
            set
            {
                isset.bitmap = true;
                _bitmap   = value;
            }
        }

        public THashSet<long> Sparse_set
        {
            get
            {
                return _sparse_set;
            }
            set
            {
                isset.sparse_set = true;
                _sparse_set   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool bitmap;
            public bool sparse_set;
        }

        public TCountDistinctSetStorage()
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
                                Bitmap = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.Set)
                            {
                                {
                                    TSet _set24 = await iprot.ReadSetBeginAsync(cancellationToken);
                                    Sparse_set = new THashSet<long>(_set24.Count);
                                    for(int _i25 = 0; _i25 < _set24.Count; ++_i25)
                                    {
                                        long _elem26;
                                        _elem26 = await iprot.ReadI64Async(cancellationToken);
                                        Sparse_set.Add(_elem26);
                                    }
                                    await iprot.ReadSetEndAsync(cancellationToken);
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
                var struc = new TStruct("TCountDistinctSetStorage");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Bitmap != null && isset.bitmap)
                {
                    field.Name = "bitmap";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(Bitmap, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Sparse_set != null && isset.sparse_set)
                {
                    field.Name = "sparse_set";
                    field.Type = TType.Set;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteSetBeginAsync(new TSet(TType.I64, Sparse_set.Count), cancellationToken);
                        foreach (long _iter27 in Sparse_set)
                        {
                            await oprot.WriteI64Async(_iter27, cancellationToken);
                        }
                        await oprot.WriteSetEndAsync(cancellationToken);
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
            var other = that as TCountDistinctSetStorage;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.bitmap     == other.isset.bitmap)     && ((!isset.bitmap)     || (TCollections.Equals(Bitmap,     other.Bitmap))))
                && ((isset.sparse_set == other.isset.sparse_set) && ((!isset.sparse_set) || (TCollections.Equals(Sparse_set, other.Sparse_set))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.bitmap)
                    hashcode = (hashcode * 397) + Bitmap.GetHashCode();
                if(isset.sparse_set)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Sparse_set);
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCountDistinctSetStorage(");
            bool __first = true;
            if (Bitmap != null && isset.bitmap)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Bitmap: ");
                sb.Append(Bitmap);
            }
            if (Sparse_set != null && isset.sparse_set)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Sparse_set: ");
                sb.Append(Sparse_set);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

