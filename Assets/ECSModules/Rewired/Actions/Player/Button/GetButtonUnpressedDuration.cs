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
    [ActionTitle("Get Button Unpressed Duration")]
    [ActionDescription("Gets the button unpressed duration from the player")]
    public class GetButtonUnpressedDuration : UFAction
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
            { Duration = Player.GetButtonTimeUnpressed(ActionId); }
            else
            { Duration = Player.GetButtonTimeUnpressed(ActionName); }
        }
    }
}