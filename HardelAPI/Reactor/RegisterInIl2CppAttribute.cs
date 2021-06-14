﻿/** This is Reactor Source Code, from js6pak.
 * If Reactor asks me, I will deleted this file.
 * 
 * Reactor Github :
 * https://github.com/NuclearPowered/Reactor/tree/master/Reactor
 * 
 * Link to Orignal Class RegisterInIl2CppAttribute :
 * https://github.com/NuclearPowered/Reactor/blob/master/Reactor/RegisterInIl2CppAttribute.cs
 * 
 * Discord :
 * https://discord.gg/et5XGTMfPz
 * 
 * Website :
 * https://reactor.gg/
 * 
 * Documentation :
 * https://docs.reactor.gg/
*/
using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using UnhollowerRuntimeLib;

namespace HardelAPI.Reactor {
    /// <summary>
    /// Utility attribute for automatically calling <see cref="ClassInjector.RegisterTypeInIl2Cpp{T}()"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterInIl2CppAttribute : Attribute {
        [Obsolete("You don't need to call this anymore", true)]
        public static void Register() {
        }

        private static readonly AccessTools.FieldRef<object, HashSet<string>> _injectedTypes
            = AccessTools.FieldRefAccess<HashSet<string>>(typeof(ClassInjector), "InjectedTypes");

        private static readonly Func<Type, IntPtr> _readClassPointerForType = AccessTools.MethodDelegate<Func<Type, IntPtr>>(
            AccessTools.Method(typeof(ClassInjector), "ReadClassPointerForType")
        );

        private static bool IsInjected(Type type) {
            if (_readClassPointerForType(type) != IntPtr.Zero) {
                return true;
            }

            var injectedTypes = _injectedTypes();

            lock (injectedTypes) {
                if (injectedTypes.Contains(type.FullName)) {
                    return true;
                }
            }

            return false;
        }

        private static void Register(Type type) {
            if (type.BaseType?.GetCustomAttribute<RegisterInIl2CppAttribute>() != null) {
                Register(type.BaseType);
            }

            if (IsInjected(type)) {
                return;
            }

            try {
                ClassInjector.RegisterTypeInIl2Cpp(type);
            } catch (Exception e) {
                HardelApiPlugin.Logger.LogWarning($"Failed to register {type.FullDescription()}: {e}");
            }
        }

        public static void Register(Assembly assembly) {
            foreach (var type in assembly.GetTypes()) {
                if (type.GetCustomAttribute<RegisterInIl2CppAttribute>() != null) {
                    Register(type);
                }
            }
        }

        internal static void Initialize() {
            ChainloaderHooks.PluginLoad += plugin => Register(plugin.GetType().Assembly);
        }
    }
}
