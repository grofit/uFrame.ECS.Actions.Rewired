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
    [ActionTitle("Get Axis Previous")]
    [ActionDescription("Gets the axis previous frame value from the mouse")]
    
    public class GetAxisPrevious : UFAction
    {
        [In]
        public int AxisIndex = -1;

        [In]
        public int AxisId = -1;
            
        [Out]
        public float AxisChange;

        public override void Execute()
        {
            if (AxisIndex >= 0)
            { AxisChange = ReInput.controllers.Mouse.GetAxisPrevById(AxisIndex); }
            else
            { AxisChange = ReInput.controllers.Mouse.GetAxisPrev(AxisId); }
        }
    }
}