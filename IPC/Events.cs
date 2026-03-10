using Dalamud.Plugin;
using LociApi.Api;
using LociApi.Enums;
using LociApi.Helpers;
using Newtonsoft.Json.Linq;

namespace LociApi.Ipc;

/// <inheritdoc cref="ILociApiEvents.GetEventList"/>
public sealed class GetEventList(IDalamudPluginInterface pi) : FuncSubscriber<Dictionary<Guid, string>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventList)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventList"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventList"/>
    public new Dictionary<Guid, string> Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Dictionary<Guid, string>> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, api.GetEventList);
}

/// <inheritdoc cref="ILociApiEvents.GetEventInfo"/>
public sealed class GetEventInfo(IDalamudPluginInterface pi) : FuncSubscriber<Guid, (int, LociEventInfo)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventInfo)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventInfo"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventInfo"/>
    public new (LociApiEc, LociEventInfo) Invoke(Guid guid)
    {
        var (ec, info) = base.Invoke(guid);
        return ((LociApiEc)ec, info);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, (int, LociEventInfo)> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a) =>
        {
            var (ec, info) = api.GetEventInfo(a);
            return ((int)ec, info);
        });
}

/// <inheritdoc cref="ILociApiEvents.GetEventInfoList"/>
public sealed class GetEventInfoList(IDalamudPluginInterface pi) : FuncSubscriber<List<LociEventInfo>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventInfoList)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventInfoList"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventInfoList"/>
    public new List<LociEventInfo> Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<List<LociEventInfo>> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, api.GetEventInfoList);
}

/// <inheritdoc cref="ILociApiEvents.GetEventSummary"/>
public sealed class GetEventSummary(IDalamudPluginInterface pi) : FuncSubscriber<Guid, (int, LociEventSummary)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventSummary)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventSummary"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventSummary"/>
    public new (LociApiEc, LociEventSummary) Invoke(Guid guid)
    {
        var (ec, summary) = base.Invoke(guid);
        return ((LociApiEc)ec, summary);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, (int, LociEventSummary)> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a) =>
        {
            var (ec, summary) = api.GetEventSummary(a);
            return ((int)ec, summary);
        });
}

/// <inheritdoc cref="ILociApiEvents.GetEventSummaryList"/>
public sealed class GetEventSummaryList(IDalamudPluginInterface pi) : FuncSubscriber<List<LociEventSummary>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventSummaryList)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventSummaryList"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventSummaryList"/>
    public new List<LociEventSummary> Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<List<LociEventSummary>> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, api.GetEventSummaryList);
}

/// <inheritdoc cref="ILociApiEvents.CreateEvent"/>
public sealed class CreateEvent(IDalamudPluginInterface pi) : FuncSubscriber<string, string, LociEventType, (int, Guid)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(CreateEvent)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.CreateEvent"u8;

    /// <inheritdoc cref="ILociApiEvents.CreateEvent"/>
    public new (LociApiEc, Guid) Invoke(string eventName, string eventData, LociEventType eventType)
    {
        var (ec, id) = base.Invoke(eventName, eventData, eventType);
        return ((LociApiEc)ec, id);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, LociEventType, (int, Guid)> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a, b, c) =>
        {
            var (ec, id) = api.CreateEvent(a, b, c);
            return ((int)ec, id);
        });
}

/// <inheritdoc cref="ILociApiEvents.DeleteEvent"/>
public sealed class DeleteEvent(IDalamudPluginInterface pi) : FuncSubscriber<Guid, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(DeleteEvent)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.DeleteEvent"u8;

    /// <inheritdoc cref="ILociApiEvents.DeleteEvent"/>
    public new LociApiEc Invoke(Guid eventId)
        => (LociApiEc)base.Invoke(eventId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, int> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a) => (int)api.DeleteEvent(a));
}

/// <inheritdoc cref="ILociApiEvents.SetEventState"/>
public sealed class SetEventState(IDalamudPluginInterface pi) : FuncSubscriber<Guid, bool, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(SetEventState)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.SetEventState"u8;

    /// <inheritdoc cref="ILociApiEvents.SetEventState"/>
    public new LociApiEc Invoke(Guid eventId, bool newState)
        => (LociApiEc)base.Invoke(eventId, newState);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, bool, int> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a, b) => (int)api.SetEventState(a, b));
}

/// <inheritdoc cref="ILociApiEvents.SetEventStates"/>
public sealed class SetEventStates(IDalamudPluginInterface pi) : FuncSubscriber<List<Guid>, bool, (int, List<Guid>)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(SetEventStates)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.SetEventStates"u8;

    /// <inheritdoc cref="ILociApiEvents.SetEventStates"/>
    public new (LociApiEc, List<Guid>) Invoke(List<Guid> eventIds, bool newState)
    {
        var (ec, failed) = base.Invoke(eventIds, newState);
        return ((LociApiEc)ec, failed);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<List<Guid>, bool, (int, List<Guid>)> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (a, b) =>
        {
            List<Guid> failed;
            var ec = api.SetEventStates(a, b, out failed);
            return ((int)ec, failed);
        });
}

/// <inheritdoc cref="ILociApiEvents.GetEventBase64"/>
public sealed class GetEventBase64(IDalamudPluginInterface pi) : FuncSubscriber<Guid, string?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventBase64)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventBase64"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventBase64"/>
    public new string? Invoke(Guid eventId)
        => base.Invoke(eventId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, string?> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, api.GetEventBase64);
}

/// <inheritdoc cref="ILociApiEvents.GetEventJObject"/>
public sealed class GetEventJObject(IDalamudPluginInterface pi) : FuncSubscriber<Guid, JObject?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetEventJObject)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetEventJObject"u8;

    /// <inheritdoc cref="ILociApiEvents.GetEventJObject"/>
    public new JObject? Invoke(Guid eventId)
        => base.Invoke(eventId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, JObject?> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, api.GetEventJObject);
}

/// <inheritdoc cref="ILociApiEvents.EventAdded"/>
public static class EventAdded
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(EventAdded)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.EventAdded"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<Guid> Subscriber(IDalamudPluginInterface pi, params Action<Guid>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<Guid> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (t => api.EventAdded += t, t => api.EventAdded -= t));
}

/// <inheritdoc cref="ILociApiEvents.EventDeleted"/>
public static class EventDeleted
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(EventDeleted)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.EventDeleted"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<Guid> Subscriber(IDalamudPluginInterface pi, params Action<Guid>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<Guid> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (t => api.EventDeleted += t, t => api.EventDeleted -= t));
}

/// <inheritdoc cref="ILociApiEvents.EventPathMoved"/>
public static class EventPathMoved
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(EventPathMoved)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.EventPathMoved"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<Guid, string> Subscriber(IDalamudPluginInterface pi, params Action<Guid, string>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<Guid, string> Provider(IDalamudPluginInterface pi, ILociApiEvents api)
        => new(pi, Label, (t => api.EventPathMoved += t, t => api.EventPathMoved -= t));
}
