namespace LociApi.Enums;

/// <summary>
///   The interaction types that define a LociEvent.
/// </summary>
public enum EventBehavior : byte
{
    /// <summary>
    ///   The attached status / preset will be applied. Existing statuses are ignored.
    /// </summary>
    Apply = 0,

    /// <summary>
    ///   The attached status / preset is applied, overwriting any existing statuses matching it.
    /// </summary>
    ApplyAuthorative = 1,

    /// <summary>
    ///   The attached status / preset is applied upon entering the condition, and removed upon exiting the condition.  
    /// </summary>
    InThatCondition = 2,

    /// <summary>
    ///   The status / preset is applied, overwriting any existing statuses matching it, and removed upon exiting the condition.
    /// </summary>
    InThatConditionAuthorative = 3,

    /// <summary>
    ///   Remove the status / presets statuses when the event is triggered.
    /// </summary>
    Remove = 4,
}
