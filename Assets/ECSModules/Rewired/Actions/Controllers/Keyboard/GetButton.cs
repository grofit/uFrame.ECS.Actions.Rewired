#region

using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Keyboard
{
    [uFrameCategory("Rewired", "Controllers", "Keyboard")]
    [ActionTitle("Get Button")]
    [ActionDescription("Gets the button state")]
    public class GetButton : UFAction
    {
        [In]
        public int ButtonId;

        [Out]
        public bool ButtonState;
        
        public override void Execute()
        {
            ButtonState = ReInput.controllers.Keyboard.GetButton(ButtonId);
        }
    }
}