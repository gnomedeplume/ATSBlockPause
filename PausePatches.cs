using Eremite.Services;

namespace ATSBlockPause
{
    class PausePatches
    {
        public static void IsPauseBlocked_PostPatch(EffectsService __instance, ref bool __result)
        {
            __result = true;
        }
    }
}
