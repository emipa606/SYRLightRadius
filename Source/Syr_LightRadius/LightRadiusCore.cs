using System.Reflection;
using HarmonyLib;
using Mlie;
using UnityEngine;
using Verse;

namespace Syr_LightRadius;

public class LightRadiusCore : Mod
{
    public static LightRadiusSettings settings;
    private static string currentVersion;
    public static Color OuterRingColor = new Color(0.6f, 0.4f, 0.2f);

    public LightRadiusCore(ModContentPack content)
        : base(content)
    {
        settings = GetSettings<LightRadiusSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
        new Harmony("Syrchalis.Rimworld.LightRadius").PatchAll(Assembly.GetExecutingAssembly());
    }

    public override string SettingsCategory()
    {
        return "SyrLightRadiusSettingsCategory".Translate();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(inRect);
        listing_Standard.CheckboxLabeled("SyrLightRadius_innerLightDesc".Translate(),
            ref settings.innerLight, "SyrLightRadius_innerLightTooltip".Translate());
        listing_Standard.Gap();
        listing_Standard.CheckboxLabeled("SyrLightRadius_outerLightDesc".Translate(),
            ref settings.outerLight, "SyrLightRadius_outerLightTooltip".Translate());
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("SyrLightRadius_currentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }
}