#region

using System;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Has Mouse Assigned")]
    [ActionDescription("Checks if the button is down")]
    public class HasMouseAssigned : UFAction
    {
        [In]
        public RWPlayer Player;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(Player.controllers.hasMouse)
            { True(); }
            else
            { False(); }
        }
    }
}