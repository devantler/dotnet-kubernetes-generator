using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Cluster;

/// <summary>
/// A generator for Kubernetes PersistentVolume objects.
/// </summary>
public class PersistentVolumeGenerator : BaseKubernetesGenerator<V1PersistentVolume>
{
}