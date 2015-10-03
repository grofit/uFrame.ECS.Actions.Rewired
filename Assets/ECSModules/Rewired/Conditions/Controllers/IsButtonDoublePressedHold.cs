#region

using System;
using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers
{
    [uFrameCategory("Rewired", "Controllers")]
    [ActionTitle("Is Button Double Pressed Hold")]
    [ActionDescription("Checks if the button has been pressed down twice and is held")]
    public class IsButtonDoublePressedHold : UFAction
    {
        [In]
        public int ButtonId;

        [In]
        public Controller Controller;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(Controller.GetButtonDoublePressHold(ButtonId))
            { True(); }
            else
            { False(); }
        }
    }
}