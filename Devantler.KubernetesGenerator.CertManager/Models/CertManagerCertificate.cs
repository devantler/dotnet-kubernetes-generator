using k8s.Models;

namespace Devantler.KubernetesGenerator.CertManager.Models;

/// <summary>
/// Represents a Cert Manager Certificate.
/// </summary>
public class CertManagerCertificate
{
  /// <summary>
  /// Gets the API version.
  /// </summary>
  public string ApiVersion { get; } = "cert-manager.io/v1";

  /// <summary>
  /// Gets the Kind.
  /// </summary>
  public string Kind { get; } = "Certificate";

  /// <summary>
  /// Gets or sets the metadata.
  /// </summary>
  public required V1ObjectMeta Metadata { get; set; }

  /// <summary>
  /// Gets or sets the spec.
  /// </summary>
  public required CertManagerCertificateSpec Spec { get; set; }
}
