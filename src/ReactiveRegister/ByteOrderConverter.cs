using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveRegister;

public abstract class ByteOrderConverter
{
    public abstract bool TryRead<T>(ReadOnlySpan<byte> source, out T value)
        where T : unmanaged;

    public abstract bool TryRead<T>(ReadOnlySpan<byte> source, Span<T> values)
        where T : unmanaged;

    public T Read<T>(ReadOnlySpan<byte> source)
        where T : unmanaged
    {
        Guard.ValidArg(TryRead(source, out T value));
        return value;
    }

    public void Read<T>(ReadOnlySpan<byte> source, Span<T> values)
        where T : unmanaged
    {
        Guard.ValidArg(TryRead(source, values));
    }

    public abstract bool TryWrite<T>(Span<byte> destination, T value)
        where T : unmanaged;

    public abstract bool TryWrite<T>(Span<byte> destination, ReadOnlySpan<T> values)
        where T : unmanaged;

    public void Write<T>(Span<byte> destination, T value)
        where T : unmanaged
    {
        Guard.ValidArg(TryWrite(destination, value));
    }

    public void Write<T>(Span<byte> destination, ReadOnlySpan<T> values)
        where T : unmanaged
    {
        Guard.ValidArg(TryWrite(destination, values));
    }
}
