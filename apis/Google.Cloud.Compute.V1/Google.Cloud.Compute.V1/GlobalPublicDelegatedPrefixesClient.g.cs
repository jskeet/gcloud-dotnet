// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="GlobalPublicDelegatedPrefixesClient"/> instances.</summary>
    public sealed partial class GlobalPublicDelegatedPrefixesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GlobalPublicDelegatedPrefixesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GlobalPublicDelegatedPrefixesSettings"/>.</returns>
        public static GlobalPublicDelegatedPrefixesSettings GetDefault() => new GlobalPublicDelegatedPrefixesSettings();

        /// <summary>
        /// Constructs a new <see cref="GlobalPublicDelegatedPrefixesSettings"/> object with default settings.
        /// </summary>
        public GlobalPublicDelegatedPrefixesSettings()
        {
        }

        private GlobalPublicDelegatedPrefixesSettings(GlobalPublicDelegatedPrefixesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GlobalPublicDelegatedPrefixesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalPublicDelegatedPrefixesClient.Delete</c> and <c>GlobalPublicDelegatedPrefixesClient.DeleteAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalPublicDelegatedPrefixesClient.Get</c> and <c>GlobalPublicDelegatedPrefixesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalPublicDelegatedPrefixesClient.Insert</c> and <c>GlobalPublicDelegatedPrefixesClient.InsertAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalPublicDelegatedPrefixesClient.List</c> and <c>GlobalPublicDelegatedPrefixesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalPublicDelegatedPrefixesClient.Patch</c> and <c>GlobalPublicDelegatedPrefixesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GlobalPublicDelegatedPrefixesSettings"/> object.</returns>
        public GlobalPublicDelegatedPrefixesSettings Clone() => new GlobalPublicDelegatedPrefixesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GlobalPublicDelegatedPrefixesClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class GlobalPublicDelegatedPrefixesClientBuilder : gaxgrpc::ClientBuilderBase<GlobalPublicDelegatedPrefixesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GlobalPublicDelegatedPrefixesSettings Settings { get; set; }

        partial void InterceptBuild(ref GlobalPublicDelegatedPrefixesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GlobalPublicDelegatedPrefixesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GlobalPublicDelegatedPrefixesClient Build()
        {
            GlobalPublicDelegatedPrefixesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GlobalPublicDelegatedPrefixesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GlobalPublicDelegatedPrefixesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GlobalPublicDelegatedPrefixesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GlobalPublicDelegatedPrefixesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GlobalPublicDelegatedPrefixesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GlobalPublicDelegatedPrefixesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GlobalPublicDelegatedPrefixesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            GlobalPublicDelegatedPrefixesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GlobalPublicDelegatedPrefixesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>GlobalPublicDelegatedPrefixes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GlobalPublicDelegatedPrefixes API.
    /// </remarks>
    public abstract partial class GlobalPublicDelegatedPrefixesClient
    {
        /// <summary>
        /// The default endpoint for the GlobalPublicDelegatedPrefixes service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default GlobalPublicDelegatedPrefixes scopes.</summary>
        /// <remarks>
        /// The default GlobalPublicDelegatedPrefixes scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GlobalPublicDelegatedPrefixesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalPublicDelegatedPrefixesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GlobalPublicDelegatedPrefixesClient"/>.</returns>
        public static stt::Task<GlobalPublicDelegatedPrefixesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GlobalPublicDelegatedPrefixesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GlobalPublicDelegatedPrefixesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalPublicDelegatedPrefixesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GlobalPublicDelegatedPrefixesClient"/>.</returns>
        public static GlobalPublicDelegatedPrefixesClient Create() =>
            new GlobalPublicDelegatedPrefixesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GlobalPublicDelegatedPrefixesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GlobalPublicDelegatedPrefixesSettings"/>.</param>
        /// <returns>The created <see cref="GlobalPublicDelegatedPrefixesClient"/>.</returns>
        internal static GlobalPublicDelegatedPrefixesClient Create(grpccore::CallInvoker callInvoker, GlobalPublicDelegatedPrefixesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient grpcClient = new GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient(callInvoker);
            return new GlobalPublicDelegatedPrefixesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC GlobalPublicDelegatedPrefixes client</summary>
        public virtual GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string publicDelegatedPrefix, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, publicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefix Get(GetGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(GetGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(GetGlobalPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefix Get(string project, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(string project, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(string project, string publicDelegatedPrefix, st::CancellationToken cancellationToken) =>
            GetAsync(project, publicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, PublicDelegatedPrefix publicDelegatedPrefixResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, publicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixList List(ListGlobalPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(ListGlobalPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(ListGlobalPublicDelegatedPrefixesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixList List(string project, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListGlobalPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListGlobalPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(string project, st::CancellationToken cancellationToken) =>
            ListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchGlobalPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, publicDelegatedPrefix, publicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GlobalPublicDelegatedPrefixes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GlobalPublicDelegatedPrefixes API.
    /// </remarks>
    public sealed partial class GlobalPublicDelegatedPrefixesClientImpl : GlobalPublicDelegatedPrefixesClient
    {
        private readonly gaxgrpc::ApiCall<DeleteGlobalPublicDelegatedPrefixeRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetGlobalPublicDelegatedPrefixeRequest, PublicDelegatedPrefix> _callGet;

        private readonly gaxgrpc::ApiCall<InsertGlobalPublicDelegatedPrefixeRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListGlobalPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList> _callList;

        private readonly gaxgrpc::ApiCall<PatchGlobalPublicDelegatedPrefixeRequest, Operation> _callPatch;

        /// <summary>
        /// Constructs a client wrapper for the GlobalPublicDelegatedPrefixes service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GlobalPublicDelegatedPrefixesSettings"/> used within this client.
        /// </param>
        public GlobalPublicDelegatedPrefixesClientImpl(GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient grpcClient, GlobalPublicDelegatedPrefixesSettings settings)
        {
            GrpcClient = grpcClient;
            GlobalPublicDelegatedPrefixesSettings effectiveSettings = settings ?? GlobalPublicDelegatedPrefixesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteGlobalPublicDelegatedPrefixeRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetGlobalPublicDelegatedPrefixeRequest, PublicDelegatedPrefix>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertGlobalPublicDelegatedPrefixeRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListGlobalPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchGlobalPublicDelegatedPrefixeRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteGlobalPublicDelegatedPrefixeRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetGlobalPublicDelegatedPrefixeRequest, PublicDelegatedPrefix> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertGlobalPublicDelegatedPrefixeRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListGlobalPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchGlobalPublicDelegatedPrefixeRequest, Operation> call);

        partial void OnConstruction(GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient grpcClient, GlobalPublicDelegatedPrefixesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GlobalPublicDelegatedPrefixes client</summary>
        public override GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient GrpcClient { get; }

        partial void Modify_DeleteGlobalPublicDelegatedPrefixeRequest(ref DeleteGlobalPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlobalPublicDelegatedPrefixeRequest(ref GetGlobalPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertGlobalPublicDelegatedPrefixeRequest(ref InsertGlobalPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlobalPublicDelegatedPrefixesRequest(ref ListGlobalPublicDelegatedPrefixesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchGlobalPublicDelegatedPrefixeRequest(ref PatchGlobalPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified global PublicDelegatedPrefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicDelegatedPrefix Get(GetGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified global PublicDelegatedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicDelegatedPrefix> GetAsync(GetGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a global PublicDelegatedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicDelegatedPrefixList List(ListGlobalPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the global PublicDelegatedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicDelegatedPrefixList> ListAsync(ListGlobalPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified global PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchGlobalPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }
    }
}
