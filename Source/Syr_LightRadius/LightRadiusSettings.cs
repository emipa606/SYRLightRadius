using Verse;

namespace Syr_LightRadius;

public class LightRadiusSettings : ModSettings
{
    public bool innerLight = true;

    public bool outerLight;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref innerLight, "SyrLightRadius_innerLight", true);
        Scribe_Values.Look(ref outerLight, "SyrLightRadius_outerLight");
    }
}