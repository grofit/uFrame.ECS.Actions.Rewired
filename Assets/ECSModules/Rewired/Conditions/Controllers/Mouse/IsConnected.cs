#region

using System;
using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Mouse
{
    [uFrameCategory("Rewired", "Controllers", "Mouse")]
    [ActionTitle("Is Connected")]
    [ActionDescription("Checks if the mouse is connected")]
    public class IsConnected : UFAction
    {
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Mouse.isConnected)
            { True(); }
            else
            { False(); }
        }
    }
}