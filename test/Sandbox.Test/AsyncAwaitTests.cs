using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Sandbox.Test {
  public class AsyncAwaitTests {
    [Fact]
    public void CallingAsyncMethod_Can_CreateThreads() {
      int myThreadId = Thread.CurrentThread.ManagedThreadId;
      int asyncMethodCallThreadId = _GetThreadIdAsync().Result;

      Assert.NotEqual(myThreadId, asyncMethodCallThreadId);
    }
    public async Task<int> _GetThreadIdAsync() {
      await Task.Yield();
      return Thread.CurrentThread.ManagedThreadId;
    }
  }
}
