using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules
{
    public class Ping : ModuleBase
    {
        [Command("mirai")]
        public async Task PingAsync()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Mirai Zura !")
                .WithDescription("C'est vraiment futuriste zura !")
                .WithUrl($"https://www.youtube.com/watch?v=kWIqP0dURvQ")
                .WithColor(Color.Gold);

            await ReplyAsync("", false, embed.Build());
        }
    }
}
