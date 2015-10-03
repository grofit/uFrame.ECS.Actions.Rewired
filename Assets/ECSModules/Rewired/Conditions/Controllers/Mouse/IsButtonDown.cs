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
    [ActionTitle("Is Button Down")]
    [ActionDescription("Checks if the button has been pressed down")]
    public class IsButtonDown : UFAction
    {
        [In]
        public int MouseButton;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(ReInput.controllers.Mouse.GetButtonDown(MouseButton))
            { True(); }
            else
            { False(); }
        }
    }
}