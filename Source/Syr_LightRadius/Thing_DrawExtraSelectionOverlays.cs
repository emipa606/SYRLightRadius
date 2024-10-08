using HarmonyLib;
using Verse;

namespace Syr_LightRadius;

[HarmonyPatch(typeof(Thing), nameof(Thing.DrawExtraSelectionOverlays))]
public class Thing_DrawExtraSelectionOverlays
{
    public static void Postfix(Thing __instance)
    {
        if (__instance?.def?.defName == null || !__instance.def.HasComp(typeof(CompGlower)))
        {
            return;
        }

        var compGlower = __instance.TryGetComp<CompGlower>();
        if (LightRadiusCore.settings.innerLight)
        {
            GenDraw.DrawRadiusRing(__instance.Position, (compGlower.Props.glowRadius * 0.91f) - 2f);
        }

        if (LightRadiusCore.settings.outerLight)
        {
            GenDraw.DrawRadiusRing(__instance.Position, (compGlower.Props.glowRadius * 0.91f) - 0.5f,
                LightRadiusCore.OuterRingColor);
        }
    }
}