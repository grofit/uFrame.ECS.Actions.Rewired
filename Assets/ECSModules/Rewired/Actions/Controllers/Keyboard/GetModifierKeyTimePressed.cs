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
    [ActionTitle("Get Modifier Key Time Pressed")]
    [ActionDescription("Gets the modifier key time pressed")]
    public class GetModifierKeyTimePressed : UFAction
    {
        [In]
        public ModifierKey KeyCode;

        [In]
        public string KeyName;
        
        [Out]
        public float TimePressed;

        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToModifierKeyCode();
            TimePressed = ReInput.controllers.Keyboard.GetModifierKeyTimePressed(usedKeyCode);
        }
    }
}