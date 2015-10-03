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
    [ActionTitle("Is Connected")]
    [ActionDescription("Checks if the controller is connected")]
    public class IsConnected : UFAction
    {
        [In]
        private Controller Controller;
        
        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(Controller.isConnected)
            { True(); }
            else
            { False(); }
        }
    }
}