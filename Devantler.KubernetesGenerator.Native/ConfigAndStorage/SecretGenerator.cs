using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.ConfigAndStorage;

/// <summary>
/// A generator for Kubernetes Secret objects.
/// </summary>
public class SecretGenerator : BaseKubernetesGenerator<V1Secret>
{
}
