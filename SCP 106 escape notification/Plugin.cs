using Exiled.API.Features;
using System;

namespace SCP_106_escape_notification
{
    public class Plugin : Plugin<Config,Translations>
    {
        public override string Name => "106 Escape notifier";
        public override string Author => "Hybrid";
        public override Version Version => new Version(1,0,0);
        public static Plugin Instance { get; private set; }
        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.EscapingPocketDimension += EventHandler.Escaped;
            Exiled.Events.Handlers.Player.FailingEscapePocketDimension += EventHandler.Failed;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.EscapingPocketDimension -= EventHandler.Escaped;
            Exiled.Events.Handlers.Player.FailingEscapePocketDimension -= EventHandler.Failed;
            Instance = null;
            base.OnDisabled();
        }

    }
}
