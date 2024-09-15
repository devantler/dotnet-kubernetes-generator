namespace Devantler.KubernetesGenerator.KSail.Models.Registry;

/// <summary>
/// An optional proxy for the registry to use to proxy and cache images.
/// </summary>
public class KSailRegistryProxy
{
  /// <summary>
  /// The URL of the upstream registry to proxy and cache images from.
  /// </summary>
#pragma warning disable CA1056 // URI-like properties should not be strings
  public string? Url { get; set; }
#pragma warning restore CA1056 // URI-like properties should not be strings

  /// <summary>
  /// The username to authenticate with the upstream registry.
  /// </summary>
  public string? Username { get; set; }

  /// <summary>
  /// The password to authenticate with the upstream registry.
  /// </summary>
  public string? Password { get; set; }

  /// <summary>
  /// Whether to connect to the upstream registry over HTTPS or not.
  /// </summary>
  public bool? Insecure { get; set; }
}