using static System.AttributeTargets;
namespace System.Diagnostics.CodeAnalysis;

#if NETSTANDARD2_0

[AttributeUsage(Parameter, Inherited = false)]
internal sealed class AllowNullAttribute : Attribute;

[AttributeUsage(Parameter, Inherited = false)]
internal sealed class DisallowNullAttribute : Attribute;

[AttributeUsage(Parameter | Property | Field | ReturnValue, Inherited = false)]
internal sealed class MaybeNullAttribute : Attribute;

[AttributeUsage(Parameter | Property | Field | ReturnValue, Inherited = false)]
internal sealed class NotNullAttribute : Attribute;

[AttributeUsage(Parameter, Inherited = false)]
internal sealed class MaybeNullWhenAttribute(bool returnValue) : Attribute
{
    public bool ReturnValue { get; } = returnValue;
}

[AttributeUsage(Parameter, Inherited = false)]
internal sealed class NotNullWhenAttribute(bool returnValue) : Attribute
{
    public bool ReturnValue { get; } = returnValue;
}

[AttributeUsage(Method, Inherited = false)]
internal sealed class DoesNotReturnAttribute : Attribute;

[AttributeUsage(Parameter, Inherited = false)]
internal sealed class DoesNotReturnIfAttribute(bool parameterValue) : Attribute
{
    public bool ParameterValue { get; } = parameterValue;
}

[AttributeUsage(Method | Property, AllowMultiple = true, Inherited = false)]
internal sealed class MemberNotNullAttribute(string[] memberNames) : Attribute
{
    public string[] MemberNames { get; } = memberNames;

    public MemberNotNullAttribute(string memberName)
        : this([memberName])
    {
    }
}

[AttributeUsage(Method | Property, AllowMultiple = true, Inherited = false)]
internal sealed class MemberNotNullWhenAttribute(bool returnValue, string[] memberNames) : Attribute
{
    public bool ReturnValue { get; } = returnValue;
    public string[] MemberNames { get; } = memberNames;

    public MemberNotNullWhenAttribute(bool returnValue, string memberName)
        : this(returnValue, [memberName])
    {
    }
}

#endif
