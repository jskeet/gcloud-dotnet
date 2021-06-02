// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/iam/admin/v1/audit_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Iam.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/iam/admin/v1/audit_data.proto</summary>
  public static partial class AuditDataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/iam/admin/v1/audit_data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuditDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRnb29nbGUvaWFtL2FkbWluL3YxL2F1ZGl0X2RhdGEucHJvdG8SE2dvb2ds",
            "ZS5pYW0uYWRtaW4udjEaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "oAEKCUF1ZGl0RGF0YRJIChBwZXJtaXNzaW9uX2RlbHRhGAEgASgLMi4uZ29v",
            "Z2xlLmlhbS5hZG1pbi52MS5BdWRpdERhdGEuUGVybWlzc2lvbkRlbHRhGkkK",
            "D1Blcm1pc3Npb25EZWx0YRIZChFhZGRlZF9wZXJtaXNzaW9ucxgBIAMoCRIb",
            "ChNyZW1vdmVkX3Blcm1pc3Npb25zGAIgAygJQp0BChdjb20uZ29vZ2xlLmlh",
            "bS5hZG1pbi52MUIOQXVkaXREYXRhUHJvdG9QAVo4Z29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9pYW0vYWRtaW4vdjE7YWRtaW6qAhlH",
            "b29nbGUuQ2xvdWQuSWFtLkFkbWluLlYxygIZR29vZ2xlXENsb3VkXElhbVxB",
            "ZG1pblxWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.Admin.V1.AuditData), global::Google.Cloud.Iam.Admin.V1.AuditData.Parser, new[]{ "PermissionDelta" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta), global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta.Parser, new[]{ "AddedPermissions", "RemovedPermissions" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Audit log information specific to Cloud IAM admin APIs. This message is
  /// serialized as an `Any` type in the `ServiceData` message of an
  /// `AuditLog` message.
  /// </summary>
  public sealed partial class AuditData : pb::IMessage<AuditData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuditData> _parser = new pb::MessageParser<AuditData>(() => new AuditData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuditData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.Admin.V1.AuditDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditData(AuditData other) : this() {
      permissionDelta_ = other.permissionDelta_ != null ? other.permissionDelta_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditData Clone() {
      return new AuditData(this);
    }

    /// <summary>Field number for the "permission_delta" field.</summary>
    public const int PermissionDeltaFieldNumber = 1;
    private global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta permissionDelta_;
    /// <summary>
    /// The permission_delta when when creating or updating a Role.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta PermissionDelta {
      get { return permissionDelta_; }
      set {
        permissionDelta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuditData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuditData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PermissionDelta, other.PermissionDelta)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (permissionDelta_ != null) hash ^= PermissionDelta.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (permissionDelta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PermissionDelta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (permissionDelta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PermissionDelta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (permissionDelta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PermissionDelta);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuditData other) {
      if (other == null) {
        return;
      }
      if (other.permissionDelta_ != null) {
        if (permissionDelta_ == null) {
          PermissionDelta = new global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta();
        }
        PermissionDelta.MergeFrom(other.PermissionDelta);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (permissionDelta_ == null) {
              PermissionDelta = new global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta();
            }
            input.ReadMessage(PermissionDelta);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (permissionDelta_ == null) {
              PermissionDelta = new global::Google.Cloud.Iam.Admin.V1.AuditData.Types.PermissionDelta();
            }
            input.ReadMessage(PermissionDelta);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AuditData message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A PermissionDelta message to record the added_permissions and
      /// removed_permissions inside a role.
      /// </summary>
      public sealed partial class PermissionDelta : pb::IMessage<PermissionDelta>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PermissionDelta> _parser = new pb::MessageParser<PermissionDelta>(() => new PermissionDelta());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PermissionDelta> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Iam.Admin.V1.AuditData.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PermissionDelta() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PermissionDelta(PermissionDelta other) : this() {
          addedPermissions_ = other.addedPermissions_.Clone();
          removedPermissions_ = other.removedPermissions_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PermissionDelta Clone() {
          return new PermissionDelta(this);
        }

        /// <summary>Field number for the "added_permissions" field.</summary>
        public const int AddedPermissionsFieldNumber = 1;
        private static readonly pb::FieldCodec<string> _repeated_addedPermissions_codec
            = pb::FieldCodec.ForString(10);
        private readonly pbc::RepeatedField<string> addedPermissions_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// Added permissions.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> AddedPermissions {
          get { return addedPermissions_; }
        }

        /// <summary>Field number for the "removed_permissions" field.</summary>
        public const int RemovedPermissionsFieldNumber = 2;
        private static readonly pb::FieldCodec<string> _repeated_removedPermissions_codec
            = pb::FieldCodec.ForString(18);
        private readonly pbc::RepeatedField<string> removedPermissions_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// Removed permissions.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> RemovedPermissions {
          get { return removedPermissions_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PermissionDelta);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PermissionDelta other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!addedPermissions_.Equals(other.addedPermissions_)) return false;
          if(!removedPermissions_.Equals(other.removedPermissions_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= addedPermissions_.GetHashCode();
          hash ^= removedPermissions_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          addedPermissions_.WriteTo(output, _repeated_addedPermissions_codec);
          removedPermissions_.WriteTo(output, _repeated_removedPermissions_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          addedPermissions_.WriteTo(ref output, _repeated_addedPermissions_codec);
          removedPermissions_.WriteTo(ref output, _repeated_removedPermissions_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += addedPermissions_.CalculateSize(_repeated_addedPermissions_codec);
          size += removedPermissions_.CalculateSize(_repeated_removedPermissions_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PermissionDelta other) {
          if (other == null) {
            return;
          }
          addedPermissions_.Add(other.addedPermissions_);
          removedPermissions_.Add(other.removedPermissions_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                addedPermissions_.AddEntriesFrom(input, _repeated_addedPermissions_codec);
                break;
              }
              case 18: {
                removedPermissions_.AddEntriesFrom(input, _repeated_removedPermissions_codec);
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                addedPermissions_.AddEntriesFrom(ref input, _repeated_addedPermissions_codec);
                break;
              }
              case 18: {
                removedPermissions_.AddEntriesFrom(ref input, _repeated_removedPermissions_codec);
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
