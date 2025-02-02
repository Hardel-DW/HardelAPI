﻿using HarmonyLib;
using System.Linq;

namespace Harion.CustomRoles.Patch {

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CompleteTask))]
    public class TasksComplete {

        public static void Postfix(PlayerControl __instance) {
            int taskLeft = __instance.Data.Tasks.ToArray().Count(x => !x.Complete);

            foreach (var Role in RoleManager.AllRoles) {
                Role.OnTaskComplete(__instance);
                Role.OnTaskLeft(__instance, taskLeft);

                if (taskLeft == 0)
                    Role.OnAllTaskComplete(__instance);
            }
        }
    }
}
