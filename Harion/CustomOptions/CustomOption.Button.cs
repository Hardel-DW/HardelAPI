﻿using System;

namespace Harion.CustomOptions {
    /// <summary>
    /// A derivative of <see cref="CustomOption"/>, handling "buttons" in the options menu.
    /// </summary>
    public class CustomOptionButton : CustomOption, IToggleOption {
        public override bool SendRpc { get => false; }

        /// <summary>
        /// Adds an option header.
        /// </summary>
        /// <param name="title">The title of the header</param>
        /// <param name="menu">The button will be visible in the lobby options menu</param>
        /// <param name="hud">The button title will appear in the HUD (option list) in the lobby</param>
        /// <param name="initialValue">The button's initial (client sided) value, can be used to hide/show other options</param>
        public CustomOptionButton(string title, bool menu = true, bool hud = false, bool initialValue = false, CustomOption parent = null) : base(title, title, false, CustomOptionType.Toggle, initialValue, parent) {
            HudStringFormat = (_, name, _) => name;
            ValueStringFormat = (_, _) => string.Empty;

            MenuVisible = menu;
            HudVisible = hud;
        }

        protected override bool GameObjectCreated(OptionBehaviour o) {
            if (AmongUsClient.Instance?.AmHost != true || o is not ToggleOption toggle)
                return false;

            toggle.transform.FindChild("CheckBox")?.gameObject?.SetActive(false);

            return UpdateGameObject();
        }

        /// <summary>
        /// Toggles the option value (called when the button is pressed).
        /// </summary>
        public virtual void Toggle() {
            SetValue(!GetValue());
        }

        /// <summary>
        /// Sets a new value
        /// </summary>
        /// <param name="value">The new value</param>
        public virtual void SetValue(bool value) {
            SetValue(value, true);
        }

        /// <returns>The boolean-casted default value.</returns>
        public virtual bool GetDefaultValue() {
            return GetDefaultValue<bool>();
        }

        /// <returns>The boolean-casted old value.</returns>
        public virtual bool GetOldValue() {
            return GetOldValue<bool>();
        }

        /// <returns>The boolean-casted current value.</returns>
        public virtual bool GetValue() {
            return GetValue<bool>();
        }
    }

    public partial class CustomOption {
        /// <summary>
        /// Adds a "button" in the options menu.
        /// </summary>
        /// <param name="title">The title of the button</param>
        /// <param name="menu">The button will be visible in the lobby options menu</param>
        /// <param name="hud">The button title will appear in the HUD (option list) in the lobby</param>
        /// <param name="initialValue">The button's initial (client sided) value, can be used to hide/show other options</param>
        public static CustomOptionButton AddButton(string title, bool menu = true, bool hud = false, bool initialValue = false, CustomOption parent = null) {
            return new CustomOptionButton(title, menu, hud, initialValue, parent);
        }
    }
}