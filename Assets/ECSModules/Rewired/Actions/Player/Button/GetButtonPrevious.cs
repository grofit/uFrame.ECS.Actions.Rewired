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
    [ActionTitle("Get Button Previous")]
    [ActionDescription("Gets the button state from the players previous frame")]
    public class GetButtonPrevious : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;
        
        [In]
        public RWPlayer Player;

        [Out]
        public bool PreviousButtonState;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(ActionName))
            { PreviousButtonState = Player.GetButtonPrev(ActionId); }
            else
            { PreviousButtonState = Player.GetButtonPrev(ActionName); }
        }
    }
}