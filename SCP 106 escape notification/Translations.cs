using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SCP_106_escape_notification
{
    public class Translations : ITranslation
    {
        [Description("What you want the escape hint to say!")]
        public readonly string EscapeHint = "[PLAYERNAME] has Escaped Your dimension!";

        [Description("What you want the failed escape message to say!")]
        public readonly string FailedHint = "[PLAYERNAME] Died in your dimension!";
    }
}
