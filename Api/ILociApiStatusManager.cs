using LociApi.Enums;

namespace LociApi.Api;

/// <summary>
///   Functions for interacting with the status manager.
/// </summary>
public interface ILociApiStatusManager
{

    // Gets the ClientPlayers Manager. This will always be valid.
    // Can return Success, TargetNotFound, TargetInvalid, DataNotFound
    public (LociApiEc, string?) GetManager();
    public (LociApiEc, string?) GetManagerByPtr(nint address);
    public (LociApiEc, string?) GetManagerByName(string charaName, string buddyName);
    
    // Tuple format. Always returns an empty list on failure.
    // (Can change in the future maybe?)
    public List<LociStatusInfo> GetManagerInfo();
    public List<LociStatusInfo> GetManagerInfoByPtr(nint ptr);
    public List<LociStatusInfo> GetManagerInfoByName(string charaName, string buddyName);

    // Attempts to set an actors status manager. Informs with return code how that went.
    // Returns Success, NoChange, TargetNotFound, TargetInvalid, DataNotFound, DataInvalid.
    // (Fail if the client and locks are present)
    public LociApiEc SetManager(string base64Data);
    public LociApiEc SetManagerByPtr(nint address, string base64Data);
    public LociApiEc SetManagerByName(string charaName, string buddyName, string base64Data);
    
    // Same rules as above, but for clearing.
    // For clearing, if the client, do not clear locked statuses, but allow method?
    public LociApiEc ClearManager();
    public LociApiEc ClearManagerByPtr(nint ptr);
    public LociApiEc ClearManagerByName(string charaName, string buddyName);

    // Occurs whenever a manager was modified in any way.
    public event Action<nint> ManagerChanged;
    
    // When a status is added or removed from an actors Manager, this is fired.
    // It attached the GUID in question, and how it effected the SM.
    public event ManagerStatusesChangedDelegate? ManagerStatusesChanged;

    /// <summary>
    ///   Triggered when ApplyToTarget in the Status or 
    ///   Preset tab of Loci is used on a target that is Ephemeral.
    /// </summary>
    /// <remarks> This does not fire if applied to a non-ephemeral target. </remarks>
    public event ApplyToTargetDelegate? ApplyToTargetSent;

}
