using Verse;

namespace Syr_LightRadius;

public class LightRadiusSettings : ModSettings
{
    public bool InnerLight = true;

    public bool OuterLight;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref InnerLight, "SyrLightRadius_innerLight", true);
        Scribe_Values.Look(ref OuterLight, "SyrLightRadius_outerLight");
    }
}