using Devantler.KubernetesGenerator.Core;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Authentication;

/// <summary>
/// A generator for Kubernetes CertificateSigningRequest objects.
/// </summary>
public class CertificateSigningRequestGenerator : BaseKubernetesGenerator<V1CertificateSigningRequest>
{
}
