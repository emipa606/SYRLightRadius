using HarmonyLib;
using RimWorld;
using Verse;

namespace Syr_LightRadius;

[HarmonyPatch(typeof(Designator_Place), nameof(Designator_Place.SelectedUpdate))]
public class Designator_Place_SelectedUpdate
{
    public static void Postfix(Designator_Place __instance)
    {
        if (ArchitectCategoryTab.InfoRect.Contains(UI.MousePositionOnUIInverted) ||
            __instance.PlacingDef is not ThingDef { defName: not null } thingDef ||
            !thingDef.HasComp(typeof(CompGlower)) ||
            !thingDef.selectable)
        {
            return;
        }

        var compProperties = thingDef.GetCompProperties<CompProperties_Glower>();
        if (LightRadiusCore.settings.innerLight)
        {
            GenDraw.DrawRadiusRing(UI.MouseCell(), (compProperties.glowRadius * 0.91f) - 2f);
        }

        if (LightRadiusCore.settings.outerLight)
        {
            GenDraw.DrawRadiusRing(UI.MouseCell(), (compProperties.glowRadius * 0.91f) - 0.5f,
                LightRadiusCore.OuterRingColor);
        }
    }
}