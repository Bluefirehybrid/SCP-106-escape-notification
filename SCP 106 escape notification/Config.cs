using Exiled.API.Interfaces;

namespace SCP_106_escape_notification
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
    }
}
