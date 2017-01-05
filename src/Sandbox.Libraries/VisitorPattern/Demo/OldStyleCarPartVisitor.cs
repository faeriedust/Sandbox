using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VisitorPattern.Demo {
  public interface IOldStyleCarPartVisitor {
    void Visit(Car element);
    void Visit(Wheel element);
  }
  public class OldStyleCarPartVisitor : IOldStyleCarPartVisitor {
    public string Result { get; protected set; } = "";
    void IOldStyleCarPartVisitor.Visit(Wheel element) {
      this.Result += "Visiting wheel...\n";
    }
    void IOldStyleCarPartVisitor.Visit(Car element) {
      this.Result += "Visiting car...\n";
      foreach (var child in element.Parts) {
        child.Accept(this);
      }
    }
  }
}
