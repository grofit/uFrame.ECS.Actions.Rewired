#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Axis
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Set Player Map")]
    [ActionDescription("Sets the player mapping")]
    public class SetPlayerMap : UFAction
    {
        [In]
        public bool State;
        
        [In]
        public string CategoryName;
        
        [In]
        public string LayoutName;

        [In]
        public RWPlayer Player;

        public override void Execute()
        {
            if (string.IsNullOrEmpty(LayoutName))
            { Player.controllers.maps.SetMapsEnabled(State, CategoryName); }
            else
            { Player.controllers.maps.SetMapsEnabled(State, CategoryName, LayoutName); }
        }
    }
}