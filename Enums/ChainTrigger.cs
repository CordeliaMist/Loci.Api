using System.Runtime.CompilerServices;

namespace LociApi.Enums;

// What must occur for a chained status to trigger.
// Could be expanded upon to be caused by many things.
public enum ChainTrigger : int
{
    Dispel = 0,
    HitMaxStacks = 1,
    TimerExpired = 2,
    HitSetStacks = 3
}
