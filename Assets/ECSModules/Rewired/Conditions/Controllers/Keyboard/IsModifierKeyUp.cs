#region

using System;
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
    [ActionTitle("Is Modifier Key Up")]
    [ActionDescription("Checks if the modifier key is not pressed")]
    public class IsModifierKeyUp : UFAction
    {
        [In]
        public ModifierKey ModifierKey;

        [In]
        public string KeyName;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? ModifierKey : KeyName.ToModifierKeyCode();
            if(ReInput.controllers.Keyboard.GetModifierKeyUp(usedKeyCode))
            { True(); }
            else
            { False(); }
        }
    }
}