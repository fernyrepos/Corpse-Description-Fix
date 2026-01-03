using HarmonyLib;
using RimWorld;
using Verse;

namespace CorpseDescriptionFix
{
    [HarmonyPatch(typeof(ThingDefGenerator_Corpses), nameof(ThingDefGenerator_Corpses.GenerateCorpseDef))]
    public static class ThingDefGenerator_Corpses_GenerateCorpseDef_Patch
    {
        static void Postfix(ThingDef pawnDef, ref ThingDef __result)
        {
            __result.description = pawnDef.description;
        }
    }
}
