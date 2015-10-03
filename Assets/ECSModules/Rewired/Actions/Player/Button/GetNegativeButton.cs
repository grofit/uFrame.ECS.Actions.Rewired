#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Buttons
{
    [uFrameCategory("Rewired", "Player", "Buttons")]
    [ActionTitle("Get Negative Button")]
    [ActionDescription("Gets the negative button state from the player")]
    public class GetNegativeButton : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public bool ButtonState;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(ActionName))
            { ButtonState = Player.GetNegativeButton(ActionId); }
            else
            { ButtonState = Player.GetNegativeButton(ActionName); }
        }
    }
}