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
    [ActionTitle("Is Negative Button Double Pressed Down")]
    [ActionDescription("Checks if the negative button has been pressed down twice")]
    public class IsNegativeButtonDoublePressedDown : UFAction
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
            { isPressed = Player.GetNegativeButtonDoublePressDown(ActionId); }
            else
            { isPressed = Player.GetNegativeButtonDoublePressDown(ActionName); }

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}