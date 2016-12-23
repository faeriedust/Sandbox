using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.Sets {
  public static class EnumerableExtensions {
    public static bool SetEqual<T>(this IEnumerable<T> first, IEnumerable<T> second) {
      return first.ContainsSet(second) && second.ContainsSet(first);
    }
    public static bool ContainsSet<T>(this IEnumerable<T> source, IEnumerable<T> innerSet) {
      var sourceSet = new HashSet<T>(source);
      return innerSet.All(sourceSet.Add);
    }
  }
}
