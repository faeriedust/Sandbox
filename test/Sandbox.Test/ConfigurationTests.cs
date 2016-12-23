using Sandbox.Test.Configuration;
using Xunit;

namespace Sandbox.Test {
  public class ConfigurationTests {
    [Fact]
    public void GetConfigurationTest() {
      var config = SandboxTestConfiguration.ConfigurationRoot;
      Assert.NotNull(config);
    }
    [Fact]
    public void GetTestSettingsTest() {
      var settings = SandboxTestConfiguration.TestSettings;
      Assert.NotNull(settings);
      Assert.NotNull(settings.TestOutputDirectory);
    }
  }
}
