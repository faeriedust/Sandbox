using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VariantDictionaries {
  public class VariantReadonlyDictionary<TKey, TValue> : IVariantReadonlyDictionary<TKey, TValue> {
    private readonly IDictionary<TKey, TValue> _dictionary;
    public VariantReadonlyDictionary(IDictionary<TKey, TValue> dictionary) {
      _dictionary = dictionary;
    }
    public TValue this[TKey key] => _dictionary[key];
    public int Count => _dictionary.Count;
    public IEnumerable<TKey> Keys => _dictionary.Keys;
    public IEnumerable<TValue> Values => _dictionary.Values;
    public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _dictionary.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) _dictionary).GetEnumerator();
  }
}
