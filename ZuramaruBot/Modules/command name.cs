using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules
{
    public class command_name : ModuleBase
    {
        [Command("help")]
        public async Task info()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Noms des commandes\n(°nom)")
                .WithDescription("Mirai\nDice\nSoon\nLoveLive\n...")
                .WithColor(Color.Gold);

            await ReplyAsync("", false, embed.Build());
        }
    }
}
