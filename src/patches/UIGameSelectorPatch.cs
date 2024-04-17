using Brix.UI.GameSelector;
using HarmonyLib;

namespace CastleStory_UnlimitedSelect
{
    [HarmonyPatch(typeof(UIGameSelector), "InitializeSelectionData")]
    public class UIGameSelectorPatch
    {
        static void Prefix(UIGameSelector __instance)
        {
            __instance.MaximumHoveredOrSelectedCount = int.MaxValue;
        }
    }
}
