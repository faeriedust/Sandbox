using Microsoft.Extensions.Configuration;

namespace Sandbox.Test.Configuration {
  public class TestConfiguration {
    public TestConfiguration(IConfigurationRoot config) {
      config.GetSection("TestSettings").Bind(this);
    }
    public string TestOutputDirectory { get; set; }
    public bool SomeBool { get; set; }
  }
}
