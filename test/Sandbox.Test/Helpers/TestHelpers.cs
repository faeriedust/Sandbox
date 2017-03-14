using System.IO;
using Sandbox.Test.Configuration;

namespace Sandbox.Test.Helpers {
  public class TestHelpers {
    public static void WriteToTestOutput(string filename, string body) {
      var configManager = new TestConfigurationManager();

      var path = $"{configManager.TestConfiguration.TestOutputDirectory}{filename}";
      if (File.Exists(path)) {
        File.Delete(path);
      }
      using (var stream = File.OpenWrite(path)) {
        var streamWriter = new StreamWriter(stream);
        streamWriter.WriteLine(body);
        streamWriter.Flush();
      }
    }
  }
}
