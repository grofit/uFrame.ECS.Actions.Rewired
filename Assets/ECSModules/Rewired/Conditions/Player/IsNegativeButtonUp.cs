#region

using System;
using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;

#endregion

namespace ECSModules.Rewired.Player
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Is Negative Button Up")]
    [ActionDescription("Checks if the button is down")]
    public class IsNegativeButtonUp : UFAction
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
            { isPressed = Player.GetNegativeButtonUp(ActionId); }
            else
            { isPressed = Player.GetNegativeButtonUp(ActionName); }

            if(isPressed)
            { True(); }
            else
            { False(); }
        }
    }
}