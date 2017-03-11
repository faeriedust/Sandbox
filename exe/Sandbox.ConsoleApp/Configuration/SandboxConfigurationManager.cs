using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Sandbox.Playground.Configuration;

namespace Sandbox.ConsoleApp.Configuration {
  public static class SandboxConfigurationManager {
    private static IConfigurationRoot _config;
    public static IConfigurationRoot ConfigurationRoot {
      get {
        if (_config == null) {
          var configBasePath = Directory.GetCurrentDirectory();

          if (!File.Exists(Path.Combine(configBasePath, "appsettings.json"))) {
            configBasePath = AppContext.BaseDirectory;
          }

          _config = new ConfigurationBuilder()
            .SetBasePath(configBasePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
            .Build();
        }
        return _config;
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
