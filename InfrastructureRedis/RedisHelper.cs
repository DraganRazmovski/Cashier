﻿using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InfrastructureRedis
{
    public static class RedisHelper
    {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache,
                                                  string recordId,
                                                  T data,
                                                  TimeSpan? absoluteExpireTime = null,
                                                  TimeSpan? slidingExpireTime = null)
        {
            var options = new DistributedCacheEntryOptions();

            options.AbsoluteExpirationRelativeToNow = 
                absoluteExpireTime 
                ?? TimeSpan.FromSeconds(300);
            options.SlidingExpiration = slidingExpireTime;

            var jsonData = JsonSerializer.Serialize(data);
            await cache.SetStringAsync(recordId, jsonData, options);
        }

        public static async Task<T?> GetRecordAsync<T>(this IDistributedCache cache,
                                                       string recordId)
        {
            var jsonData = await cache.GetStringAsync(recordId);

            if (jsonData is null)
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(jsonData);
        }

        public static async Task RemoveRecordAsync(this IDistributedCache cache,
                                                       string recordId)
        {
            await cache.RemoveAsync(recordId);
        }
    }
}
