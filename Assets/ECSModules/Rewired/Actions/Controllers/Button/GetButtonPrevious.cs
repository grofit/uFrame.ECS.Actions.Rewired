using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.Rewired.Controllers.Buttons
{
    [uFrameCategory("Rewired", "Controllers", "Buttons")]
    [ActionTitle("Get Button Previous")]
    [ActionDescription("Gets the button state from the controllers previous frame")]
    public class GetButtonPrevious : UFAction
    {
        [In]
        public int ButtonId;

        [In]        
        public Controller Controller;

        [Out]
        public bool PreviousButtonState;

        public override void Execute()
        {
            PreviousButtonState = Controller.GetButtonPrev(ButtonId);
        }
    }
}