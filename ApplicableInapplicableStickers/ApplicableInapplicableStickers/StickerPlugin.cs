using BepInEx;
using HarmonyLib;

namespace ApplicableInapplicableStickers;

[BepInPlugin("denyscrasav4ik.thedumbfactory.applicableinapplicablestickers", "Applicable Inapplicable Stickers", "1.0.0")]
public class UnrestrictedStickersPlugin : BaseUnityPlugin
{
    private void Awake() => new Harmony("denyscrasav4ik.thedumbfactory.applicableinapplicablestickers").PatchAll();
}

[HarmonyPatch(typeof(StickerManager))]
public static class StickerManagerPatches
{
    [HarmonyPatch("StickerCanBeApplied")]
    [HarmonyPrefix]
    internal static bool PrefixStickerCanBeApplied(ref bool __result)
    {
        __result = true;
        return false;
    }

    [HarmonyPatch("StickerCanBeCovered")]
    [HarmonyPrefix]
    internal static bool PrefixStickerCanBeCovered(ref bool __result)
    {
        __result = true;
        return false;
    }
}
