using LociApi.Enums;

namespace LociApi.Api;

/// <summary>
///   Events fired by Loci.
/// </summary>
public interface ILociApiEvents
{
    internal static event Action<nint> OnSMModifiedCalled;
    internal static event Action<LociStatus, bool> OnStatusModifiedCalled;
    internal static event Action<LociPresetInfo, bool> OnPresetModifiedCalled;
    internal static event Action<nint, string, LociStatusInfo> OnApplyToTargetCalled;
    internal static event Action<nint, string, List<LociStatusInfo>> OnApplyToTargetBulkCalled;
}
