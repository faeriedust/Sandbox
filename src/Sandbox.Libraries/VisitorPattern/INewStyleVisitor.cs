using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VisitorPattern {
  public interface INewStyleVisitor<in TElement> {
    void Visit(TElement element);
  }
}
