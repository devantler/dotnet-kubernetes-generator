using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Workload;

/// <summary>
/// A generator for Kubernetes HorizontalPodAutoscaler objects.
/// </summary>
public class HorizontalPodAutoscalerGenerator : BaseKubernetesGenerator<V1HorizontalPodAutoscaler>
{
}
