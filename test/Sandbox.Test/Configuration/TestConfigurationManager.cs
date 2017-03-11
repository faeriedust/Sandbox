using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Sandbox.Playground.Configuration;

namespace Sandbox.Test.Configuration {
  public class TestConfigurationManager : SandboxConfigurationManager {

    public override void OnConfigurationBuilding(IConfigurationBuilder builder) {
      base.OnConfigurationBuilding(builder);
      builder.AddJsonFile("testsettings.json", optional: true, reloadOnChange: true);
      builder.AddJsonFile("testsettings.Local.json", optional: true, reloadOnChange: true);
    }

    private TestConfiguration _testConfiguration;
    public TestConfiguration TestConfiguration {
      get {
        if (_testConfiguration == null) {
          _testConfiguration = new TestConfiguration();
          this.ConfigurationRoot.GetSection("TestSettings").Bind(_testConfiguration);
        }
        return _testConfiguration;
      }
    }
  }
}
