#region

using System.ComponentModel;
using System.Text;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player.Buttons
{
    [uFrameCategory("Rewired", "Player", "Buttons")]
    [ActionTitle("Get Button")]
    [ActionDescription("Gets the button state from the player")]
    
    public class GetButton : UFAction
    {
        [In]
        public string ActionName;

        [In]
        public int ActionId = -1;

        [In]
        public RWPlayer Player;
        
        [Out]
        public bool ButtonState;
        
        public override void Execute()
        {
            if (string.IsNullOrEmpty(ActionName))
            { ButtonState = Player.GetButton(ActionId); }
            else
            { ButtonState = Player.GetButton(ActionName); }
        }
    }
}