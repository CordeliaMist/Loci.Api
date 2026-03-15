using System.Runtime.CompilerServices;

namespace LociApi.Enums;

/// <summary> Defines what sources changed a StatusManager for fired events. </summary>
[Flags]
public enum ManagerChangeType : int
{
    /// <summary> The manager is unmodified. </summary>
    NoChange        = 0 << 0,

    /// <summary> A complete reapplication of the StatusManager occured from a a base64 string. </summary>
    DataString      = 1 << 0,

    /// <summary> A status was added or updated normally. </summary>
    ApplyRemove     = 1 << 1,

    /// <summary> A status in the manager met its ChainTrigger condition, and appended a new status. </summary>
    Chained         = 1 << 2,
                    
    /// <summary> Change was invoked by a LociEvent </summary>
    EventInvoked    = 1 << 3,

    /// <summary> Change was invoked by a LociCommand </summary>
    CommandInvoked  = 1 << 4,

    /// <summary> The manager was reattached to its actor after render or created. </summary>
    LinkUnlink      = 1 << 5,

}

/// <summary> Bitwise operation help for ManagerChangeType. </summary>
public static class ChangeTypeEx
{
    /// <summary>Test if a specific flag is set.</summary>
    /// <param name="value">The value to test</param>
    /// <param name="flag">The desired flag</param>
    /// <returns><see langword="true" /> if flag is present</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(this ManagerChangeType value, ManagerChangeType flag)
    {
        return (value & flag) == flag;
    }

    /// <summary>Test if any flags are set</summary>
    /// <param name="value">The value to check</param>
    /// <param name="flags">The desired flags.</param>
    /// <returns><see langword="true" /> if any of the desired flags are present.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasAny(this ManagerChangeType value, ManagerChangeType flags)
    {
        return (value & flags) != 0;
    }

    /// <summary>Set a specific flag value</summary>
    /// <param name="value">The value to change.</param>
    /// <param name="flag">The flag to set</param>
    /// <param name="enabled">The state to set the flag in.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(ref this ManagerChangeType value, ManagerChangeType flag, bool enabled)
    {
        if (enabled) value |= flag;
        else value &= ~flag;
    }

    /// <summary>Clear a specified flag</summary>
    /// <param name="value">The value to change.</param>
    /// <param name="flag">The flag to clear.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Clear(ref this ManagerChangeType value, ManagerChangeType flag)
    {
        value &= ~flag;
    }

    /// <summary>Toggle a specified flag.</summary>
    /// <param name="value">The value to change.</param>
    /// <param name="flag">The flag to toggle.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Toggle(ref this ManagerChangeType value, ManagerChangeType flag)
    {
        value ^= flag;
    }
}
