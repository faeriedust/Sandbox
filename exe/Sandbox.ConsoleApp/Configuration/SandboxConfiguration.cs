﻿using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sandbox.ConsoleApp.Configuration {
  public static class SandboxConfiguration {
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
  }
}
