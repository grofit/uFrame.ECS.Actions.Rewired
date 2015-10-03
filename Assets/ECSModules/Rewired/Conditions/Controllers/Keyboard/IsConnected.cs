#region

using System;
using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Keyboard
{
    [uFrameCategory("Rewired", "Controllers", "Keyboard")]
    [ActionTitle("Is Connected")]
    [ActionDescription("Checks if the keyboard is connected")]
    public class IsConnected : UFAction
    {
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Keyboard.isConnected)
            { True(); }
            else
            { False(); }
        }
    }
}