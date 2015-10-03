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
    [ActionTitle("Is Button Double Pressed Down")]
    [ActionDescription("Checks if the button has been pressed down twice")]
    public class IsButtonDoublePressedDown : UFAction
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
            { isPressed = Player.GetButtonDoublePressDown(ActionId); }
            else
            { isPressed = Player.GetButtonDoublePressDown(ActionName);}

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}