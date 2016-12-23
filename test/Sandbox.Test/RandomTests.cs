using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sandbox.Test.Helpers;
using Xunit;

namespace Sandbox.Test {
  public class RandomTests {
    [Fact]
    public void GetConfigurationTest() {
      var config = TestHelpers.GetConfigurationRoot();
      Assert.NotNull(config);
    }
  }
}
