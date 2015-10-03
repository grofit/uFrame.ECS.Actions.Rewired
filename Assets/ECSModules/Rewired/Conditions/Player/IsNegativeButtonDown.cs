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
    [ActionTitle("Is Negative Button Down")]
    [ActionDescription("Checks if the negative button is down")]
    public class IsNegativeButtonDown : UFAction
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
            bool isPressed;

            if (string.IsNullOrEmpty(ActionName))
            { isPressed = Player.GetNegativeButtonDown(ActionId); }
            else
            { isPressed = Player.GetNegativeButtonDown(ActionName); }

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}