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
    [ActionTitle("Is Button Up")]
    [ActionDescription("Checks if the button is not pressed")]
    
    public class IsButtonUp : UFAction
    {
        [In]
        public int ButtonId;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Keyboard.GetButtonUp(ButtonId))
            { True(); }
            else
            { False(); }
        }
    }
}