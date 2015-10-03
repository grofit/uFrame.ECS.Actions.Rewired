#region

using System.ComponentModel;
using System.Text;
using ECSModules.Rewired.Extensions;
using Rewired;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

#endregion

namespace ECSModules.Rewired.Controllers.Keyboard
{
    [uFrameCategory("Rewired", "Controllers", "Keyboard")]
    [ActionTitle("Get Key Time Unpressed")]
    [ActionDescription("Gets the time a key was unpressed for")]
    public class GetKeyTimeUnpressed : UFAction
    {
        [In]
        public KeyCode KeyCode;

        [In]
        public string KeyName;
        
        [Out]
        public float TimeUnpressed;
        

        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToKeyCode();
            TimeUnpressed = ReInput.controllers.Keyboard.GetKeyTimeUnpressed(usedKeyCode);
        }
    }
}