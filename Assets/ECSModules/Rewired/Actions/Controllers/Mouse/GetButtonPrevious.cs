#region

using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers.Mouse
{
    [uFrameCategory("Rewired", "Controllers", "Mouse")]
    [ActionTitle("Get Mouse Button Previous")]
    [ActionDescription("Gets the button previous frames button state")]
    
    public class GetButtonPrevious : UFAction
    {
        [In]
        public int MouseButton;

        [Out]
        public bool ButtonState;
        
        public override void Execute()
        {
            ButtonState = ReInput.controllers.Mouse.GetButtonPrev(MouseButton);
        }
    }
}