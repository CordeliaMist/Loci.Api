using LociApi.Enums;
namespace LociApi.Api;

/// <summary>
///   Functions for interacting with a status.
/// </summary>
public interface ILociApiStatuses
{
    #region Data Reading

    public (LociApiEc, LociStatusInfo) GetStatusInfo(Guid guid);
    public (LociApiEc, List<LociStatusInfo>) GetAllStatusInfo();

    #endregion

    #region Status Interactions

    public LociApiEc ApplyStatus(Guid guid);
    public LociApiEc ApplyLockedStatus(Guid guid, uint key);
    public (LociApiEc, object) ApplyStatuses(List<Guid> guids);
    public (LociApiEc, object) ApplyLockedStatuses(List<Guid> guids, uint key);

    public (LociApiEc, object) ApplyStatusInfo(LociStatusInfo statusInfo);
    public LociApiEc ApplyLockedStatusInfo(LociStatusInfo statusInfo, uint key);
    public (LociApiEc, object) ApplyStatusInfos(List<LociStatusInfo> statusInfos);
    public (LociApiEc, object) ApplyLockedStatusInfos(List<LociStatusInfo> statusInfos, uint key);

    public (LociApiEc, object) ApplyStatusByPtr(Guid guid, nint ptr);
    public (LociApiEc, object) ApplyStatusesByPtr(List<Guid> guids, nint ptr);
    public (LociApiEc, object) ApplyStatusByName(Guid guid, string name);
    public (LociApiEc, object) ApplyStatusesByName(List<Guid> guids, nint ptr);

    public LociApiEc RemoveStatus(Guid guid);
    public (LociApiEc, object) RemoveStatuses(List<Guid> guids);
    public LociApiEc RemoveStatusByPtr(Guid guid, nint ptr);
    public (LociApiEc, object) RemoveStatusesByPtr(List<Guid> guids, nint ptr);
    public LociApiEc RemoveStatusByName(Guid guid, string name);
    public (LociApiEc, object) RemoveStatusesByName(List<Guid> guids, string name);

    #endregion

    #region Status Locking

    public LociApiEc LockStatus(Guid status, uint key);
    public LociApiEc LockStatuses(List<Guid> statuses, uint key);
    public LociApiEc UnlockStatus(Guid status, uint key);
    public LociApiEc UnlockStatuses(List<Guid> statuses, uint key);
    public LociApiEc ClearLocks(uint key);

    #endregion
}
