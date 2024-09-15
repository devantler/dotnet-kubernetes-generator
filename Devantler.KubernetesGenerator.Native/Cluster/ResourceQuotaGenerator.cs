using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Cluster;

/// <summary>
/// A generator for Kubernetes ResourceQuota objects.
/// </summary>
public class ResourceQuotaGenerator : BaseKubernetesGenerator<V1ResourceQuota>
{
}