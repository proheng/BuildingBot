﻿using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EchoBot1.Bots
{
    public class GreetingBot : ActivityHandler
    {
        protected override Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            return base.OnMessageActivityAsync(turnContext, cancellationToken);
        }

        protected override Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach(var member in membersAdded)
            {
                if(member.Id != turnContext.Activity.Recipient.Id)
                {

                }
            }
            return base.OnMembersAddedAsync(membersAdded, turnContext, cancellationToken);
        }
    }
}
