using Sandbox.Test.Configuration;
using Sandbox.Test.Helpers;
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
    [Fact]
    public void WriteToFileTest() {
      string fileName = $"{nameof(ConfigurationTests)}-{nameof(WriteToFileTest)}.txt";
      string body = "Hello world!";
      TestHelpers.WriteToTestOutput(fileName, body);
    }
  }
}
