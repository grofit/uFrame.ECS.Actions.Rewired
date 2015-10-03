#region

using System.ComponentModel;
using System.Text;


using Rewired;
using uFrame.Actions;
using uFrame.Attributes;
using RWPlayer = Rewired.Player;
#endregion

namespace ECSModules.Rewired.Player
{
    [uFrameCategory("Rewired", "Player")]
    [ActionTitle("Get Player")]
    [ActionDescription("Gets the player matching the id")]
    public class GetPlayer : UFAction
    {
        [In]
        public string PlayerName;

        [In]
        public int PlayerId = -1;

        [Out]
        public RWPlayer Player;
      
        public override void Execute()
        {
            if(string.IsNullOrEmpty(PlayerName))
            { Player = ReInput.players.GetPlayer(PlayerId); }
            else
            { Player = ReInput.players.GetPlayer(PlayerName); }
        }
    }
}