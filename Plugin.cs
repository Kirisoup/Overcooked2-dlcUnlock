using BepInEx;
using HarmonyLib;

namespace ocdlcu
{
        [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
        public class Plugin : BaseUnityPlugin
        {
                void Awake() => Harmony.CreateAndPatchAll(typeof(Plugin), "com.kirisoup.divource.ocdlcu");

                [HarmonyPatch(typeof(DLCManagerBase), "IsDLCAvailable")]
                static void Postfix(ref bool __result) => __result = true;
        }
}
