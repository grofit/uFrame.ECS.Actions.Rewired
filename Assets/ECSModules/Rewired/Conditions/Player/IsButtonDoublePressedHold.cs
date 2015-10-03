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
    [ActionTitle("Is Button Double Pressed Hold")]
    [ActionDescription("Checks if the button has been pressed down twice and is held")]
    public class IsButtonDoublePressedHold : UFAction
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
            { isPressed = Player.GetButtonDoublePressHold(ActionId); }
            else
            { isPressed = Player.GetButtonDoublePressHold(ActionName); }

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}