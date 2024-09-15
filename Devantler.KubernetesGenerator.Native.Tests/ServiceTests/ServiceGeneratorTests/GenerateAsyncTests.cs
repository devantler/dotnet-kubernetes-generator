using Devantler.KubernetesGenerator.Native.Service;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Tests.ServiceTests.ServiceGeneratorTests;


/// <summary>
/// Tests for the <see cref="ServiceGenerator"/> class.
/// </summary>
public class GenerateAsyncTests
{
  /// <summary>
  /// Verifies the generated Endpoint object.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task GenerateAsync_WithAllPropertiesSet_ShouldGenerateAValidEndpoint()
  {
    // Arrange
    var generator = new ServiceGenerator();
    var model = new V1Service
    {
      ApiVersion = "v1",
      Kind = "Service",
      Metadata = new V1ObjectMeta
      {
        Name = "service",
        NamespaceProperty = "default"
      },
      Spec = new V1ServiceSpec
      {
        ClusterIP = "192.168.34.21",
        Ports =
        [
          new V1ServicePort
          {
            Name = "port-name",
            Port = 80,
            Protocol = "TCP",
            TargetPort = 8080
          }
        ],
        Selector = new Dictionary<string, string>
        {
          ["app"] = "app"
        },
        Type = "ClusterIP"
      }
    };

    // Act
    string outputPath = Path.Combine(Path.GetTempPath(), "service.yaml");
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
