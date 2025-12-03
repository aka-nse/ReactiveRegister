using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ReactiveRegister;

internal static class Guard
{
    
    public static void ValidArg([DoesNotReturnIf(false)] bool shouldBe, string? paramName = null, string? message = null)
    {
        if (!shouldBe)
        {
            throw new ArgumentException(message ?? "Invalid argument.", paramName);
        }
    }

    public static T ValidArg<T>(T value, bool shouldBe, string? paramName = null, string? message = null)
    {
        if (!shouldBe)
        {
            throw new ArgumentException(message ?? "Invalid argument.", paramName);
        }
        return value;
    }
}
