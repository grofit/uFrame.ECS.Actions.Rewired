#region

using System;
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
    [ActionTitle("Is Key Down")]
    [ActionDescription("Checks if the key is not pressed")]
    
    public class IsKeyDown : UFAction
    {
        [In]
        public KeyCode KeyCode;

        [In]
        public string KeyName;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var usedKeyCode = string.IsNullOrEmpty(KeyName) ? KeyCode : KeyName.ToKeyCode();
            if(ReInput.controllers.Keyboard.GetKeyDown(usedKeyCode))
            { True(); }
            else
            { False(); }
        }
    }
}