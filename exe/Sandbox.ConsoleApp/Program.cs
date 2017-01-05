using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sandbox.ConsoleApp.Configuration;
using Sandbox.Libraries.VisitorPattern;
using Sandbox.Libraries.VisitorPattern.Demo;
using Sandbox.Resources;

namespace Sandbox.ConsoleApp {
  public class Program {
    public static void Main(string[] args) {
      var config = SandboxConfiguration.ConfigurationRoot;
      Console.WriteLine(SandboxResources.HelloWorld);
      Console.WriteLine();

      var car = new Car();

      var oldStyleCarVisitor = new OldStyleCarPartVisitor();
      car.Accept(oldStyleCarVisitor);
      Console.WriteLine(oldStyleCarVisitor.Result);
      Console.WriteLine();

      var newStyleCarPartVisitor = new NewStyleCarPartVisitor();
      car.Accept(newStyleCarPartVisitor);
      Console.WriteLine(newStyleCarPartVisitor);
      Console.ReadLine();
    }
  }
}
