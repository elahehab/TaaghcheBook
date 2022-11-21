using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaaghcheBook.Infrastructure.Cache
{
    internal class RedisCache : ICache
    {
        public void Delete<T>(string key)
        {
            throw new NotImplementedException();
        }

        public T? Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value)
        {
            throw new NotImplementedException();
        }
    }
}
