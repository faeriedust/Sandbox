using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sandbox.ConsoleApp.Configuration;
using Sandbox.Resources;

namespace Sandbox.ConsoleApp {
  public class Program {
    public static void Main(string[] args) {
      var config = SandboxConfiguration.ConfigurationRoot;
      Console.WriteLine(SandboxResources.HelloWorld);
      Console.ReadLine();
    }
  }
}
