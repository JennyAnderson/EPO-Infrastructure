﻿using System;

namespace epo.Core
{
    [Flags]
    public enum ContractPropertyState : byte
    {
        NoProperty = 0,

        HasStorage = 1 << 0,
        HasDynamicInvoke = 1 << 1,
    }
}
 