using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules.Roll_Dice
{
    public class roll_dice_info : ModuleBase
    {
        [Command("dice")]
        public async Task PingAsync()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Commande :")
                .WithDescription("°dice (nombre)")
                .WithColor(Color.Gold);

            await ReplyAsync("", false, embed.Build());
        }
    }
}
