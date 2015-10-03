#region

using System.ComponentModel;
using System.Text;
using ECSModules.Rewired.Extensions;
using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Keyboard
{
    [uFrameCategory("Rewired", "Controllers", "Keyboard")]
    [ActionTitle("Get Modifier Key")]
    [ActionDescription("Gets the modifier key state")]
    public class GetModifierKey : UFAction
    {
        [In]
        public ModifierKey KeyCode;

        [In]
        public string KeyName;
        
        [Out]
        public bool KeyState;

        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToModifierKeyCode();
            KeyState = ReInput.controllers.Keyboard.GetModifierKey(usedKeyCode);
        }
    }
}