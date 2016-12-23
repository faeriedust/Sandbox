using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VariantDictionaries {
  public class VariantReadonlyDictionary<TKey, TValue> : IVariantReadonlyDictionary<TKey, TValue>, IDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue> {
    private readonly IDictionary<TKey, TValue> _dictionary;
    public VariantReadonlyDictionary(IDictionary<TKey, TValue> dictionary) {
      _dictionary = dictionary;
    }
    public TValue this[TKey key] {
      get { return _dictionary[key]; }
      set { _dictionary[key] = value; }
    }
    public int Count =>
      _dictionary.Count;
    public bool IsReadOnly =>
      _dictionary.IsReadOnly;
    public ICollection<TKey> Keys =>
      _dictionary.Keys;
    public ICollection<TValue> Values =>
      _dictionary.Values;
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys =>
      this.Keys;
    IEnumerable<TKey> IVariantReadonlyDictionary<TKey, TValue>.Keys =>
      this.Keys;
    IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values =>
      this.Values;
    IEnumerable<TValue> IVariantReadonlyDictionary<TKey, TValue>.Values =>
      this.Values;
    public void Add(KeyValuePair<TKey, TValue> item) =>
      _dictionary.Add(item);
    public void Add(TKey key, TValue value) =>
      _dictionary.Add(key, value);
    public void Clear() =>
      _dictionary.Clear();
    public bool Contains(KeyValuePair<TKey, TValue> item) =>
      _dictionary.Contains(item);
    public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) =>
      _dictionary.CopyTo(array, arrayIndex);
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() =>
      _dictionary.GetEnumerator();
    public bool Remove(KeyValuePair<TKey, TValue> item) =>
      _dictionary.Remove(item);
    public bool Remove(TKey key) =>
      _dictionary.Remove(key);
    public bool TryGetValue(TKey key, out TValue value) =>
      _dictionary.TryGetValue(key, out value);
    IEnumerator IEnumerable.GetEnumerator() =>
      ((IEnumerable) _dictionary).GetEnumerator();
  }
}
