using Microsoft.Extensions.Configuration;
using Sandbox.Libraries.Configuration;

namespace Sandbox.Playground.Configuration {
  public class SandboxConfigurationManager : ConfigurationManager {

    private SandboxConfiguration _sandboxConfiguration;
    public SandboxConfiguration SandboxConfiguration {
      get {
        if (_sandboxConfiguration == null) {
          _sandboxConfiguration = new SandboxConfiguration();
          this.ConfigurationRoot.GetSection("Sandbox").Bind(_sandboxConfiguration);
        }
        return _sandboxConfiguration;
      }
    }
  }
}
