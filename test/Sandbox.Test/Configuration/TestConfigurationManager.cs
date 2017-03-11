using System.IO;
using Microsoft.Extensions.Configuration;
using Sandbox.Playground.Configuration;

namespace Sandbox.Test.Configuration {
  public static class TestConfigurationManager {
    private static IConfigurationRoot _config;
    public static IConfigurationRoot ConfigurationRoot {
      get {
        if (_config == null) {
          var directory = Directory.GetCurrentDirectory();
          _config = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
          .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
          .AddJsonFile("testsettings.json", optional: true, reloadOnChange: true)
          .AddJsonFile("testsettings.Local.json", optional: true, reloadOnChange: true)
          .Build();
        }
        return _config;
      }
    }
    private static TestConfiguration _testConfiguration;
    public static TestConfiguration TestConfiguration {
      get {
        if (_testConfiguration == null) {
          _testConfiguration = new TestConfiguration();
          TestConfigurationManager.ConfigurationRoot.GetSection("TestSettings").Bind(_testConfiguration);
        }
        return _testConfiguration;
      }
    }


    private static SandboxConfiguration _sandboxConfiguration;
    public static SandboxConfiguration SandboxConfiguration {
      get {
        if (_sandboxConfiguration == null) {
          _sandboxConfiguration = new SandboxConfiguration();
          ConfigurationRoot.GetSection("Sandbox").Bind(_sandboxConfiguration);
        }
        return _sandboxConfiguration;
      }
    }
  }
}
