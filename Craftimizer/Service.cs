using Craftimizer.Utils;
using Dalamud.Game;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using Dalamud.Storage.Assets;

namespace Craftimizer.Plugin;

#pragma warning disable SeStringEvaluator

public sealed class Service
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [PluginService] public static IDalamudPluginInterface PluginInterface { get; private set; }
    [PluginService] public static ICommandManager CommandManager { get; private set; }
    [PluginService] public static IObjectTable Objects { get; private set; }
    [PluginService] public static ISigScanner SigScanner { get; private set; }
    [PluginService] public static IGameGui GameGui { get; private set; }
    [PluginService] public static IClientState ClientState { get; private set; }
    [PluginService] public static IDataManager DataManager { get; private set; }
    [PluginService] public static ITextureProvider TextureProvider { get; private set; }
    [PluginService] public static IDalamudAssetManager DalamudAssetManager { get; private set; }
    [PluginService] public static ITargetManager TargetManager { get; private set; }
    [PluginService] public static ICondition Condition { get; private set; }
    [PluginService] public static IFramework Framework { get; private set; }
    [PluginService] public static IPluginLog PluginLog { get; private set; }
    [PluginService] public static IGameInteropProvider GameInteropProvider { get; private set; }
    [PluginService] public static INotificationManager NotificationManager { get; private set; }
    [PluginService] public static ISeStringEvaluator SeStringEvaluator { get; private set; }

    public static Plugin Plugin { get; private set; }
    public static Configuration Configuration => Plugin.Configuration;
    public static IconManager IconManager => Plugin.IconManager;
    public static WindowSystem WindowSystem => Plugin.WindowSystem;
    public static CommunityMacros CommunityMacros => Plugin.CommunityMacros;
    public static Ipc Ipc => Plugin.Ipc;
#pragma warning restore CS8618

    internal static void Initialize(Plugin plugin, IDalamudPluginInterface iface)
    {
        Plugin = plugin;
        iface.Create<Service>();
    }
}
