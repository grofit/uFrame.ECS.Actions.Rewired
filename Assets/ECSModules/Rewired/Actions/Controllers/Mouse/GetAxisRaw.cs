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
    [ActionTitle("Get Axis")]
    [ActionDescription("Gets the raw axis from the mouse without enhancements")]
    
    public class GetAxisRaw : UFAction
    {
        [In]
        public int AxisIndex = -1;

        [In]
        public int AxisId =-1;

        [Out]
        public float AxisChange;

        public override void Execute()
        {
            if (AxisIndex >= 0)
            { AxisChange = ReInput.controllers.Mouse.GetAxisRawById(AxisIndex); }
            else
            { AxisChange = ReInput.controllers.Mouse.GetAxisRaw(AxisId); }
        }
    }
}