using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sandbox.Test.Configuration {
  public static class SandboxTestConfiguration {
    private static IConfigurationRoot _config;
    public static IConfigurationRoot ConfigurationRoot {
      get {
        if (_config == null) {
          _config = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
          .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
          .Build();
        }
        return _config;
      }
    }
    private static TestSettings _testSettings;
    public static TestSettings TestSettings {
      get {
        if (_testSettings == null) {
          _testSettings = new TestSettings();
          SandboxTestConfiguration.ConfigurationRoot.GetSection("TestSettings").Bind(_testSettings);
        }
        return _testSettings;
      }
    }
  }
}
