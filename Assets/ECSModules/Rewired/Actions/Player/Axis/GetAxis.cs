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
    [ActionTitle("Get Axis")]
    [ActionDescription("Gets the axis from the player")]
    public class GetAxis : UFAction
    {
        [In]
        public string AxisName;

        [In]
        public int AxisId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public float AxisChange;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(AxisName))
            { AxisChange = Player.GetAxis(AxisId); }
            else
            { AxisChange = Player.GetAxis(AxisName); }
        }
    }
}