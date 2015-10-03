#region

using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;

#endregion

namespace ECSModules.Rewired.Controllers
{
    [uFrameCategory("Rewired", "Controllers")]
    [ActionTitle("Get Controller")]
    [ActionDescription("Gets the player matching the id")]
    public class GetController : UFAction
    {
        [In]
        public ControllerType ControllerType;

        [In]
        public int ControllerId;

        [Out]
        public Controller Controller;
        
        public override void Execute()
        {
            Controller = ReInput.controllers.GetController(ControllerType, ControllerId);
        }
    }
}