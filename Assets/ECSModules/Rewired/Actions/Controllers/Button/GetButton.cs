using System.Text;
using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.Rewired.Controllers.Buttons
{
    [uFrameCategory("Rewired", "Controllers", "Buttons")]
    [ActionTitle("Get Button")]
    [ActionDescription("Gets the button state from the Controller")]
    public class GetButton : UFAction
    {
        [In]
        public int ButtonId;

        [In]
        public Controller Controller;

        [Out]
        public bool ButtonState;


        public override void Execute()
        {
            ButtonState = Controller.GetButton(ButtonId);
        }
    }
}