using System.Runtime.CompilerServices;

namespace LociApi.Enums;

/// <summary>
///   Defines the behavior of a LociStatus 
/// </summary>
[Flags]
public enum Modifiers : uint
{
    /// <summary>
    ///   No special behavior.
    /// </summary>
    None                = 0,

    /// <summary>
    ///   The status is dispellable.
    /// </summary>
    CanDispel           = 1u << 0,

    /// <summary>
    ///   When reapplied, the status can increase its stack count, if stackable.
    /// </summary>
    StacksIncrease      = 1u << 1,

    /// <summary>
    ///   When a stack reaches its cap, it starts over and counts up again.  
    /// </summary>
    StacksRollOver      = 1u << 2,

    /// <summary>
    ///   When reapplied, the expire time remains the same instead of refreshing.
    /// </summary>
    PersistExpireTime   = 1u << 3,

    /// <summary>
    ///   When a ChainTrigger occurs, the current stacks are carried over to ChainedGUID. (Only for statuses)
    /// </summary>
    StacksMoveToChain   = 1u << 4,

    /// <summary>
    ///   When the stacks increase and hit max, the remaining carry over. (Only for statuses)
    /// </summary>
    StacksCarryToChain  = 1u << 5,

    /// <summary>
    ///   When ChainTrigger occurs, keep the status active and do not remove it.
    /// </summary>
    PersistAfterTrigger = 1u << 6,

    // Ideas: Persist original after chain trigger, ext.. 
}

/// <summary>
///   Bitwise operation help for Status Modifiers.
/// </summary>
public static class ModifiersEx
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(this Modifiers value, Modifiers flag)
        => (value & flag) == flag;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasAny(this Modifiers value, Modifiers flags)
        => (value & flags) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(ref this Modifiers value, Modifiers flag, bool enabled)
    {
        if (enabled) value |= flag;
        else value &= ~flag;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Clear(ref this Modifiers value, Modifiers flag)
        => value &= ~flag;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Toggle(ref this Modifiers value, Modifiers flag)
        => value ^= flag;
}

