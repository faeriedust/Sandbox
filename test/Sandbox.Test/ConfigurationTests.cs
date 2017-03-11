using Sandbox.Test.Configuration;
using Sandbox.Test.Helpers;
using Xunit;

namespace Sandbox.Test {
  public class ConfigurationTests {
    [Fact]
    public void GetConfigurationTest() {
      var manager = new TestConfigurationManager();
      var config = manager.ConfigurationRoot;
      Assert.NotNull(config);
    }
    [Fact]
    public void GetTestSettingsTest() {
      var manager = new TestConfigurationManager();
      var settings = manager.TestConfiguration;
      Assert.NotNull(settings);
      Assert.NotNull(settings.TestOutputDirectory);
    }
    [Fact]
    public void WriteToFileTest() {
      string fileName = $"{nameof(ConfigurationTests)}-{nameof(WriteToFileTest)}.txt";
      string body = "Hello world!";
      TestHelpers.WriteToTestOutput(fileName, body);
    }
    [Fact]
    public void GetSandboxSettingsTest() {
      var manager = new TestConfigurationManager();
      var settings = manager.SandboxConfiguration;
      Assert.NotNull(settings);
      Assert.NotEmpty(settings.HelloWorld);
    }
  }
}
