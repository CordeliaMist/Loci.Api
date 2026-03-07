namespace Loci.Api.API;

public interface ILociApi
{
    public ILociApiPresets Presets { get; }
    public ILociApiStatuses Statuses { get; }
}
