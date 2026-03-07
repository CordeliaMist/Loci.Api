using Loci.Api.Enums;

namespace Loci.Api.API;

/// <summary>
/// Functions to manage registry in the status manager.
/// </summary>
public interface ILociApiRegistry
{
    /// <summary>
    /// Register an actor to be handled by Loci via their object pointer.
    /// </summary>
    /// <param name="ptr">The pointer referring to the player actor to add as managed.</param>
    /// <param name="provider">A unique identifier shared across your plugin.</param>
    /// <returns><see cref="LociApiEc"/>: TargetNotFound, Success.</returns>
    /// <remarks>  The passed identifier is a string that will be visible to users of Loci, so this should be the name of your plugin. </remarks>
    public LociApiEc RegisterActorByPtr(nint ptr, string provider);

    /// <summary>
    /// Register an actor as managed via their name and world.
    /// </summary>
    /// <param name="name"> The player's name with world, in the format "First Last@World" </param>
    /// <param name="provider">A unique identifier shared across your plugin.</param>
    /// <returns><see cref="LociApiEc"/>: TargetNotFound, Success.</returns>
    /// <remarks>  The passed identifier is a string that will be visible to users of Loci, so this should be the name of your plugin. </remarks>
    public LociApiEc RegisterActorByName(string name, string provider);

    /// <summary>
    /// Remove a prior registration for a managed actor via their object pointer.
    /// </summary>
    /// <param name="ptr">The pointer referring to the player actor to remove from the manager.</param>
    /// <param name="provider">A unique identifier shared across your plugin.</param>
    /// <returns><see cref="LociApiEc"/>: TargetNotFound, Success.</returns>
    /// <remarks>  The passed identifier is a string that will be visible to users of Loci, so this should be the name of your plugin.</remarks>
    public LociApiEc UnregisterActorByPtr(nint ptr, string provider);

    /// <summary>
    /// Remove a prior registration for a managed actor via their name and world
    /// </summary>
    /// <param name="name">The player's name with world, in the format "First Last@World"</param>
    /// <param name="provider">A unique identifier shared across your plugin.</param>
    /// <returns><see cref="LociApiEc"/>: TargetNotFound, Success.</returns>
    /// <remarks>  The passed identifier is a string that will be visible to users of Loci, so this should be the name of your plugin.</remarks>
    public LociApiEc UnregisterActorByName(string name, string provider);
}
