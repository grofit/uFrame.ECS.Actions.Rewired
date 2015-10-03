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
    [ActionTitle("Is Button Double Pressed Hold")]
    [ActionDescription("Checks if the button has been pressed down twice and held")]
    public class IsButtonDoublePressedHold : UFAction
    {
        [In]
        public int ButtonId;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Keyboard.GetButtonDoublePressHold(ButtonId))
            { True(); }
            else 
            { False(); }
        }
    }
}