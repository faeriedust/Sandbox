using System;
using Sandbox.ConsoleApp.Configuration;

namespace Sandbox.ConsoleApp {
  public class Program {
    public static void Main(string[] args) {
      var config = SandboxConfigurationManager.SandboxConfiguration;
      Console.WriteLine(config.HelloWorld);
      Console.WriteLine();
    }
  }
}
