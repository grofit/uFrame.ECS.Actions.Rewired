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
    [ActionTitle("Get Axis Last Time Inactive")]
    [ActionDescription("Gets the last time the axis was inactive")]
    public class GetLastTimeInactive : UFAction
    {
        [In]
        public int AxisIndex;

        [In]
        public int AxisId = -1;

        [Out]
        public float AxisLastInactive;

        public override void Execute()
        {
            if (AxisIndex >= 0)
            { AxisLastInactive = ReInput.controllers.Mouse.GetAxisLastTimeInactiveById(AxisIndex); }
            else
            { AxisLastInactive = ReInput.controllers.Mouse.GetAxisLastTimeInactive(AxisId); }
        }
    }
}