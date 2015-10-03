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
    [ActionTitle("Is Negative Button Double Pressed Hold")]
    [ActionDescription("Checks if the button has been pressed down twice and is held")]
    public class IsNegativeButtonDoublePressedHold : UFAction
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
            { isPressed = Player.GetNegativeButtonDoublePressHold(ActionId); }
            else
            { isPressed = Player.GetNegativeButtonDoublePressHold(ActionName); }

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}