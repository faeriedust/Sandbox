using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Libraries.VariantDictionaries {
  public static class IVariantReadonlyDictionaryExtensions {
    public static bool TryGetValue<TKey, TValue>(this IVariantReadonlyDictionary<TKey, TValue> source, TKey key, out TValue value) {
      if (source.ContainsKey(key)) {
        value = source[key];
        return true;
      } else {
        value = default(TValue);
        return false;
      }
    }
  }
}
