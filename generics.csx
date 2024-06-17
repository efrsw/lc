public static StringBuilder AppendSpanFormattable<T>(this StringBuilder builder,
 T value,
 string format,
 int bufferSize = 64)
 where T : ISpanFormattable
{
    Span<char> buffer = stackalloc char[bufferSize];
    if (value.TryFormat(buffer, out var written, format, null))
    {
        builder.Append(buffer[..written]);
    }
    else
    {
        builder.Append(value);
    }

    return builder;
}
