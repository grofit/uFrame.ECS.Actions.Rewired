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
    [ActionTitle("Is Modifier Key Down")]
    [ActionDescription("Checks if the modifier key is pressed")]
    public class IsModifierKeyDown : UFAction
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
            if(ReInput.controllers.Keyboard.GetModifierKeyDown(usedKeyCode))
            { True(); }
            else
            { False(); }
        }
    }
}