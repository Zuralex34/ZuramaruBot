using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules.LoveLiveSearches
{
    public class LoveLiveSearchesInfo : ModuleBase
    {
        [Command("lovelive")]
        public async Task LL()
        {
            var embed = new EmbedBuilder();
            {
                embed.WithTitle("Love Live!")
                    .WithDescription("lovelive (Prénom du personnage/doubleuse)\n\nPhoto de personnages/doubleuse de Love Live\n(µ's et Aqours)")
                    .WithColor(Color.Gold);                    
                await ReplyAsync("", false, embed.Build());
            }
        }
    }
}
