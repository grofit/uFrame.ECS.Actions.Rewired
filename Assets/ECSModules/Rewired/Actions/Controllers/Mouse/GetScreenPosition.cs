#region

using System.ComponentModel;
using Rewired;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

#endregion

namespace ECSModules.Rewired.Controllers.Mouse
{
    [uFrameCategory("Rewired", "Controllers", "Mouse")]
    [ActionTitle("Get Screen Position")]
    [ActionDescription("Gets the mouses screen position")]
    public class GetScreenPosition : UFAction
    {
        [In]
        [Out]
        public Vector2 ScreenPosition;
        
        public override void Execute()
        {
            ScreenPosition = ReInput.controllers.Mouse.screenPosition;
        }
    }
}