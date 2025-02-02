﻿namespace Harion.CustomRoles {
    public static class RoleUtils {
        public static bool Is<T>(this PlayerControl player) where T : RoleManager {
            for (int i = 0; i < RoleManager.AllRoles.Count; i++)
                if (RoleManager.AllRoles[i].ClassType.GetType() == typeof(T).GetType())
                    return RoleManager.AllRoles[i].HasRole(player);

            return false;
        }
    }
}
