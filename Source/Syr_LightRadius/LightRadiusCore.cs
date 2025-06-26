using System.Reflection;
using HarmonyLib;
using Mlie;
using UnityEngine;
using Verse;

namespace Syr_LightRadius;

public class LightRadiusCore : Mod
{
    public static LightRadiusSettings Settings;
    private static string currentVersion;
    public static Color OuterRingColor = new(0.6f, 0.4f, 0.2f);

    public LightRadiusCore(ModContentPack content)
        : base(content)
    {
        Settings = GetSettings<LightRadiusSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
        new Harmony("Syrchalis.Rimworld.LightRadius").PatchAll(Assembly.GetExecutingAssembly());
    }

    public override string SettingsCategory()
    {
        return "SyrLightRadiusSettingsCategory".Translate();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(inRect);
        listingStandard.CheckboxLabeled("SyrLightRadius_innerLightDesc".Translate(),
            ref Settings.InnerLight, "SyrLightRadius_innerLightTooltip".Translate());
        listingStandard.Gap();
        listingStandard.CheckboxLabeled("SyrLightRadius_outerLightDesc".Translate(),
            ref Settings.OuterLight, "SyrLightRadius_outerLightTooltip".Translate());
        if (currentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("SyrLightRadius_currentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }
}