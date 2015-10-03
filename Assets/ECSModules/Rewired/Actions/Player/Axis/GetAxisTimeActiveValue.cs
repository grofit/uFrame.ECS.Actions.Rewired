#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Axis
{
    [uFrameCategory("Rewired", "Player", "Axis")]
    [ActionTitle("Get Axis Time Active")]
    [ActionDescription("Gets the axis active time from the player without enhancements")]
    public class GetAxisTimeActiveValue : UFAction
    {
        [In]
        public string AxisName;

        [In]
        public int AxisId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public float ActiveTime;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(AxisName))
            { ActiveTime = Player.GetAxisTimeActive(AxisId); }
            else
            { ActiveTime = Player.GetAxisTimeActive(AxisName); }
        }
    }
}