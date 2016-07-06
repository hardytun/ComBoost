﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wodsoft.ComBoost
{
    public interface ICache
    {
        Task<ICacheEntry> GetAsync(string name);
        Task RemoveAsync(string name);
        Task SetAsync(ICacheEntry entry);
    }
}