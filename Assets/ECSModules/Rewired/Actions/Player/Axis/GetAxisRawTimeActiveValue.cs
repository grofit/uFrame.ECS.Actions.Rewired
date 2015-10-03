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
    [ActionTitle("Get Axis Raw Time Active")]
    [ActionDescription("Gets the axis active time from the player without enhancements")]
    public class GetAxisRawTimeActiveValue : UFAction
    {
        [In]
        public string AxisName;

        [In]
        public int AxisId = -1;
           
        [In]
        public RWPlayer Player;

        [Out]
        public float RawActiveTime;
        
        public override void Execute()
        {
            if (string.IsNullOrEmpty(AxisName))
            { RawActiveTime = Player.GetAxisRawTimeActive(AxisId); }
            else
            { RawActiveTime = Player.GetAxisRawTimeActive(AxisName); }
        }
    }
}