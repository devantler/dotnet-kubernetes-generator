using Devantler.KubernetesGenerator.Native.Cluster;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Tests.ClusterTests.NamespaceGeneratorTests;


/// <summary>
/// Tests for the <see cref="NamespaceGenerator"/> class.
/// </summary>
public class GenerateAsyncTests
{
  /// <summary>
  /// Verifies the generated Namespace object.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task GenerateAsync_WithAllPropertiesSet_ShouldGenerateAValidNamespace()
  {
    // Arrange
    var generator = new NamespaceGenerator();
    var model = new V1Namespace
    {
      ApiVersion = "v1",
      Kind = "Namespace",
      Metadata = new V1ObjectMeta
      {
        Name = "namespace",
      },
      Spec = new V1NamespaceSpec
      {
        Finalizers = ["kubernetes"]
      },
    };

    // Act
    string outputPath = Path.Combine(Path.GetTempPath(), "namespace.yaml");
    if (File.Exists(outputPath))
      File.Delete(outputPath);
    await generator.GenerateAsync(model, outputPath);
    string fileContent = await File.ReadAllTextAsync(outputPath);

    // Assert
    _ = await Verify(fileContent);

    // Cleanup
    File.Delete(outputPath);
  }
}