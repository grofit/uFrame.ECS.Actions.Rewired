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
    [ActionTitle("Get Button Press Duration")]
    [ActionDescription("Gets the button pressed duration from the player")]
    public class GetButtonPressDuration : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public float Duration;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(ActionName))
            { Duration = Player.GetButtonTimePressed(ActionId); }
            else
            { Duration = Player.GetButtonTimePressed(ActionName); }
        }
    }
}