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
    [ActionTitle("Get Axis Previous Value")]
    [ActionDescription("Gets the axis from the player from the previous frame")]
    public class GetAxisPreviousValue : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;

        [In]
        public RWPlayer Player;

        [Out]
        public float AxisChange;
        
        public override void Execute()
        {
            if(string.IsNullOrEmpty(ActionName))
            { AxisChange = Player.GetAxisPrev(ActionId); }
            else
            { AxisChange = Player.GetAxisPrev(ActionName); }
        }
    }
}