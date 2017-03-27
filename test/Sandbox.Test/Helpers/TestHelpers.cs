using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Sandbox.Test.Configuration;

namespace Sandbox.Test.Helpers {
  public class TestHelpers {
    public static void WriteToTestOutput(string filename, string body) {
      var path = $"{SandboxTestConfiguration.TestSettings.TestOutputDirectory}{filename}";
      Directory.CreateDirectory(SandboxTestConfiguration.TestSettings.TestOutputDirectory);
      using (var stream = File.OpenWrite(path)) {
        var streamWriter = new StreamWriter(stream);
        streamWriter.WriteLine(body);
        streamWriter.Flush();
      }
    }
  }
}
