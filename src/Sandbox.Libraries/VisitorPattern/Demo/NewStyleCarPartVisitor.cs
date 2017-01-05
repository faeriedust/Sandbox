using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VisitorPattern.Demo {
  public interface INewStyleCarPartVisitor : INewStyleVisitor<Car>, INewStyleVisitor<Wheel> { }
  public class NewStyleCarPartVisitor : INewStyleCarPartVisitor {
    public string Result { get; protected set; } = "";
    void INewStyleVisitor<Wheel>.Visit(Wheel element) {
      this.Result += "Visiting wheel...\n";
    }
    void INewStyleVisitor<Car>.Visit(Car element) {
      this.Result += "Visiting car...\n";
      foreach (var child in element.Parts) {
        child.Accept(this);
      }
    }
  }
}
