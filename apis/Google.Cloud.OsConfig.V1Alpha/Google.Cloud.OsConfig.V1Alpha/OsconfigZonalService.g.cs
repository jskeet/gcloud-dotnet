// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/osconfig/v1alpha/osconfig_zonal_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.OsConfig.V1Alpha {

  /// <summary>Holder for reflection information generated from google/cloud/osconfig/v1alpha/osconfig_zonal_service.proto</summary>
  public static partial class OsconfigZonalServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/osconfig/v1alpha/osconfig_zonal_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OsconfigZonalServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvY2xvdWQvb3Njb25maWcvdjFhbHBoYS9vc2NvbmZpZ196b25h",
            "bF9zZXJ2aWNlLnByb3RvEh1nb29nbGUuY2xvdWQub3Njb25maWcudjFhbHBo",
            "YRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9j",
            "bGllbnQucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aQ2dvb2ds",
            "ZS9jbG91ZC9vc2NvbmZpZy92MWFscGhhL2luc3RhbmNlX29zX3BvbGljaWVz",
            "X2NvbXBsaWFuY2UucHJvdG8aLWdvb2dsZS9jbG91ZC9vc2NvbmZpZy92MWFs",
            "cGhhL2ludmVudG9yeS5wcm90bxo5Z29vZ2xlL2Nsb3VkL29zY29uZmlnL3Yx",
            "YWxwaGEvb3NfcG9saWN5X2Fzc2lnbm1lbnRzLnByb3RvGjFnb29nbGUvY2xv",
            "dWQvb3Njb25maWcvdjFhbHBoYS92dWxuZXJhYmlsaXR5LnByb3RvGiNnb29n",
            "bGUvbG9uZ3J1bm5pbmcvb3BlcmF0aW9ucy5wcm90bzLUGAoUT3NDb25maWda",
            "b25hbFNlcnZpY2USyAIKGENyZWF0ZU9TUG9saWN5QXNzaWdubWVudBI+Lmdv",
            "b2dsZS5jbG91ZC5vc2NvbmZpZy52MWFscGhhLkNyZWF0ZU9TUG9saWN5QXNz",
            "aWdubWVudFJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9u",
            "IswBgtPkkwJUIjwvdjFhbHBoYS97cGFyZW50PXByb2plY3RzLyovbG9jYXRp",
            "b25zLyp9L29zUG9saWN5QXNzaWdubWVudHM6FG9zX3BvbGljeV9hc3NpZ25t",
            "ZW502kEzcGFyZW50LG9zX3BvbGljeV9hc3NpZ25tZW50LG9zX3BvbGljeV9h",
            "c3NpZ25tZW50X2lkykE5ChJPU1BvbGljeUFzc2lnbm1lbnQSI09TUG9saWN5",
            "QXNzaWdubWVudE9wZXJhdGlvbk1ldGFkYXRhEsoCChhVcGRhdGVPU1BvbGlj",
            "eUFzc2lnbm1lbnQSPi5nb29nbGUuY2xvdWQub3Njb25maWcudjFhbHBoYS5V",
            "cGRhdGVPU1BvbGljeUFzc2lnbm1lbnRSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdy",
            "dW5uaW5nLk9wZXJhdGlvbiLOAYLT5JMCaTJRL3YxYWxwaGEve29zX3BvbGlj",
            "eV9hc3NpZ25tZW50Lm5hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vc1Bv",
            "bGljeUFzc2lnbm1lbnRzLyp9OhRvc19wb2xpY3lfYXNzaWdubWVudNpBIG9z",
            "X3BvbGljeV9hc3NpZ25tZW50LHVwZGF0ZV9tYXNrykE5ChJPU1BvbGljeUFz",
            "c2lnbm1lbnQSI09TUG9saWN5QXNzaWdubWVudE9wZXJhdGlvbk1ldGFkYXRh",
            "EtQBChVHZXRPU1BvbGljeUFzc2lnbm1lbnQSOy5nb29nbGUuY2xvdWQub3Nj",
            "b25maWcudjFhbHBoYS5HZXRPU1BvbGljeUFzc2lnbm1lbnRSZXF1ZXN0GjEu",
            "Z29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxYWxwaGEuT1NQb2xpY3lBc3NpZ25t",
            "ZW50IkuC0+STAj4SPC92MWFscGhhL3tuYW1lPXByb2plY3RzLyovbG9jYXRp",
            "b25zLyovb3NQb2xpY3lBc3NpZ25tZW50cy8qfdpBBG5hbWUS5wEKF0xpc3RP",
            "U1BvbGljeUFzc2lnbm1lbnRzEj0uZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYx",
            "YWxwaGEuTGlzdE9TUG9saWN5QXNzaWdubWVudHNSZXF1ZXN0Gj4uZ29vZ2xl",
            "LmNsb3VkLm9zY29uZmlnLnYxYWxwaGEuTGlzdE9TUG9saWN5QXNzaWdubWVu",
            "dHNSZXNwb25zZSJNgtPkkwI+EjwvdjFhbHBoYS97cGFyZW50PXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyp9L29zUG9saWN5QXNzaWdubWVudHPaQQZwYXJlbnQS",
            "iwIKH0xpc3RPU1BvbGljeUFzc2lnbm1lbnRSZXZpc2lvbnMSRS5nb29nbGUu",
            "Y2xvdWQub3Njb25maWcudjFhbHBoYS5MaXN0T1NQb2xpY3lBc3NpZ25tZW50",
            "UmV2aXNpb25zUmVxdWVzdBpGLmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MWFs",
            "cGhhLkxpc3RPU1BvbGljeUFzc2lnbm1lbnRSZXZpc2lvbnNSZXNwb25zZSJZ",
            "gtPkkwJMEkovdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L29zUG9saWN5QXNzaWdubWVudHMvKn06bGlzdFJldmlzaW9uc9pBBG5hbWUS",
            "hgIKGERlbGV0ZU9TUG9saWN5QXNzaWdubWVudBI+Lmdvb2dsZS5jbG91ZC5v",
            "c2NvbmZpZy52MWFscGhhLkRlbGV0ZU9TUG9saWN5QXNzaWdubWVudFJlcXVl",
            "c3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIooBgtPkkwI+Kjwv",
            "djFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29zUG9saWN5",
            "QXNzaWdubWVudHMvKn3aQQRuYW1lykE8ChVnb29nbGUucHJvdG9idWYuRW1w",
            "dHkSI09TUG9saWN5QXNzaWdubWVudE9wZXJhdGlvbk1ldGFkYXRhEvwBCh9H",
            "ZXRJbnN0YW5jZU9TUG9saWNpZXNDb21wbGlhbmNlEkUuZ29vZ2xlLmNsb3Vk",
            "Lm9zY29uZmlnLnYxYWxwaGEuR2V0SW5zdGFuY2VPU1BvbGljaWVzQ29tcGxp",
            "YW5jZVJlcXVlc3QaOy5nb29nbGUuY2xvdWQub3Njb25maWcudjFhbHBoYS5J",
            "bnN0YW5jZU9TUG9saWNpZXNDb21wbGlhbmNlIlWC0+STAkgSRi92MWFscGhh",
            "L3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VPU1BvbGlj",
            "aWVzQ29tcGxpYW5jZXMvKn3aQQRuYW1lEo8CCiFMaXN0SW5zdGFuY2VPU1Bv",
            "bGljaWVzQ29tcGxpYW5jZXMSRy5nb29nbGUuY2xvdWQub3Njb25maWcudjFh",
            "bHBoYS5MaXN0SW5zdGFuY2VPU1BvbGljaWVzQ29tcGxpYW5jZXNSZXF1ZXN0",
            "GkguZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxYWxwaGEuTGlzdEluc3RhbmNl",
            "T1NQb2xpY2llc0NvbXBsaWFuY2VzUmVzcG9uc2UiV4LT5JMCSBJGL3YxYWxw",
            "aGEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9pbnN0YW5jZU9T",
            "UG9saWNpZXNDb21wbGlhbmNlc9pBBnBhcmVudBK5AQoMR2V0SW52ZW50b3J5",
            "EjIuZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxYWxwaGEuR2V0SW52ZW50b3J5",
            "UmVxdWVzdBooLmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MWFscGhhLkludmVu",
            "dG9yeSJLgtPkkwI+EjwvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0",
            "aW9ucy8qL2luc3RhbmNlcy8qL2ludmVudG9yeX3aQQRuYW1lEtMBCg9MaXN0",
            "SW52ZW50b3JpZXMSNS5nb29nbGUuY2xvdWQub3Njb25maWcudjFhbHBoYS5M",
            "aXN0SW52ZW50b3JpZXNSZXF1ZXN0GjYuZ29vZ2xlLmNsb3VkLm9zY29uZmln",
            "LnYxYWxwaGEuTGlzdEludmVudG9yaWVzUmVzcG9uc2UiUYLT5JMCQhJAL3Yx",
            "YWxwaGEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2luc3RhbmNl",
            "cy8qfS9pbnZlbnRvcmllc9pBBnBhcmVudBLhAQoWR2V0VnVsbmVyYWJpbGl0",
            "eVJlcG9ydBI8Lmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MWFscGhhLkdldFZ1",
            "bG5lcmFiaWxpdHlSZXBvcnRSZXF1ZXN0GjIuZ29vZ2xlLmNsb3VkLm9zY29u",
            "ZmlnLnYxYWxwaGEuVnVsbmVyYWJpbGl0eVJlcG9ydCJVgtPkkwJIEkYvdjFh",
            "bHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2luc3RhbmNlcy8q",
            "L3Z1bG5lcmFiaWxpdHlSZXBvcnR92kEEbmFtZRL3AQoYTGlzdFZ1bG5lcmFi",
            "aWxpdHlSZXBvcnRzEj4uZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxYWxwaGEu",
            "TGlzdFZ1bG5lcmFiaWxpdHlSZXBvcnRzUmVxdWVzdBo/Lmdvb2dsZS5jbG91",
            "ZC5vc2NvbmZpZy52MWFscGhhLkxpc3RWdWxuZXJhYmlsaXR5UmVwb3J0c1Jl",
            "c3BvbnNlIlqC0+STAksSSS92MWFscGhhL3twYXJlbnQ9cHJvamVjdHMvKi9s",
            "b2NhdGlvbnMvKi9pbnN0YW5jZXMvKn0vdnVsbmVyYWJpbGl0eVJlcG9ydHPa",
            "QQZwYXJlbnQaS8pBF29zY29uZmlnLmdvb2dsZWFwaXMuY29t0kEuaHR0cHM6",
            "Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9ybULMAgoh",
            "Y29tLmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MWFscGhhQhlPc0NvbmZpZ1pv",
            "bmFsU2VydmljZVByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvY2xvdWQvb3Njb25maWcvdjFhbHBoYTtvc2NvbmZpZ6oC",
            "HUdvb2dsZS5DbG91ZC5Pc0NvbmZpZy5WMUFscGhhygIdR29vZ2xlXENsb3Vk",
            "XE9zQ29uZmlnXFYxYWxwaGHqAiBHb29nbGU6OkNsb3VkOjpPc0NvbmZpZzo6",
            "VjFhbHBoYepBXwofY29tcHV0ZS5nb29nbGVhcGlzLmNvbS9JbnN0YW5jZRI8",
            "cHJvamVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L2luc3Rh",
            "bmNlcy97aW5zdGFuY2V9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.OsConfig.V1Alpha.InstanceOsPoliciesComplianceReflection.Descriptor, global::Google.Cloud.OsConfig.V1Alpha.InventoryReflection.Descriptor, global::Google.Cloud.OsConfig.V1Alpha.OsPolicyAssignmentsReflection.Descriptor, global::Google.Cloud.OsConfig.V1Alpha.VulnerabilityReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
