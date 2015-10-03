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
    [ActionTitle("Get Axis Last Time Active")]
    [ActionDescription("Gets the last time the axis was active")]
    public class GetLastTimeActive : UFAction
    {
        [In]
        public int AxisIndex = -1;

        [In]
        public int AxisId = -1;

        [Out]
        public float AxisLastActive;

        public override void Execute()
        {
            if (AxisIndex >= 0)
            { AxisLastActive = ReInput.controllers.Mouse.GetAxisLastTimeActiveById(AxisIndex); }
            else
            { AxisLastActive = ReInput.controllers.Mouse.GetAxisLastTimeActive(AxisId); }
        }
    }
}