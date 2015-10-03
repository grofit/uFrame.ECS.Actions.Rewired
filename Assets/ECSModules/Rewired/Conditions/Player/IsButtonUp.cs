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
    [ActionTitle("Is Button Up")]
    [ActionDescription("Checks if the button is down")]
    public class IsButtonUp : UFAction
    {
        public string ActionName;
        public int ActionId = -1;

        [In]
        [Out]
        public RWPlayer Player;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            bool isUp;

            if (string.IsNullOrEmpty(ActionName))
            { isUp = Player.GetButtonUp(ActionId); }
            else
            { isUp = Player.GetButtonUp(ActionName);}

            if (isUp)
            { True(); }
            else
            { False(); }
        }
    }
}