// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Marten.Testing.Bugs;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertMyClassOperation1192471068
    public class UpsertMyClassOperation1192471068 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Testing.Bugs.MyClass _document;
        private readonly string _id;
        private readonly System.Collections.Generic.Dictionary<string, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertMyClassOperation1192471068(Marten.Testing.Bugs.MyClass document, string id, System.Collections.Generic.Dictionary<string, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_myclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Text;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertMyClassOperation1192471068
    
    
    // START: InsertMyClassOperation1192471068
    public class InsertMyClassOperation1192471068 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Testing.Bugs.MyClass _document;
        private readonly string _id;
        private readonly System.Collections.Generic.Dictionary<string, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertMyClassOperation1192471068(Marten.Testing.Bugs.MyClass document, string id, System.Collections.Generic.Dictionary<string, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_myclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Text;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertMyClassOperation1192471068
    
    
    // START: UpdateMyClassOperation1192471068
    public class UpdateMyClassOperation1192471068 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Testing.Bugs.MyClass _document;
        private readonly string _id;
        private readonly System.Collections.Generic.Dictionary<string, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateMyClassOperation1192471068(Marten.Testing.Bugs.MyClass document, string id, System.Collections.Generic.Dictionary<string, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_myclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Text;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateMyClassOperation1192471068
    
    
    // START: QueryOnlyMyClassSelector1192471068
    public class QueryOnlyMyClassSelector1192471068 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.MyClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyMyClassSelector1192471068(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.MyClass Resolve(System.Data.Common.DbDataReader reader)
        {

            Marten.Testing.Bugs.MyClass document;
            document = _serializer.FromJson<Marten.Testing.Bugs.MyClass>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.MyClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            Marten.Testing.Bugs.MyClass document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.MyClass>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyMyClassSelector1192471068
    
    
    // START: LightweightMyClassSelector1192471068
    public class LightweightMyClassSelector1192471068 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<Marten.Testing.Bugs.MyClass, string>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.MyClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightMyClassSelector1192471068(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.MyClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<string>(0);

            Marten.Testing.Bugs.MyClass document;
            document = _serializer.FromJson<Marten.Testing.Bugs.MyClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.MyClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<string>(0, token);

            Marten.Testing.Bugs.MyClass document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.MyClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightMyClassSelector1192471068
    
    
    // START: IdentityMapMyClassSelector1192471068
    public class IdentityMapMyClassSelector1192471068 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<Marten.Testing.Bugs.MyClass, string>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.MyClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapMyClassSelector1192471068(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.MyClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<string>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.MyClass document;
            document = _serializer.FromJson<Marten.Testing.Bugs.MyClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.MyClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<string>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.MyClass document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.MyClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapMyClassSelector1192471068
    
    
    // START: DirtyTrackingMyClassSelector1192471068
    public class DirtyTrackingMyClassSelector1192471068 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<Marten.Testing.Bugs.MyClass, string>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.MyClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingMyClassSelector1192471068(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.MyClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<string>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.MyClass document;
            document = _serializer.FromJson<Marten.Testing.Bugs.MyClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.MyClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<string>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.MyClass document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.MyClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingMyClassSelector1192471068
    
    
    // START: QueryOnlyMyClassDocumentStorage1192471068
    public class QueryOnlyMyClassDocumentStorage1192471068 : Marten.Internal.Storage.QueryOnlyDocumentStorage<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyMyClassDocumentStorage1192471068(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override string AssignIdentity(Marten.Testing.Bugs.MyClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (string.IsNullOrEmpty(document.Id)) throw new InvalidOperationException("Id/id values cannot be null or empty");
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override string Identity(Marten.Testing.Bugs.MyClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyMyClassSelector1192471068(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(string id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.String[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyMyClassDocumentStorage1192471068
    
    
    // START: LightweightMyClassDocumentStorage1192471068
    public class LightweightMyClassDocumentStorage1192471068 : Marten.Internal.Storage.LightweightDocumentStorage<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightMyClassDocumentStorage1192471068(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override string AssignIdentity(Marten.Testing.Bugs.MyClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (string.IsNullOrEmpty(document.Id)) throw new InvalidOperationException("Id/id values cannot be null or empty");
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override string Identity(Marten.Testing.Bugs.MyClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightMyClassSelector1192471068(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(string id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.String[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightMyClassDocumentStorage1192471068
    
    
    // START: IdentityMapMyClassDocumentStorage1192471068
    public class IdentityMapMyClassDocumentStorage1192471068 : Marten.Internal.Storage.IdentityMapDocumentStorage<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapMyClassDocumentStorage1192471068(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override string AssignIdentity(Marten.Testing.Bugs.MyClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (string.IsNullOrEmpty(document.Id)) throw new InvalidOperationException("Id/id values cannot be null or empty");
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override string Identity(Marten.Testing.Bugs.MyClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapMyClassSelector1192471068(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(string id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.String[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapMyClassDocumentStorage1192471068
    
    
    // START: DirtyTrackingMyClassDocumentStorage1192471068
    public class DirtyTrackingMyClassDocumentStorage1192471068 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingMyClassDocumentStorage1192471068(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override string AssignIdentity(Marten.Testing.Bugs.MyClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (string.IsNullOrEmpty(document.Id)) throw new InvalidOperationException("Id/id values cannot be null or empty");
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertMyClassOperation1192471068
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.MyClass, string>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.MyClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override string Identity(Marten.Testing.Bugs.MyClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingMyClassSelector1192471068(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(string id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.String[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingMyClassDocumentStorage1192471068
    
    
    // START: MyClassBulkLoader1192471068
    public class MyClassBulkLoader1192471068 : Marten.Internal.CodeGeneration.BulkLoader<Marten.Testing.Bugs.MyClass, string>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Bugs.MyClass, string> _storage;

        public MyClassBulkLoader1192471068(Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Bugs.MyClass, string> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_myclass(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_myclass_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_myclass (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_myclass_temp.\"id\", mt_doc_myclass_temp.\"data\", mt_doc_myclass_temp.\"mt_version\", mt_doc_myclass_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_myclass_temp left join public.mt_doc_myclass on mt_doc_myclass_temp.id = public.mt_doc_myclass.id where public.mt_doc_myclass.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_myclass target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_myclass_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_myclass_temp as select * from public.mt_doc_myclass limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Bugs.MyClass document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Text);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Bugs.MyClass document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Text, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: MyClassBulkLoader1192471068
    
    
    // START: MyClassProvider1192471068
    public class MyClassProvider1192471068 : Marten.Internal.Storage.DocumentProvider<Marten.Testing.Bugs.MyClass>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public MyClassProvider1192471068(Marten.Schema.DocumentMapping mapping) : base(new MyClassBulkLoader1192471068(new QueryOnlyMyClassDocumentStorage1192471068(mapping)), new QueryOnlyMyClassDocumentStorage1192471068(mapping), new LightweightMyClassDocumentStorage1192471068(mapping), new IdentityMapMyClassDocumentStorage1192471068(mapping), new DirtyTrackingMyClassDocumentStorage1192471068(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: MyClassProvider1192471068
    
    
}
