using BepInEx;
using HarmonyLib;

namespace CastleStory_UnlimitedSelect
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("com.wasikuss.castlestory.unlimitedselect").PatchAll();
        }
    }
}
