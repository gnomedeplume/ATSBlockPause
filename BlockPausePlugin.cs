using BepInEx;
using Eremite.Services;
using HarmonyLib;
using System.Reflection;

namespace ATSBlockPause
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class BlockPausePlugin : BaseUnityPlugin
    {
        public const string pluginGuid = "gnomedeplume.againstthestorm.blockpause";
        public const string pluginName = "ATS Block Pause";
        public const string pluginVersion = "0.1";

        public void Awake()
        {
            Logger.LogInfo("Disabling pausing...");

            Harmony harmony = new Harmony(pluginGuid);

            MethodInfo originalIsPauseBlocked = AccessTools.Method(typeof(EffectsService), "IsPauseBlocked");
            MethodInfo isPauseBlockedPostPatch = AccessTools.Method(typeof(PausePatches), "IsPauseBlocked_PostPatch");

            harmony.Patch(originalIsPauseBlocked, null, new HarmonyMethod(isPauseBlockedPostPatch));

            Logger.LogInfo("Pausing disabled. Good luck!");
        }
    }
}
