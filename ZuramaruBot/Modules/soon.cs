using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules
{
    public class soon : ModuleBase
    {
        [Command("soon")]
        public async Task Info()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Coming Soon")
                .WithDescription("Nouveau jeu Kingdelivrance")
                .WithColor(Color.Gold);

            await ReplyAsync("", false, embed.Build());
        }
    }
}
