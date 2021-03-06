﻿using HarmonyLib;
using Studio;

namespace KK_Plugins.MaterialEditor
{
    internal static class StudioHooks
    {
        [HarmonyPrefix, HarmonyPatch(typeof(OCIItem), nameof(OCIItem.OnDelete))]
        internal static void OCIItemOnDelete(OCIItem __instance) => MEStudio.GetSceneController()?.ItemDeleteEvent(__instance.objectInfo.dicKey);
    }
}
