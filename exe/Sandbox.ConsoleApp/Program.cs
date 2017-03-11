using System;
using Sandbox.Playground.Configuration;

namespace Sandbox.ConsoleApp {
  public class Program {
    public static void Main(string[] args) {
      var configManager = new SandboxConfigurationManager();
      var secondConfig = configManager.SandboxConfiguration;

      Console.WriteLine(secondConfig.HelloWorld);
      Console.ReadLine();

    }
  }
}
