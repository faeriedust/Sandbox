using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VisitorPattern.Demo {
  public abstract class CarPart {
    public abstract void Accept(IOldStyleCarPartVisitor oldStyleVisitor);
    public abstract void Accept(INewStyleCarPartVisitor newStyleVisitor);
  }
  public class Car : CarPart {
    public Car() {
      this.Parts = new List<CarPart>() {
        new Wheel(), new Wheel(), new Wheel(), new Wheel()
      };
    }
    public ICollection<CarPart> Parts { get; private set; }
    public override void Accept(IOldStyleCarPartVisitor oldStyleVisitor) {
      oldStyleVisitor.Visit(this);
    }
    public override void Accept(INewStyleCarPartVisitor newStyleVisitor) {
      newStyleVisitor.Visit(this);
    }
  }
  public class Wheel : CarPart {
    public override void Accept(IOldStyleCarPartVisitor oldStyleVisitor) {
      oldStyleVisitor.Visit(this);
    }
    public override void Accept(INewStyleCarPartVisitor newStyleVisitor) {
      newStyleVisitor.Visit(this);
    }
  }
  public class FrontWheel : Wheel { }
}
