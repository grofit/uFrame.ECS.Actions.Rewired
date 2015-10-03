#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Controllers.Mouse
{
    [uFrameCategory("Rewired", "Controllers", "Mouse")]
    [ActionTitle("Get Button Unpressed Duration")]
    [ActionDescription("Gets the button unpressed duration")]
    public class GetButtonUnpressedDuration : UFAction
    {
        [In]
        public int MouseButton;

        [In]
        public RWPlayer Player;

        [Out]
        public float Duration;
        
        public override void Execute()
        {
            Duration = Player.GetButtonTimeUnpressed(MouseButton);
        }
    }
}