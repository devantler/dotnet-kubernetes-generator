using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Cluster;

/// <summary>
/// A generator for Kubernetes NetworkPolicy objects.
/// </summary>
public class NetworkPolicyGenerator : BaseKubernetesGenerator<V1NetworkPolicy>
{
}