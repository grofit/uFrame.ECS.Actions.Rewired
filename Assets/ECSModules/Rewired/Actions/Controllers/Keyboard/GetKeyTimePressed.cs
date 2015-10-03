#region

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
    [ActionTitle("Get Key Time Pressed")]
    [ActionDescription("Gets the time a key was pressed for")]
    public class GetKeyTimePressed : UFAction
    {
        [In]
        public KeyCode KeyCode;

        [In]
        public string KeyName;

        [In]
        public float TimePressed;
 
        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToKeyCode();
            TimePressed = ReInput.controllers.Keyboard.GetKeyTimePressed(usedKeyCode);
        }
    }
}