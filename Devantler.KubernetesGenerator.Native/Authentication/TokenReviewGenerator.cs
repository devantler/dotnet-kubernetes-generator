using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Authentication;

/// <summary>
/// A generator for Kubernetes TokenReview objects.
/// </summary>
public class TokenReviewGenerator : BaseKubernetesGenerator<V1TokenReview>
{
}
