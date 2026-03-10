using LociApi.Enums;

namespace LociApi.Api;

/// <summary>
///   Calls associated with the Enabled state of Loci and its processors
/// </summary>
public interface ILociApiState
{
    /// <summary>
    ///     True if Loci has its processors enabled, false otherwise. (Maybe turn into func?)
    /// </summary>
    public bool IsEnabled { get; }

    /// <summary>
    ///     Triggered when the state of Loci's processors changes.
    /// </summary>
    public event Action<bool>? IsEnabledChanged;
}
