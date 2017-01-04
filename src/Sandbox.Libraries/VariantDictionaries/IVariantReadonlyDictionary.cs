using System.Collections;
using System.Collections.Generic;

namespace Sandbox.Libraries.VariantDictionaries {
  public interface IVariantReadonlyDictionary<TKey, out TValue> : IEnumerable {
    TValue this[TKey key] { get; }
    IEnumerable<TKey> Keys { get; }
    IEnumerable<TValue> Values { get; }
    bool ContainsKey(TKey key);
  }
}
