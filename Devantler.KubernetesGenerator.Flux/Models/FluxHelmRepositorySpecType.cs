using System.Runtime.Serialization;

namespace Devantler.KubernetesGenerator.Flux.Models;

/// <summary>
/// Type of a Flux HelmRepository.
/// </summary>
public enum FluxHelmRepositorySpecType
{
  /// <summary>
  /// Default Helm repository type.
  /// </summary>
  [EnumMember(Value = "default")]
  Default,
  /// <summary>
  /// Helm repository type for OCI repositories.
  /// </summary>
  [EnumMember(Value = "oci")]
  OCI
}