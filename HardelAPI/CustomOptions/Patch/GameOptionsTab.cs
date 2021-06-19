﻿using HarmonyLib;
using UnityEngine;

namespace HardelAPI.CustomOptions.Patch {

    [HarmonyPatch(typeof(GameOptionsMenu), nameof(GameOptionsMenu.Start))]
    public static class GameOptionsMenuPatch {
        public static void Postfix(GameOptionsMenu __instance) {
            foreach (var Children in __instance.Children) {
                Children.transform.localScale = new Vector3(
                    Children.transform.localScale.x * 1.1f,
                    Children.transform.localScale.y,
                    Children.transform.localScale.z
                );
            }
        }
    }

    [HarmonyPatch(typeof(GameSettingMenu), nameof(GameSettingMenu.OnEnable))]
    public static class GameSettingMenuPatch {
        public static void Postfix(GameSettingMenu __instance) {
            Transform Background = __instance.gameObject.transform.GetChild(0);
            Background.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.085f, 0.085f, 0.085f, 1f);
            Background.localPosition = new Vector3(0f, -0.300f, 1f);
            Background.localScale = new Vector3(
                Background.localScale.x * 1.1f,
                Background.localScale.y * 1.175f,
                Background.localScale.z
            );
        }
    }
}
