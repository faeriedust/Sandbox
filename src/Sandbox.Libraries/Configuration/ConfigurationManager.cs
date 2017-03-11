using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sandbox.Libraries.Configuration {
  public class ConfigurationManager {

    private readonly string[] _additionalConfigFileNames;

    private IConfigurationRoot _config;

    public IConfigurationRoot ConfigurationRoot {
      get {
        if (_config == null) {
          var configBasePath = Directory.GetCurrentDirectory();
          if (!File.Exists(Path.Combine(configBasePath, "appsettings.json"))) {
            configBasePath = AppContext.BaseDirectory;
          }
          var builder = new ConfigurationBuilder()
            .SetBasePath(configBasePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
          this.OnConfigurationBuilding(builder);
          builder.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);
          _config = builder.Build();
        }
        return _config;
      }
    }

    public virtual void OnConfigurationBuilding(IConfigurationBuilder builder) { }
  }
}
