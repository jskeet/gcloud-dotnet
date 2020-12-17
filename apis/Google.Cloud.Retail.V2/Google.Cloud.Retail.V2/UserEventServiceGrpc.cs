// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/retail/v2/user_event_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Retail.V2 {
  /// <summary>
  /// Service for ingesting end user actions on the customer website.
  /// </summary>
  public static partial class UserEventService
  {
    static readonly string __ServiceName = "google.cloud.retail.v2.UserEventService";

    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.WriteUserEventRequest> __Marshaller_google_cloud_retail_v2_WriteUserEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.WriteUserEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.UserEvent> __Marshaller_google_cloud_retail_v2_UserEvent = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.UserEvent.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.CollectUserEventRequest> __Marshaller_google_cloud_retail_v2_CollectUserEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.CollectUserEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Api.HttpBody> __Marshaller_google_api_HttpBody = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Api.HttpBody.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.PurgeUserEventsRequest> __Marshaller_google_cloud_retail_v2_PurgeUserEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.PurgeUserEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.ImportUserEventsRequest> __Marshaller_google_cloud_retail_v2_ImportUserEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.ImportUserEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Retail.V2.RejoinUserEventsRequest> __Marshaller_google_cloud_retail_v2_RejoinUserEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Retail.V2.RejoinUserEventsRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Retail.V2.WriteUserEventRequest, global::Google.Cloud.Retail.V2.UserEvent> __Method_WriteUserEvent = new grpc::Method<global::Google.Cloud.Retail.V2.WriteUserEventRequest, global::Google.Cloud.Retail.V2.UserEvent>(
        grpc::MethodType.Unary,
        __ServiceName,
        "WriteUserEvent",
        __Marshaller_google_cloud_retail_v2_WriteUserEventRequest,
        __Marshaller_google_cloud_retail_v2_UserEvent);

    static readonly grpc::Method<global::Google.Cloud.Retail.V2.CollectUserEventRequest, global::Google.Api.HttpBody> __Method_CollectUserEvent = new grpc::Method<global::Google.Cloud.Retail.V2.CollectUserEventRequest, global::Google.Api.HttpBody>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CollectUserEvent",
        __Marshaller_google_cloud_retail_v2_CollectUserEventRequest,
        __Marshaller_google_api_HttpBody);

    static readonly grpc::Method<global::Google.Cloud.Retail.V2.PurgeUserEventsRequest, global::Google.LongRunning.Operation> __Method_PurgeUserEvents = new grpc::Method<global::Google.Cloud.Retail.V2.PurgeUserEventsRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PurgeUserEvents",
        __Marshaller_google_cloud_retail_v2_PurgeUserEventsRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Retail.V2.ImportUserEventsRequest, global::Google.LongRunning.Operation> __Method_ImportUserEvents = new grpc::Method<global::Google.Cloud.Retail.V2.ImportUserEventsRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ImportUserEvents",
        __Marshaller_google_cloud_retail_v2_ImportUserEventsRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Retail.V2.RejoinUserEventsRequest, global::Google.LongRunning.Operation> __Method_RejoinUserEvents = new grpc::Method<global::Google.Cloud.Retail.V2.RejoinUserEventsRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RejoinUserEvents",
        __Marshaller_google_cloud_retail_v2_RejoinUserEventsRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Retail.V2.UserEventServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserEventService</summary>
    [grpc::BindServiceMethod(typeof(UserEventService), "BindService")]
    public abstract partial class UserEventServiceBase
    {
      /// <summary>
      /// Writes a single user event.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Retail.V2.UserEvent> WriteUserEvent(global::Google.Cloud.Retail.V2.WriteUserEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Writes a single user event from the browser. This uses a GET request to
      /// due to browser restriction of POST-ing to a 3rd party domain.
      ///
      /// This method is used only by the Retail API JavaScript pixel and Google Tag
      /// Manager. Users should not call this method directly.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Api.HttpBody> CollectUserEvent(global::Google.Cloud.Retail.V2.CollectUserEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes permanently all user events specified by the filter provided.
      /// Depending on the number of events specified by the filter, this operation
      /// could take hours or days to complete. To test a filter, use the list
      /// command first.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> PurgeUserEvents(global::Google.Cloud.Retail.V2.PurgeUserEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bulk import of User events. Request processing might be
      /// synchronous. Events that already exist are skipped.
      /// Use this method for backfilling historical user events.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully inserted.
      /// Operation.metadata is of type ImportMetadata.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> ImportUserEvents(global::Google.Cloud.Retail.V2.ImportUserEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Triggers a user event rejoin operation with latest product catalog. Events
      /// will not be annotated with detailed product information if product is
      /// missing from the catalog at the time the user event is ingested, and these
      /// events are stored as unjoined events with a limited usage on training and
      /// serving. This API can be used to trigger a 'join' operation on specified
      /// events with latest version of product catalog. It can also be used to
      /// correct events joined with wrong product catalog.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RejoinUserEvents(global::Google.Cloud.Retail.V2.RejoinUserEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UserEventService</summary>
    public partial class UserEventServiceClient : grpc::ClientBase<UserEventServiceClient>
    {
      /// <summary>Creates a new client for UserEventService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserEventServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserEventService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserEventServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserEventServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserEventServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Writes a single user event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Retail.V2.UserEvent WriteUserEvent(global::Google.Cloud.Retail.V2.WriteUserEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteUserEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes a single user event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Retail.V2.UserEvent WriteUserEvent(global::Google.Cloud.Retail.V2.WriteUserEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_WriteUserEvent, null, options, request);
      }
      /// <summary>
      /// Writes a single user event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Retail.V2.UserEvent> WriteUserEventAsync(global::Google.Cloud.Retail.V2.WriteUserEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteUserEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes a single user event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Retail.V2.UserEvent> WriteUserEventAsync(global::Google.Cloud.Retail.V2.WriteUserEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_WriteUserEvent, null, options, request);
      }
      /// <summary>
      /// Writes a single user event from the browser. This uses a GET request to
      /// due to browser restriction of POST-ing to a 3rd party domain.
      ///
      /// This method is used only by the Retail API JavaScript pixel and Google Tag
      /// Manager. Users should not call this method directly.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Api.HttpBody CollectUserEvent(global::Google.Cloud.Retail.V2.CollectUserEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CollectUserEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes a single user event from the browser. This uses a GET request to
      /// due to browser restriction of POST-ing to a 3rd party domain.
      ///
      /// This method is used only by the Retail API JavaScript pixel and Google Tag
      /// Manager. Users should not call this method directly.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Api.HttpBody CollectUserEvent(global::Google.Cloud.Retail.V2.CollectUserEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CollectUserEvent, null, options, request);
      }
      /// <summary>
      /// Writes a single user event from the browser. This uses a GET request to
      /// due to browser restriction of POST-ing to a 3rd party domain.
      ///
      /// This method is used only by the Retail API JavaScript pixel and Google Tag
      /// Manager. Users should not call this method directly.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Api.HttpBody> CollectUserEventAsync(global::Google.Cloud.Retail.V2.CollectUserEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CollectUserEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes a single user event from the browser. This uses a GET request to
      /// due to browser restriction of POST-ing to a 3rd party domain.
      ///
      /// This method is used only by the Retail API JavaScript pixel and Google Tag
      /// Manager. Users should not call this method directly.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Api.HttpBody> CollectUserEventAsync(global::Google.Cloud.Retail.V2.CollectUserEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CollectUserEvent, null, options, request);
      }
      /// <summary>
      /// Deletes permanently all user events specified by the filter provided.
      /// Depending on the number of events specified by the filter, this operation
      /// could take hours or days to complete. To test a filter, use the list
      /// command first.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation PurgeUserEvents(global::Google.Cloud.Retail.V2.PurgeUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PurgeUserEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes permanently all user events specified by the filter provided.
      /// Depending on the number of events specified by the filter, this operation
      /// could take hours or days to complete. To test a filter, use the list
      /// command first.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation PurgeUserEvents(global::Google.Cloud.Retail.V2.PurgeUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PurgeUserEvents, null, options, request);
      }
      /// <summary>
      /// Deletes permanently all user events specified by the filter provided.
      /// Depending on the number of events specified by the filter, this operation
      /// could take hours or days to complete. To test a filter, use the list
      /// command first.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> PurgeUserEventsAsync(global::Google.Cloud.Retail.V2.PurgeUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PurgeUserEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes permanently all user events specified by the filter provided.
      /// Depending on the number of events specified by the filter, this operation
      /// could take hours or days to complete. To test a filter, use the list
      /// command first.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> PurgeUserEventsAsync(global::Google.Cloud.Retail.V2.PurgeUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PurgeUserEvents, null, options, request);
      }
      /// <summary>
      /// Bulk import of User events. Request processing might be
      /// synchronous. Events that already exist are skipped.
      /// Use this method for backfilling historical user events.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully inserted.
      /// Operation.metadata is of type ImportMetadata.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ImportUserEvents(global::Google.Cloud.Retail.V2.ImportUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportUserEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bulk import of User events. Request processing might be
      /// synchronous. Events that already exist are skipped.
      /// Use this method for backfilling historical user events.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully inserted.
      /// Operation.metadata is of type ImportMetadata.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ImportUserEvents(global::Google.Cloud.Retail.V2.ImportUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ImportUserEvents, null, options, request);
      }
      /// <summary>
      /// Bulk import of User events. Request processing might be
      /// synchronous. Events that already exist are skipped.
      /// Use this method for backfilling historical user events.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully inserted.
      /// Operation.metadata is of type ImportMetadata.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ImportUserEventsAsync(global::Google.Cloud.Retail.V2.ImportUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportUserEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bulk import of User events. Request processing might be
      /// synchronous. Events that already exist are skipped.
      /// Use this method for backfilling historical user events.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully inserted.
      /// Operation.metadata is of type ImportMetadata.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ImportUserEventsAsync(global::Google.Cloud.Retail.V2.ImportUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ImportUserEvents, null, options, request);
      }
      /// <summary>
      /// Triggers a user event rejoin operation with latest product catalog. Events
      /// will not be annotated with detailed product information if product is
      /// missing from the catalog at the time the user event is ingested, and these
      /// events are stored as unjoined events with a limited usage on training and
      /// serving. This API can be used to trigger a 'join' operation on specified
      /// events with latest version of product catalog. It can also be used to
      /// correct events joined with wrong product catalog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RejoinUserEvents(global::Google.Cloud.Retail.V2.RejoinUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RejoinUserEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Triggers a user event rejoin operation with latest product catalog. Events
      /// will not be annotated with detailed product information if product is
      /// missing from the catalog at the time the user event is ingested, and these
      /// events are stored as unjoined events with a limited usage on training and
      /// serving. This API can be used to trigger a 'join' operation on specified
      /// events with latest version of product catalog. It can also be used to
      /// correct events joined with wrong product catalog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RejoinUserEvents(global::Google.Cloud.Retail.V2.RejoinUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RejoinUserEvents, null, options, request);
      }
      /// <summary>
      /// Triggers a user event rejoin operation with latest product catalog. Events
      /// will not be annotated with detailed product information if product is
      /// missing from the catalog at the time the user event is ingested, and these
      /// events are stored as unjoined events with a limited usage on training and
      /// serving. This API can be used to trigger a 'join' operation on specified
      /// events with latest version of product catalog. It can also be used to
      /// correct events joined with wrong product catalog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RejoinUserEventsAsync(global::Google.Cloud.Retail.V2.RejoinUserEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RejoinUserEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Triggers a user event rejoin operation with latest product catalog. Events
      /// will not be annotated with detailed product information if product is
      /// missing from the catalog at the time the user event is ingested, and these
      /// events are stored as unjoined events with a limited usage on training and
      /// serving. This API can be used to trigger a 'join' operation on specified
      /// events with latest version of product catalog. It can also be used to
      /// correct events joined with wrong product catalog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RejoinUserEventsAsync(global::Google.Cloud.Retail.V2.RejoinUserEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RejoinUserEvents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserEventServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserEventServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(UserEventServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_WriteUserEvent, serviceImpl.WriteUserEvent)
          .AddMethod(__Method_CollectUserEvent, serviceImpl.CollectUserEvent)
          .AddMethod(__Method_PurgeUserEvents, serviceImpl.PurgeUserEvents)
          .AddMethod(__Method_ImportUserEvents, serviceImpl.ImportUserEvents)
          .AddMethod(__Method_RejoinUserEvents, serviceImpl.RejoinUserEvents).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserEventServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_WriteUserEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Retail.V2.WriteUserEventRequest, global::Google.Cloud.Retail.V2.UserEvent>(serviceImpl.WriteUserEvent));
      serviceBinder.AddMethod(__Method_CollectUserEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Retail.V2.CollectUserEventRequest, global::Google.Api.HttpBody>(serviceImpl.CollectUserEvent));
      serviceBinder.AddMethod(__Method_PurgeUserEvents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Retail.V2.PurgeUserEventsRequest, global::Google.LongRunning.Operation>(serviceImpl.PurgeUserEvents));
      serviceBinder.AddMethod(__Method_ImportUserEvents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Retail.V2.ImportUserEventsRequest, global::Google.LongRunning.Operation>(serviceImpl.ImportUserEvents));
      serviceBinder.AddMethod(__Method_RejoinUserEvents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Retail.V2.RejoinUserEventsRequest, global::Google.LongRunning.Operation>(serviceImpl.RejoinUserEvents));
    }

  }
}
#endregion