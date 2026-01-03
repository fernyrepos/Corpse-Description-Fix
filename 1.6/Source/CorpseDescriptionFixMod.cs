using HarmonyLib;
using Verse;

namespace CorpseDescriptionFix
{
    public class CorpseDescriptionFixMod : Mod
    {
        public CorpseDescriptionFixMod(ModContentPack pack) : base(pack)
        {
            new Harmony("CorpseDescriptionFixMod").PatchAll();
        }
    }
}