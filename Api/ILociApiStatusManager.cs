using LociApi.Enums;

namespace LociApi.Api;


/// <summary>
///   Functions for interacting with the status manager.
/// </summary>
public interface ILociApiStatusManager
{

    public (LociApiEc, string) GetOwnManager();
    public (LociApiEc, string) GetManagerByPtr(nint ptr);
    public (LociApiEc, string) GetManagerByName(string identifier);
    public (LociApiEc, List<LociStatusInfo>) GetOwnManagerInfo();
    public (LociApiEc, List<LociStatusInfo>) GetManagerInfoByPtr(nint ptr);
    public (LociApiEc, List<LociStatusInfo>) GetManagerInfoByName(string identifier);
    public (LociApiEc, object) SetOwnManager(string identifier);
    public (LociApiEc, object) SetManagerByPtr(nint ptr, string identifier);
    public (LociApiEc, object) SetManagerByName(string name, string identifier);
    public (LociApiEc, object) ClearOwnManager();
    public (LociApiEc, object) ClearManagerByPtr(nint ptr);
    public (LociApiEc, object) ClearManagerByName(string identifier);
}
