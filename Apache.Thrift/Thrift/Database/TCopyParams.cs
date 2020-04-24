using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Apache.Thrift.Protocol;
using Apache.Thrift.Protocol.Entities;
using Apache.Thrift.Protocol.Utilities;

namespace Apache.Thrift.Database
{
    public class TCopyParams : TBase
    {
        private string           _delimiter;
        private string           _null_str;
        private TImportHeaderRow _has_header;
        private bool             _quoted;
        private string           _quote;
        private string           _escape;
        private string           _line_delim;
        private string           _array_delim;
        private string           _array_begin;
        private string           _array_end;
        private int              _threads;
        private TFileType        _file_type;
        private string           _s3_access_key;
        private string           _s3_secret_key;
        private string           _s3_region;
        private TEncodingType    _geo_coords_encoding;
        private int              _geo_coords_comp_param;
        private TDatumType       _geo_coords_type;
        private int              _geo_coords_srid;
        private bool             _sanitize_column_names;
        private string           _geo_layer_name;
        private string           _s3_endpoint;
        private bool             _geo_assign_render_groups;
        private bool             _geo_explode_collections;

        public string Delimiter
        {
            get
            {
                return _delimiter;
            }
            set
            {
                isset.delimiter = true;
                _delimiter   = value;
            }
        }

        public string Null_str
        {
            get
            {
                return _null_str;
            }
            set
            {
                isset.null_str = true;
                _null_str   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TImportHeaderRow"/>
        /// </summary>
        public TImportHeaderRow Has_header
        {
            get
            {
                return _has_header;
            }
            set
            {
                isset.has_header = true;
                _has_header   = value;
            }
        }

        public bool Quoted
        {
            get
            {
                return _quoted;
            }
            set
            {
                isset.quoted = true;
                _quoted   = value;
            }
        }

        public string Quote
        {
            get
            {
                return _quote;
            }
            set
            {
                isset.quote = true;
                _quote   = value;
            }
        }

        public string Escape
        {
            get
            {
                return _escape;
            }
            set
            {
                isset.escape = true;
                _escape   = value;
            }
        }

        public string Line_delim
        {
            get
            {
                return _line_delim;
            }
            set
            {
                isset.line_delim = true;
                _line_delim   = value;
            }
        }

        public string Array_delim
        {
            get
            {
                return _array_delim;
            }
            set
            {
                isset.array_delim = true;
                _array_delim   = value;
            }
        }

        public string Array_begin
        {
            get
            {
                return _array_begin;
            }
            set
            {
                isset.array_begin = true;
                _array_begin   = value;
            }
        }

        public string Array_end
        {
            get
            {
                return _array_end;
            }
            set
            {
                isset.array_end = true;
                _array_end   = value;
            }
        }

        public int Threads
        {
            get
            {
                return _threads;
            }
            set
            {
                isset.threads = true;
                _threads   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TFileType"/>
        /// </summary>
        public TFileType File_type
        {
            get
            {
                return _file_type;
            }
            set
            {
                isset.file_type = true;
                _file_type   = value;
            }
        }

        public string S3_access_key
        {
            get
            {
                return _s3_access_key;
            }
            set
            {
                isset.s3_access_key = true;
                _s3_access_key   = value;
            }
        }

        public string S3_secret_key
        {
            get
            {
                return _s3_secret_key;
            }
            set
            {
                isset.s3_secret_key = true;
                _s3_secret_key   = value;
            }
        }

        public string S3_region
        {
            get
            {
                return _s3_region;
            }
            set
            {
                isset.s3_region = true;
                _s3_region   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TEncodingType"/>
        /// </summary>
        public TEncodingType Geo_coords_encoding
        {
            get
            {
                return _geo_coords_encoding;
            }
            set
            {
                isset.geo_coords_encoding = true;
                _geo_coords_encoding   = value;
            }
        }

        public int Geo_coords_comp_param
        {
            get
            {
                return _geo_coords_comp_param;
            }
            set
            {
                isset.geo_coords_comp_param = true;
                _geo_coords_comp_param   = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TDatumType"/>
        /// </summary>
        public TDatumType Geo_coords_type
        {
            get
            {
                return _geo_coords_type;
            }
            set
            {
                isset.geo_coords_type = true;
                _geo_coords_type   = value;
            }
        }

        public int Geo_coords_srid
        {
            get
            {
                return _geo_coords_srid;
            }
            set
            {
                isset.geo_coords_srid = true;
                _geo_coords_srid   = value;
            }
        }

        public bool Sanitize_column_names
        {
            get
            {
                return _sanitize_column_names;
            }
            set
            {
                isset.sanitize_column_names = true;
                _sanitize_column_names   = value;
            }
        }

        public string Geo_layer_name
        {
            get
            {
                return _geo_layer_name;
            }
            set
            {
                isset.geo_layer_name = true;
                _geo_layer_name   = value;
            }
        }

        public string S3_endpoint
        {
            get
            {
                return _s3_endpoint;
            }
            set
            {
                isset.s3_endpoint = true;
                _s3_endpoint   = value;
            }
        }

        public bool Geo_assign_render_groups
        {
            get
            {
                return _geo_assign_render_groups;
            }
            set
            {
                isset.geo_assign_render_groups = true;
                _geo_assign_render_groups   = value;
            }
        }

        public bool Geo_explode_collections
        {
            get
            {
                return _geo_explode_collections;
            }
            set
            {
                isset.geo_explode_collections = true;
                _geo_explode_collections   = value;
            }
        }


        public Isset isset;
        public struct Isset
        {
            public bool delimiter;
            public bool null_str;
            public bool has_header;
            public bool quoted;
            public bool quote;
            public bool escape;
            public bool line_delim;
            public bool array_delim;
            public bool array_begin;
            public bool array_end;
            public bool threads;
            public bool file_type;
            public bool s3_access_key;
            public bool s3_secret_key;
            public bool s3_region;
            public bool geo_coords_encoding;
            public bool geo_coords_comp_param;
            public bool geo_coords_type;
            public bool geo_coords_srid;
            public bool sanitize_column_names;
            public bool geo_layer_name;
            public bool s3_endpoint;
            public bool geo_assign_render_groups;
            public bool geo_explode_collections;
        }

        public TCopyParams()
        {
            _has_header                      = TImportHeaderRow.AUTODETECT;
            isset.has_header               = true;
            _file_type                       = TFileType.DELIMITED;
            isset.file_type                = true;
            _geo_coords_encoding             = TEncodingType.GEOINT;
            isset.geo_coords_encoding      = true;
            _geo_coords_comp_param           = 32;
            isset.geo_coords_comp_param    = true;
            _geo_coords_type                 = TDatumType.GEOMETRY;
            isset.geo_coords_type          = true;
            _geo_coords_srid                 = 4326;
            isset.geo_coords_srid          = true;
            _sanitize_column_names           = true;
            isset.sanitize_column_names    = true;
            _geo_assign_render_groups        = true;
            isset.geo_assign_render_groups = true;
            _geo_explode_collections         = false;
            isset.geo_explode_collections  = true;
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
                                Delimiter = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                Null_str = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.I32)
                            {
                                Has_header = (TImportHeaderRow)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Bool)
                            {
                                Quoted = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.String)
                            {
                                Quote = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.String)
                            {
                                Escape = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.String)
                            {
                                Line_delim = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.String)
                            {
                                Array_delim = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.String)
                            {
                                Array_begin = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 10:
                            if (field.Type == TType.String)
                            {
                                Array_end = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 11:
                            if (field.Type == TType.I32)
                            {
                                Threads = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 12:
                            if (field.Type == TType.I32)
                            {
                                File_type = (TFileType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 13:
                            if (field.Type == TType.String)
                            {
                                S3_access_key = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 14:
                            if (field.Type == TType.String)
                            {
                                S3_secret_key = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 15:
                            if (field.Type == TType.String)
                            {
                                S3_region = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 16:
                            if (field.Type == TType.I32)
                            {
                                Geo_coords_encoding = (TEncodingType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 17:
                            if (field.Type == TType.I32)
                            {
                                Geo_coords_comp_param = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 18:
                            if (field.Type == TType.I32)
                            {
                                Geo_coords_type = (TDatumType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 19:
                            if (field.Type == TType.I32)
                            {
                                Geo_coords_srid = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 20:
                            if (field.Type == TType.Bool)
                            {
                                Sanitize_column_names = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 21:
                            if (field.Type == TType.String)
                            {
                                Geo_layer_name = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 22:
                            if (field.Type == TType.String)
                            {
                                S3_endpoint = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 23:
                            if (field.Type == TType.Bool)
                            {
                                Geo_assign_render_groups = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 24:
                            if (field.Type == TType.Bool)
                            {
                                Geo_explode_collections = await iprot.ReadBoolAsync(cancellationToken);
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
                var struc = new TStruct("TCopyParams");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Delimiter != null && isset.delimiter)
                {
                    field.Name = "delimiter";
                    field.Type = TType.String;
                    field.ID   = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Delimiter, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Null_str != null && isset.null_str)
                {
                    field.Name = "null_str";
                    field.Type = TType.String;
                    field.ID   = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Null_str, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.has_header)
                {
                    field.Name = "has_header";
                    field.Type = TType.I32;
                    field.ID   = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Has_header, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.quoted)
                {
                    field.Name = "quoted";
                    field.Type = TType.Bool;
                    field.ID   = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Quoted, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Quote != null && isset.quote)
                {
                    field.Name = "quote";
                    field.Type = TType.String;
                    field.ID   = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Quote, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Escape != null && isset.escape)
                {
                    field.Name = "escape";
                    field.Type = TType.String;
                    field.ID   = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Escape, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Line_delim != null && isset.line_delim)
                {
                    field.Name = "line_delim";
                    field.Type = TType.String;
                    field.ID   = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Line_delim, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Array_delim != null && isset.array_delim)
                {
                    field.Name = "array_delim";
                    field.Type = TType.String;
                    field.ID   = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Array_delim, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Array_begin != null && isset.array_begin)
                {
                    field.Name = "array_begin";
                    field.Type = TType.String;
                    field.ID   = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Array_begin, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Array_end != null && isset.array_end)
                {
                    field.Name = "array_end";
                    field.Type = TType.String;
                    field.ID   = 10;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Array_end, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.threads)
                {
                    field.Name = "threads";
                    field.Type = TType.I32;
                    field.ID   = 11;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Threads, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.file_type)
                {
                    field.Name = "file_type";
                    field.Type = TType.I32;
                    field.ID   = 12;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)File_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (S3_access_key != null && isset.s3_access_key)
                {
                    field.Name = "s3_access_key";
                    field.Type = TType.String;
                    field.ID   = 13;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(S3_access_key, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (S3_secret_key != null && isset.s3_secret_key)
                {
                    field.Name = "s3_secret_key";
                    field.Type = TType.String;
                    field.ID   = 14;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(S3_secret_key, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (S3_region != null && isset.s3_region)
                {
                    field.Name = "s3_region";
                    field.Type = TType.String;
                    field.ID   = 15;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(S3_region, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_coords_encoding)
                {
                    field.Name = "geo_coords_encoding";
                    field.Type = TType.I32;
                    field.ID   = 16;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Geo_coords_encoding, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_coords_comp_param)
                {
                    field.Name = "geo_coords_comp_param";
                    field.Type = TType.I32;
                    field.ID   = 17;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Geo_coords_comp_param, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_coords_type)
                {
                    field.Name = "geo_coords_type";
                    field.Type = TType.I32;
                    field.ID   = 18;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Geo_coords_type, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_coords_srid)
                {
                    field.Name = "geo_coords_srid";
                    field.Type = TType.I32;
                    field.ID   = 19;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Geo_coords_srid, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.sanitize_column_names)
                {
                    field.Name = "sanitize_column_names";
                    field.Type = TType.Bool;
                    field.ID   = 20;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Sanitize_column_names, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Geo_layer_name != null && isset.geo_layer_name)
                {
                    field.Name = "geo_layer_name";
                    field.Type = TType.String;
                    field.ID   = 21;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Geo_layer_name, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (S3_endpoint != null && isset.s3_endpoint)
                {
                    field.Name = "s3_endpoint";
                    field.Type = TType.String;
                    field.ID   = 22;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(S3_endpoint, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_assign_render_groups)
                {
                    field.Name = "geo_assign_render_groups";
                    field.Type = TType.Bool;
                    field.ID   = 23;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Geo_assign_render_groups, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (isset.geo_explode_collections)
                {
                    field.Name = "geo_explode_collections";
                    field.Type = TType.Bool;
                    field.ID   = 24;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Geo_explode_collections, cancellationToken);
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
            var other = that as TCopyParams;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((isset.delimiter                == other.isset.delimiter)                && ((!isset.delimiter)                || (System.Object.Equals(Delimiter,                other.Delimiter))))
                && ((isset.null_str                 == other.isset.null_str)                 && ((!isset.null_str)                 || (System.Object.Equals(Null_str,                 other.Null_str))))
                && ((isset.has_header               == other.isset.has_header)               && ((!isset.has_header)               || (System.Object.Equals(Has_header,               other.Has_header))))
                && ((isset.quoted                   == other.isset.quoted)                   && ((!isset.quoted)                   || (System.Object.Equals(Quoted,                   other.Quoted))))
                && ((isset.quote                    == other.isset.quote)                    && ((!isset.quote)                    || (System.Object.Equals(Quote,                    other.Quote))))
                && ((isset.escape                   == other.isset.escape)                   && ((!isset.escape)                   || (System.Object.Equals(Escape,                   other.Escape))))
                && ((isset.line_delim               == other.isset.line_delim)               && ((!isset.line_delim)               || (System.Object.Equals(Line_delim,               other.Line_delim))))
                && ((isset.array_delim              == other.isset.array_delim)              && ((!isset.array_delim)              || (System.Object.Equals(Array_delim,              other.Array_delim))))
                && ((isset.array_begin              == other.isset.array_begin)              && ((!isset.array_begin)              || (System.Object.Equals(Array_begin,              other.Array_begin))))
                && ((isset.array_end                == other.isset.array_end)                && ((!isset.array_end)                || (System.Object.Equals(Array_end,                other.Array_end))))
                && ((isset.threads                  == other.isset.threads)                  && ((!isset.threads)                  || (System.Object.Equals(Threads,                  other.Threads))))
                && ((isset.file_type                == other.isset.file_type)                && ((!isset.file_type)                || (System.Object.Equals(File_type,                other.File_type))))
                && ((isset.s3_access_key            == other.isset.s3_access_key)            && ((!isset.s3_access_key)            || (System.Object.Equals(S3_access_key,            other.S3_access_key))))
                && ((isset.s3_secret_key            == other.isset.s3_secret_key)            && ((!isset.s3_secret_key)            || (System.Object.Equals(S3_secret_key,            other.S3_secret_key))))
                && ((isset.s3_region                == other.isset.s3_region)                && ((!isset.s3_region)                || (System.Object.Equals(S3_region,                other.S3_region))))
                && ((isset.geo_coords_encoding      == other.isset.geo_coords_encoding)      && ((!isset.geo_coords_encoding)      || (System.Object.Equals(Geo_coords_encoding,      other.Geo_coords_encoding))))
                && ((isset.geo_coords_comp_param    == other.isset.geo_coords_comp_param)    && ((!isset.geo_coords_comp_param)    || (System.Object.Equals(Geo_coords_comp_param,    other.Geo_coords_comp_param))))
                && ((isset.geo_coords_type          == other.isset.geo_coords_type)          && ((!isset.geo_coords_type)          || (System.Object.Equals(Geo_coords_type,          other.Geo_coords_type))))
                && ((isset.geo_coords_srid          == other.isset.geo_coords_srid)          && ((!isset.geo_coords_srid)          || (System.Object.Equals(Geo_coords_srid,          other.Geo_coords_srid))))
                && ((isset.sanitize_column_names    == other.isset.sanitize_column_names)    && ((!isset.sanitize_column_names)    || (System.Object.Equals(Sanitize_column_names,    other.Sanitize_column_names))))
                && ((isset.geo_layer_name           == other.isset.geo_layer_name)           && ((!isset.geo_layer_name)           || (System.Object.Equals(Geo_layer_name,           other.Geo_layer_name))))
                && ((isset.s3_endpoint              == other.isset.s3_endpoint)              && ((!isset.s3_endpoint)              || (System.Object.Equals(S3_endpoint,              other.S3_endpoint))))
                && ((isset.geo_assign_render_groups == other.isset.geo_assign_render_groups) && ((!isset.geo_assign_render_groups) || (System.Object.Equals(Geo_assign_render_groups, other.Geo_assign_render_groups))))
                && ((isset.geo_explode_collections  == other.isset.geo_explode_collections)  && ((!isset.geo_explode_collections)  || (System.Object.Equals(Geo_explode_collections,  other.Geo_explode_collections))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(isset.delimiter)
                    hashcode = (hashcode * 397) + Delimiter.GetHashCode();
                if(isset.null_str)
                    hashcode = (hashcode * 397) + Null_str.GetHashCode();
                if(isset.has_header)
                    hashcode = (hashcode * 397) + Has_header.GetHashCode();
                if(isset.quoted)
                    hashcode = (hashcode * 397) + Quoted.GetHashCode();
                if(isset.quote)
                    hashcode = (hashcode * 397) + Quote.GetHashCode();
                if(isset.escape)
                    hashcode = (hashcode * 397) + Escape.GetHashCode();
                if(isset.line_delim)
                    hashcode = (hashcode * 397) + Line_delim.GetHashCode();
                if(isset.array_delim)
                    hashcode = (hashcode * 397) + Array_delim.GetHashCode();
                if(isset.array_begin)
                    hashcode = (hashcode * 397) + Array_begin.GetHashCode();
                if(isset.array_end)
                    hashcode = (hashcode * 397) + Array_end.GetHashCode();
                if(isset.threads)
                    hashcode = (hashcode * 397) + Threads.GetHashCode();
                if(isset.file_type)
                    hashcode = (hashcode * 397) + File_type.GetHashCode();
                if(isset.s3_access_key)
                    hashcode = (hashcode * 397) + S3_access_key.GetHashCode();
                if(isset.s3_secret_key)
                    hashcode = (hashcode * 397) + S3_secret_key.GetHashCode();
                if(isset.s3_region)
                    hashcode = (hashcode * 397) + S3_region.GetHashCode();
                if(isset.geo_coords_encoding)
                    hashcode = (hashcode * 397) + Geo_coords_encoding.GetHashCode();
                if(isset.geo_coords_comp_param)
                    hashcode = (hashcode * 397) + Geo_coords_comp_param.GetHashCode();
                if(isset.geo_coords_type)
                    hashcode = (hashcode * 397) + Geo_coords_type.GetHashCode();
                if(isset.geo_coords_srid)
                    hashcode = (hashcode * 397) + Geo_coords_srid.GetHashCode();
                if(isset.sanitize_column_names)
                    hashcode = (hashcode * 397) + Sanitize_column_names.GetHashCode();
                if(isset.geo_layer_name)
                    hashcode = (hashcode * 397) + Geo_layer_name.GetHashCode();
                if(isset.s3_endpoint)
                    hashcode = (hashcode * 397) + S3_endpoint.GetHashCode();
                if(isset.geo_assign_render_groups)
                    hashcode = (hashcode * 397) + Geo_assign_render_groups.GetHashCode();
                if(isset.geo_explode_collections)
                    hashcode = (hashcode * 397) + Geo_explode_collections.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var  sb      = new StringBuilder("TCopyParams(");
            bool __first = true;
            if (Delimiter != null && isset.delimiter)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Delimiter: ");
                sb.Append(Delimiter);
            }
            if (Null_str != null && isset.null_str)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Null_str: ");
                sb.Append(Null_str);
            }
            if (isset.has_header)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Has_header: ");
                sb.Append(Has_header);
            }
            if (isset.quoted)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Quoted: ");
                sb.Append(Quoted);
            }
            if (Quote != null && isset.quote)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Quote: ");
                sb.Append(Quote);
            }
            if (Escape != null && isset.escape)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Escape: ");
                sb.Append(Escape);
            }
            if (Line_delim != null && isset.line_delim)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Line_delim: ");
                sb.Append(Line_delim);
            }
            if (Array_delim != null && isset.array_delim)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Array_delim: ");
                sb.Append(Array_delim);
            }
            if (Array_begin != null && isset.array_begin)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Array_begin: ");
                sb.Append(Array_begin);
            }
            if (Array_end != null && isset.array_end)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Array_end: ");
                sb.Append(Array_end);
            }
            if (isset.threads)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Threads: ");
                sb.Append(Threads);
            }
            if (isset.file_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("File_type: ");
                sb.Append(File_type);
            }
            if (S3_access_key != null && isset.s3_access_key)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("S3_access_key: ");
                sb.Append(S3_access_key);
            }
            if (S3_secret_key != null && isset.s3_secret_key)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("S3_secret_key: ");
                sb.Append(S3_secret_key);
            }
            if (S3_region != null && isset.s3_region)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("S3_region: ");
                sb.Append(S3_region);
            }
            if (isset.geo_coords_encoding)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_coords_encoding: ");
                sb.Append(Geo_coords_encoding);
            }
            if (isset.geo_coords_comp_param)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_coords_comp_param: ");
                sb.Append(Geo_coords_comp_param);
            }
            if (isset.geo_coords_type)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_coords_type: ");
                sb.Append(Geo_coords_type);
            }
            if (isset.geo_coords_srid)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_coords_srid: ");
                sb.Append(Geo_coords_srid);
            }
            if (isset.sanitize_column_names)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Sanitize_column_names: ");
                sb.Append(Sanitize_column_names);
            }
            if (Geo_layer_name != null && isset.geo_layer_name)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_layer_name: ");
                sb.Append(Geo_layer_name);
            }
            if (S3_endpoint != null && isset.s3_endpoint)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("S3_endpoint: ");
                sb.Append(S3_endpoint);
            }
            if (isset.geo_assign_render_groups)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_assign_render_groups: ");
                sb.Append(Geo_assign_render_groups);
            }
            if (isset.geo_explode_collections)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Geo_explode_collections: ");
                sb.Append(Geo_explode_collections);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

