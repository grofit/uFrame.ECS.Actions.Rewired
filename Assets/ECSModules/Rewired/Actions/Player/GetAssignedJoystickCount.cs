#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Axis
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Get Assigned Joystick Count")]
    [ActionDescription("Gets the amount of joysticks assigned to this player")]
    public class GetAssignedJoystickCount : UFAction
    {
        [In]
        public RWPlayer Player;

        [Out]
        public int JoysticksAssigned;

        public override void Execute()
        {
            JoysticksAssigned = Player.controllers.joystickCount;
        }
    }
}