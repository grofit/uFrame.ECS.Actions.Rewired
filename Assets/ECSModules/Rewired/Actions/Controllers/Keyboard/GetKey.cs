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
    [ActionTitle("Get Key")]
    [ActionDescription("Gets the key state")]
    public class GetKey : UFAction
    {
        [In]
        public KeyCode KeyCode;

        [In]
        public string KeyName;

        [Out]
        public bool KeyState;
        
        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToKeyCode();
            KeyState = ReInput.controllers.Keyboard.GetKey(usedKeyCode);
        }
    }
}