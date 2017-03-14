using Microsoft.Extensions.Configuration;
using Sandbox.Test.Configuration;
using SimpleInjector;

namespace Sandbox.Test.Helpers {
  public class TestContainerManager {
    private Container _container;
    public TestContainerManager() {
      this._InitializeContainer();
    }

    private void _InitializeContainer() {
      var config = new TestConfigurationManager().ConfigurationRoot;
      this._container.RegisterSingleton<IConfigurationRoot>(config);



      this._container.Verify();
    }

    public TService GetInstance<TService>() where TService : class =>
      this._container.GetInstance<TService>();
  }
}


