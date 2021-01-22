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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ServiceControl.V1
{
    /// <summary>Settings for <see cref="ServiceControllerClient"/> instances.</summary>
    public sealed partial class ServiceControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceControllerSettings"/>.</returns>
        public static ServiceControllerSettings GetDefault() => new ServiceControllerSettings();

        /// <summary>Constructs a new <see cref="ServiceControllerSettings"/> object with default settings.</summary>
        public ServiceControllerSettings()
        {
        }

        private ServiceControllerSettings(ServiceControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CheckSettings = existing.CheckSettings;
            ReportSettings = existing.ReportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceControllerClient.Check</c> and <c>ServiceControllerClient.CheckAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceControllerClient.Report</c> and <c>ServiceControllerClient.ReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceControllerSettings"/> object.</returns>
        public ServiceControllerSettings Clone() => new ServiceControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ServiceControllerClientBuilder : gaxgrpc::ClientBuilderBase<ServiceControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceControllerSettings Settings { get; set; }

        partial void InterceptBuild(ref ServiceControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceControllerClient Build()
        {
            ServiceControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceControllerClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ServiceControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceControllerClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ServiceControllerClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ServiceControllerClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceControllerClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ServiceController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Google Service Control API](/service-control/overview)
    /// 
    /// Lets clients check and report operations against a [managed
    /// service](https://cloud.google.com/service-management/reference/rpc/google.api/servicemanagement.v1#google.api.servicemanagement.v1.ManagedService).
    /// </remarks>
    public abstract partial class ServiceControllerClient
    {
        /// <summary>
        /// The default endpoint for the ServiceController service, which is a host of "servicecontrol.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicecontrol.googleapis.com:443";

        /// <summary>The default ServiceController scopes.</summary>
        /// <remarks>
        /// The default ServiceController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/servicecontrol</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/servicecontrol",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceControllerClient"/>.</returns>
        public static stt::Task<ServiceControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceControllerClient"/>.</returns>
        public static ServiceControllerClient Create() => new ServiceControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceControllerSettings"/>.</param>
        /// <returns>The created <see cref="ServiceControllerClient"/>.</returns>
        internal static ServiceControllerClient Create(grpccore::CallInvoker callInvoker, ServiceControllerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceController.ServiceControllerClient grpcClient = new ServiceController.ServiceControllerClient(callInvoker);
            return new ServiceControllerClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ServiceController client</summary>
        public virtual ServiceController.ServiceControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed
        /// based on the configuration of the service and related policies. It must be
        /// called before the operation is executed.
        /// 
        /// If feasible, the client should cache the check results and reuse them for
        /// 60 seconds. In case of any server errors, the client should rely on the
        /// cached results for much longer time to avoid outage.
        /// WARNING: There is general 60s delay for the configuration and policy
        /// propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information.
        /// 
        /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has the size limit of 64KB.
        /// 
        /// This method requires the `servicemanagement.services.check` permission
        /// on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckResponse Check(CheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed
        /// based on the configuration of the service and related policies. It must be
        /// called before the operation is executed.
        /// 
        /// If feasible, the client should cache the check results and reuse them for
        /// 60 seconds. In case of any server errors, the client should rely on the
        /// cached results for much longer time to avoid outage.
        /// WARNING: There is general 60s delay for the configuration and policy
        /// propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information.
        /// 
        /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has the size limit of 64KB.
        /// 
        /// This method requires the `servicemanagement.services.check` permission
        /// on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckResponse> CheckAsync(CheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed
        /// based on the configuration of the service and related policies. It must be
        /// called before the operation is executed.
        /// 
        /// If feasible, the client should cache the check results and reuse them for
        /// 60 seconds. In case of any server errors, the client should rely on the
        /// cached results for much longer time to avoid outage.
        /// WARNING: There is general 60s delay for the configuration and policy
        /// propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information.
        /// 
        /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has the size limit of 64KB.
        /// 
        /// This method requires the `servicemanagement.services.check` permission
        /// on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckResponse> CheckAsync(CheckRequest request, st::CancellationToken cancellationToken) =>
            CheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
        /// metrics. It should be called after an operation is completed.
        /// 
        /// If feasible, the client should aggregate reporting data for up to 5
        /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
        /// reduce data loss during client crashes. Clients should carefully choose
        /// the aggregation time window to avoid data loss risk more than 0.01%
        /// for business and compliance reasons.
        /// 
        /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has the size limit (wire-format byte size) of
        /// 1MB.
        /// 
        /// This method requires the `servicemanagement.services.report` permission
        /// on the specified service. For more information, see
        /// [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportResponse Report(ReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
        /// metrics. It should be called after an operation is completed.
        /// 
        /// If feasible, the client should aggregate reporting data for up to 5
        /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
        /// reduce data loss during client crashes. Clients should carefully choose
        /// the aggregation time window to avoid data loss risk more than 0.01%
        /// for business and compliance reasons.
        /// 
        /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has the size limit (wire-format byte size) of
        /// 1MB.
        /// 
        /// This method requires the `servicemanagement.services.report` permission
        /// on the specified service. For more information, see
        /// [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportResponse> ReportAsync(ReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
        /// metrics. It should be called after an operation is completed.
        /// 
        /// If feasible, the client should aggregate reporting data for up to 5
        /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
        /// reduce data loss during client crashes. Clients should carefully choose
        /// the aggregation time window to avoid data loss risk more than 0.01%
        /// for business and compliance reasons.
        /// 
        /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has the size limit (wire-format byte size) of
        /// 1MB.
        /// 
        /// This method requires the `servicemanagement.services.report` permission
        /// on the specified service. For more information, see
        /// [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportResponse> ReportAsync(ReportRequest request, st::CancellationToken cancellationToken) =>
            ReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServiceController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Google Service Control API](/service-control/overview)
    /// 
    /// Lets clients check and report operations against a [managed
    /// service](https://cloud.google.com/service-management/reference/rpc/google.api/servicemanagement.v1#google.api.servicemanagement.v1.ManagedService).
    /// </remarks>
    public sealed partial class ServiceControllerClientImpl : ServiceControllerClient
    {
        private readonly gaxgrpc::ApiCall<CheckRequest, CheckResponse> _callCheck;

        private readonly gaxgrpc::ApiCall<ReportRequest, ReportResponse> _callReport;

        /// <summary>
        /// Constructs a client wrapper for the ServiceController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceControllerSettings"/> used within this client.</param>
        public ServiceControllerClientImpl(ServiceController.ServiceControllerClient grpcClient, ServiceControllerSettings settings)
        {
            GrpcClient = grpcClient;
            ServiceControllerSettings effectiveSettings = settings ?? ServiceControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCheck = clientHelper.BuildApiCall<CheckRequest, CheckResponse>(grpcClient.CheckAsync, grpcClient.Check, effectiveSettings.CheckSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callCheck);
            Modify_CheckApiCall(ref _callCheck);
            _callReport = clientHelper.BuildApiCall<ReportRequest, ReportResponse>(grpcClient.ReportAsync, grpcClient.Report, effectiveSettings.ReportSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callReport);
            Modify_ReportApiCall(ref _callReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CheckApiCall(ref gaxgrpc::ApiCall<CheckRequest, CheckResponse> call);

        partial void Modify_ReportApiCall(ref gaxgrpc::ApiCall<ReportRequest, ReportResponse> call);

        partial void OnConstruction(ServiceController.ServiceControllerClient grpcClient, ServiceControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceController client</summary>
        public override ServiceController.ServiceControllerClient GrpcClient { get; }

        partial void Modify_CheckRequest(ref CheckRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportRequest(ref ReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed
        /// based on the configuration of the service and related policies. It must be
        /// called before the operation is executed.
        /// 
        /// If feasible, the client should cache the check results and reuse them for
        /// 60 seconds. In case of any server errors, the client should rely on the
        /// cached results for much longer time to avoid outage.
        /// WARNING: There is general 60s delay for the configuration and policy
        /// propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information.
        /// 
        /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has the size limit of 64KB.
        /// 
        /// This method requires the `servicemanagement.services.check` permission
        /// on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckResponse Check(CheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckRequest(ref request, ref callSettings);
            return _callCheck.Sync(request, callSettings);
        }

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed
        /// based on the configuration of the service and related policies. It must be
        /// called before the operation is executed.
        /// 
        /// If feasible, the client should cache the check results and reuse them for
        /// 60 seconds. In case of any server errors, the client should rely on the
        /// cached results for much longer time to avoid outage.
        /// WARNING: There is general 60s delay for the configuration and policy
        /// propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information.
        /// 
        /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has the size limit of 64KB.
        /// 
        /// This method requires the `servicemanagement.services.check` permission
        /// on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckResponse> CheckAsync(CheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckRequest(ref request, ref callSettings);
            return _callCheck.Async(request, callSettings);
        }

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
        /// metrics. It should be called after an operation is completed.
        /// 
        /// If feasible, the client should aggregate reporting data for up to 5
        /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
        /// reduce data loss during client crashes. Clients should carefully choose
        /// the aggregation time window to avoid data loss risk more than 0.01%
        /// for business and compliance reasons.
        /// 
        /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has the size limit (wire-format byte size) of
        /// 1MB.
        /// 
        /// This method requires the `servicemanagement.services.report` permission
        /// on the specified service. For more information, see
        /// [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportResponse Report(ReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportRequest(ref request, ref callSettings);
            return _callReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
        /// metrics. It should be called after an operation is completed.
        /// 
        /// If feasible, the client should aggregate reporting data for up to 5
        /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
        /// reduce data loss during client crashes. Clients should carefully choose
        /// the aggregation time window to avoid data loss risk more than 0.01%
        /// for business and compliance reasons.
        /// 
        /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has the size limit (wire-format byte size) of
        /// 1MB.
        /// 
        /// This method requires the `servicemanagement.services.report` permission
        /// on the specified service. For more information, see
        /// [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportResponse> ReportAsync(ReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportRequest(ref request, ref callSettings);
            return _callReport.Async(request, callSettings);
        }
    }
}