using System;
using Rewired;
using UnityEngine;

namespace ECSModules.Rewired.Extensions
{
    public static class KeyCodeExtensions
    {
        public static KeyCode ToKeyCode(this string keyCodeString)
        {
            try
            {
                var keycode = Enum.Parse(typeof(KeyCode), keyCodeString, true);
                return (KeyCode)keycode;
            }
            catch (Exception e)
            {
                return KeyCode.None;
            }
        }

        public static ModifierKey ToModifierKeyCode(this string keyCodeString)
        {
            try
            {
                var keycode = Enum.Parse(typeof(KeyCode), keyCodeString, true);
                return (ModifierKey)keycode;
            }
            catch (Exception e)
            {
                return ModifierKey.None;
            }
        }
    }
}
