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
    [ActionTitle("Is Button Down")]
    [ActionDescription("Checks if the button is down")]
    
    public class IsButtonDown : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            bool isDown;

            if (string.IsNullOrEmpty(ActionName))
            { isDown = Player.GetButtonDown(ActionId); }
            else
            { isDown = Player.GetButtonDown(ActionName);}

            if(isDown)
            { True(); }
            else
            { False(); }
        }
    }
}