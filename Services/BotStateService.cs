using EchoBot1.Models;
using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchoBot1.Services
{
    public class BotStateService
    {
        #region Variables
        // State Variable
        public UserState UserState { get; }

        // IDs
        public static string UserProfileId { get; } = $"{nameof(BotStateService)}.UserProfile";

        // Accessors
        public IStatePropertyAccessor<UserProfile> UserProfileAccessor { get; set; }
        #endregion
    }
}
