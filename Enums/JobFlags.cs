using System.Runtime.CompilerServices;

namespace LociApi.Enums;
#pragma warning disable CS1591

/// <summary>
///   Bitwise flag enum for Job selection used by LociEvents. <para />
///   Helps select multiple jobs at once while keeping the value in a single field.
/// </summary>
[Flags]
public enum JobFlags : ulong
{
    None = 0,

    ADV = 1UL << 0,
    GLA = 1UL << 1,
    PGL = 1UL << 2,
    MRD = 1UL << 3,
    LNC = 1UL << 4,
    ARC = 1UL << 5,
    CNJ = 1UL << 6,
    THM = 1UL << 7,

    CRP = 1UL << 8,
    BSM = 1UL << 9,
    ARM = 1UL << 10,
    GSM = 1UL << 11,
    LTW = 1UL << 12,
    WVR = 1UL << 13,
    ALC = 1UL << 14,
    CUL = 1UL << 15,

    MIN = 1UL << 16,
    BTN = 1UL << 17,
    FSH = 1UL << 18,

    PLD = 1UL << 19,
    MNK = 1UL << 20,
    WAR = 1UL << 21,
    DRG = 1UL << 22,
    BRD = 1UL << 23,
    WHM = 1UL << 24,
    BLM = 1UL << 25,
    ACN = 1UL << 26,
    SMN = 1UL << 27,
    SCH = 1UL << 28,
    ROG = 1UL << 29,
    NIN = 1UL << 30,

    MCH = 1UL << 31,
    DRK = 1UL << 32,
    AST = 1UL << 33,
    SAM = 1UL << 34,
    RDM = 1UL << 35,
    BLU = 1UL << 36,
    GNB = 1UL << 37,
    DNC = 1UL << 38,
    RPR = 1UL << 39,
    SGE = 1UL << 40,
    VPR = 1UL << 41,
    PCT = 1UL << 42,
}
#pragma warning restore CS1591

/// <summary>
///   Bitwise operation help for JobFlags.
/// </summary>
public static class JobFlagsEx
{
    /// <summary>Test if a specific flag is set.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(this JobFlags value, JobFlags flag)
        => (value & flag) == flag;

    /// <summary>Test if any flags are set</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasAny(this JobFlags value, JobFlags flags)
        => (value & flags) != 0;

    /// <summary>Set a specific flag value</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(ref this JobFlags value, JobFlags flag, bool enabled)
    {
        if (enabled) value |= flag;
        else value &= ~flag;
    }

    /// <summary>Clear a specified flag</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Clear(ref this JobFlags value, JobFlags flag)
        => value &= ~flag;

    /// <summary>Toggle a specified flag.</summary>
     [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Toggle(ref this JobFlags value, JobFlags flag)
        => value ^= flag;
}
