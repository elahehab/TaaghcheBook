using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaaghcheBook.Infrastructure.Cache
{
    public class MemCache : ICache
    {
        private readonly IMemoryCache _memoryCache;

        public MemCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public void Delete<T>(string key)
        {
            _memoryCache.Remove(key);
        }

        public T? Get<T>(string key)
        {
            var result = _memoryCache.TryGetValue(key, out T value);
            if (result == false)
            {
                return default;
            }
            return value;
        }

        public void Set<T>(string key, T value)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
            {
                SlidingExpiration = TimeSpan.FromSeconds(3),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(20)
            };

            _memoryCache.Set(key, value, cacheEntryOptions);
        }
}
}
