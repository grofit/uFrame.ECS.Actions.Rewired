#region

using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Buttons
{
    [uFrameCategory("Rewired", "Controllers", "Buttons")]
    [ActionTitle("Get Button Unpressed Duration")]
    [ActionDescription("Gets the button unpressed duration from the controller")]
    public class GetButtonUnpressedDuration : UFAction
    {
        [In]
        public int ButtonId;
        
        [In]
        public Controller Controller;
        
        [Out]
        public float Duration;
        
        public override void Execute()
        {
            Duration = Controller.GetButtonTimeUnpressed(ButtonId);
        }
    }
}