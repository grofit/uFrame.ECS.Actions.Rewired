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
    [ActionTitle("Get Axis Raw Time Inactive")]
    [ActionDescription("Gets the axis inactive time from the player without enhancements")]
    
    public class GetAxisRawTimeInactiveValue : UFAction
    {
        [In]
        public string AxisName;

        [In]
        public int AxisId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public float RawInactiveTime;
        
        public override void Execute()
        {
            if (string.IsNullOrEmpty(AxisName))
            { RawInactiveTime = Player.GetAxisRawTimeActive(AxisId); }
            else
            { RawInactiveTime = Player.GetAxisRawTimeActive(AxisName); }
        }
    }
}