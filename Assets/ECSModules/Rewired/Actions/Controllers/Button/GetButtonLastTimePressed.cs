using System.Text;
using Rewired;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;

namespace ECSModules.Rewired.Controllers.Buttons
{
    [uFrameCategory("Rewired", "Controllers", "Buttons")]
    [ActionTitle("Get Button Last Time Pressed")]
    [ActionDescription("Gets the last time the button was pressed")]
    public class GetButtonLastTimePressed : UFAction
    {
        [In]
        public int ButtonId;

        [In]       
        public Controller Controller;

        [Out]
        public float LastPressTime;

        public override void Execute()
        {
            LastPressTime = Controller.GetButtonLastTimePressed(ButtonId);
        }
    }
}