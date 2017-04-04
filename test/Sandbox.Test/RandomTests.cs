using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Sandbox.Test {
  public class RandomTests {
    [Theory]
    [InlineData(12, 4, 3)]
    [InlineData(12, 3, 4)]
    [InlineData(12, 6, 2)]
    public void DivisionTest(int n, int d, int r) {
      Assert.Equal(r, n / d);
    }
    [Fact]
    public void Test() {
      var container = new Container();
      var container2 = container.GetInstance<Container>();
      Assert.Equal(container, container2);
    }
  }
}
