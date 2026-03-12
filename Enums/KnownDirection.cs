namespace LociApi.Enums;

/// <summary> Possible types of directional relation for an interaction. </summary>
public enum KnownDirection : byte
{
    /// <summary>
    ///   You performed the interaction.
    /// </summary>
    Self = 0,

    /// <summary>
    ///   You performed the interaction on someone else besides yourself.
    /// </summary>
    SelfToOther = 1,

    /// <summary>
    ///   Someone else performed the interaction (at all)
    /// </summary>
    Other = 2,

    /// <summary>
    ///   Another entity performed the interaction to you.
    /// </summary>
    OtherToSelf = 3,

    /// <summary>
    ///   The interaction occured at all, and we do not care how it happened.
    /// </summary>
    Any = 4,
}
