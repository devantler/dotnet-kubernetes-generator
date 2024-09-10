using Devantler.KubernetesGenerator.Native.Authorization;
using k8s.Models;

namespace Devantler.KubernetesGenerator.Native.Tests.AuthorizationTests.RoleBindingGeneratorTests;


/// <summary>
/// Tests for the <see cref="RoleBindingGenerator"/> class.
/// </summary>
public class GenerateAsyncTests
{
  /// <summary>
  /// Verifies the generated RoleBinding object.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task GenerateAsync_WithAllPropertiesSet_ShouldGenerateAValidRoleBinding()
  {
    // Arrange
    var generator = new RoleBindingGenerator();
    var model = new V1RoleBinding
    {
      ApiVersion = "v1",
      Kind = "RoleBinding",
      Metadata = new V1ObjectMeta
      {
        Name = "role-binding",
        NamespaceProperty = "default"
      },
      RoleRef = new V1RoleRef
      {
        ApiGroup = "rbac.authorization.k8s.io",
        Kind = "Role",
        Name = "role"
      },
      Subjects =
      [
        new Rbacv1Subject
        {
          ApiGroup = "rbac.authorization.k8s.io",
          Kind = "User",
          NamespaceProperty = "default",
          Name = "user",
        }
      ]
    };

    // Act
    string outputPath = Path.Combine(Path.GetTempPath(), "role-binding.yaml");
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
