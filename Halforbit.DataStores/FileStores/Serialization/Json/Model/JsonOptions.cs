﻿using System;

namespace Halforbit.DataStores
{
    [Flags]
    public enum JsonOptions
    {
        None = 0,

        CamelCasePropertyNames = 1,

        CamelCaseEnumValues = 2,

        RemoveDefaultValues = 4,

        OmitGuidDashes = 8,

        Indented = 16,

        Default = CamelCasePropertyNames | CamelCaseEnumValues | RemoveDefaultValues | OmitGuidDashes
    }
}
