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
    [ActionTitle("Is Button Double Pressed Down")]
    [ActionDescription("Checks if the button has been pressed down twice")]
    public class IsButtonDoublePressedDown : UFAction
    {
        [In]
        public int MouseButton;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Mouse.GetButtonDoublePressDown(MouseButton))
            { True(); }
            else
            { False(); }
        }
    }
}