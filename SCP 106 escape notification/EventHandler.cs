
using System.Linq;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using PlayerRoles;

namespace SCP_106_escape_notification
{
    public static class EventHandler
    {
        public static void Escaped(EscapingPocketDimensionEventArgs ev)
        {
            Find106()?.ShowHint(Plugin.Instance.Translation.EscapeHint.Replace("[PLAYERNAME]", ev.Player.Nickname));
        }
        public static void Failed(FailingEscapePocketDimensionEventArgs ev)
        {
            Find106()?.ShowHint(Plugin.Instance.Translation.FailedHint.Replace("[PLAYERNAME]",ev.Player.Nickname));
        }
        
        private static Player Find106()
        {
            return Player.List.FirstOrDefault(player => player.Role.Type == RoleTypeId.Scp106);
        }
    }
}
