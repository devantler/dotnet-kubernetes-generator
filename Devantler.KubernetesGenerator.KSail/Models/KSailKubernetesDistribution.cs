using System.Runtime.Serialization;

namespace Devantler.KubernetesGenerator.KSail.Models;

/// <summary>
/// The Kubernetes distribution to use for the KSail cluster.
/// </summary>
public enum KSailKubernetesDistribution
{
  /// <summary>
  /// The k3d Kubernetes distribution.
  /// </summary>
  [EnumMember(Value = "k3d")]
  K3d
}