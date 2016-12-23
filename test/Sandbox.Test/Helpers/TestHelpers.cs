using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Sandbox.Test.Helpers {
  public static class TestHelpers {
    private static IConfigurationRoot _config;
    public static IConfigurationRoot GetConfigurationRoot() {
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
}
