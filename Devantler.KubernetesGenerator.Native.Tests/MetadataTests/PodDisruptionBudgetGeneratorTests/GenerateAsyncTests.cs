using Devantler.KubernetesGenerator.Native.Metadata;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Tests.MetadataTests.PodDisruptionBudgetGeneratorTests;


/// <summary>
/// Tests for the <see cref="PodDisruptionBudgetGenerator"/> class.
/// </summary>
public class GenerateAsyncTests
{
  /// <summary>
  /// Verifies the generated PodDisruptionBudget object.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task GenerateAsync_WithAllPropertiesSet_ShouldGenerateAValidPodDisruptionBudget()
  {
    // Arrange
    var generator = new PodDisruptionBudgetGenerator();
    var model = new V1PodDisruptionBudget
    {
      ApiVersion = "policy/v1",
      Kind = "PodDisruptionBudget",
      Metadata = new V1ObjectMeta
      {
        Name = "pod-disruption-budget",
        NamespaceProperty = "default"
      },
      Spec = new V1PodDisruptionBudgetSpec
      {
        MaxUnavailable = new IntstrIntOrString("1"),
        MinAvailable = new IntstrIntOrString("1"),
        Selector = new V1LabelSelector
        {
          MatchLabels = new Dictionary<string, string>
          {
            ["app"] = "nginx"
          }
        }
      }
    };

    // Act
    string outputPath = Path.Combine(Path.GetTempPath(), "pod-disruption-budget.yaml");
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
