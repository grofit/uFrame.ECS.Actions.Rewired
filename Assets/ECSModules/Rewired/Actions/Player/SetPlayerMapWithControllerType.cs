#region

using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Axis
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Set Player Map With Controller Type")]
    [ActionDescription("Sets the player mapping")]
    public class SetPlayerMapWithControllerType : UFAction
    {
        [In]
        public bool State;

        [In]
        public ControllerType ControllerType;

        [In]
        public string CategoryName;

        [In]
        public int CategoryId = -1;

        [In]
        public string LayoutName;

        [In]
        public int LayoutId = -1;

        [In]
        public RWPlayer Player;
        
        public override void Execute()
        {
            if (CategoryId >= 0)
            {
                if (LayoutId >= 0)
                { Player.controllers.maps.SetMapsEnabled(State, ControllerType, CategoryId); }
                else
                { Player.controllers.maps.SetMapsEnabled(State, ControllerType, CategoryId, LayoutId); }
            }
            else
            {
                if (string.IsNullOrEmpty(LayoutName))
                { Player.controllers.maps.SetMapsEnabled(State, ControllerType, CategoryName); }
                else
                { Player.controllers.maps.SetMapsEnabled(State, ControllerType, CategoryName, LayoutName); }
            }
        }
    }
}