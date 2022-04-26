// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Runtime.CompilerServices;

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Common utility methods for working with enums.
    /// </summary>
    internal static class EnumUtils
    {
        /// <summary>
        /// Converts the numeric representation of the enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <typeparam name="TEnum">The type of enum </typeparam>
        /// <param name="value">The value to parse</param>
        /// <param name="defaultValue">The default value to return.</param>
        /// <returns>The <typeparamref name="TEnum"/>.</returns>
        public static TEnum Parse<TEnum>(int value, TEnum defaultValue)
            where TEnum : Enum
        {
            foreach (TEnum enumValue in Enum.GetValues(typeof(TEnum)))
            {
                TEnum current = enumValue;
                if (value == Unsafe.As<TEnum, int>(ref current))
                {
                    return enumValue;
                }
            }

            return defaultValue;
        }
    }
}
