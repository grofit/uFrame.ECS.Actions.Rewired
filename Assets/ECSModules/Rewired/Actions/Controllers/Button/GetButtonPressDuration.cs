using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;

namespace ECSModules.Rewired.Controllers.Buttons
{
    [uFrameCategory("Rewired", "Controllers", "Buttons")]
    [ActionTitle("Get Button Press Duration")]
    [ActionDescription("Gets the button pressed duration from the Controller")]
    public class GetButtonPressDuration : UFAction
    {
        [In]
        public int ButtonId;
        
        [In]
        public RWPlayer Player;
        
        [Out]
        public float Duration;
        
        public override void Execute()
        {
            Duration = Player.GetButtonTimePressed(ButtonId);
        }
    }
}