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
    [ActionTitle("Is Button Up")]
    [ActionDescription("Checks if the button is down")]
    public class IsButtonUp : UFAction
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
            if(Controller.GetButtonUp(ButtonId))
            { True(); }
            else 
            { False(); }
        }
    }
}