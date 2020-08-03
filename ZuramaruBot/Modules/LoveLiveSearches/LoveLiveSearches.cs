using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules.LoveLiveSearches
{
    public class LoveLiveSearches : ModuleBase
    {
        [Command("lovelive")]
        public async Task Zura(string character)
        {
            var embed = new EmbedBuilder();

            switch (character)
            {
                case "hanamaru":
                case "kunikida":
                case "hanamaru kunikida":
                    embed.WithTitle("Hanamaru Kunikida")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/c/c1/Sunshine!!_infobox_-_Kunikida_Hanamaru.png/revision/latest?cb=20170402074009")
                        .WithColor(Color.Gold);
                    break;
                
                case "yoshiko":
                    embed.WithTitle("Yoshiko Tsushima")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/3/39/Sunshine%21%21_infobox_-_Tsushima_Yoshiko.png/revision/latest?cb=20170402074008")
                        .WithColor(Color.DarkGrey);
                    break;

                case "yohane":
                    embed.WithTitle("Yohane Tsushima")
                        .WithImageUrl("https://i.ytimg.com/vi/Nkt7WUtoTT4/maxresdefault.jpg")
                        .WithColor(Color.DarkGrey);
                    break;

                case "chika":
                    embed.WithTitle("Chika Takami")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/9/94/Sunshine%21%21_infobox_-_Takami_Chika.png/revision/latest?cb=20170402074002")
                        .WithColor(Color.Orange);
                    break;

                case "you":
                    embed.WithTitle("You Watanabe")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/0/0e/Sunshine%21%21_infobox_-_Watanabe_You.png/revision/latest?cb=20170402074007")
                        .WithColor(Color.Blue);
                    break;

                case "riko":
                    embed.WithTitle("Riko Sakurauchi")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/7/77/Sunshine%21%21_infobox_-_Sakurauchi_Riko.png/revision/latest?cb=20170402074004")
                        .WithColor(Color.Magenta);
                    break;

                case "ruby":
                    embed.WithTitle("Ruby Kurosawa")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/2/21/Sunshine%21%21_infobox_-_Kurosawa_Ruby.png/revision/latest?cb=20170402073946")
                        .WithColor(Color.DarkMagenta);
                    break;

                case "kanan":
                    embed.WithTitle("Kanan Matsuura")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/5/56/Sunshine%21%21_infobox_-_Matsuura_Kanan.png/revision/latest?cb=20170402074005")
                        .WithColor(Color.Green);
                    break;

                case "dia":
                    embed.WithTitle("Dia Kurosawa")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/6/6c/Sunshine%21%21_infobox_-_Kurosawa_Dia.png/revision/latest?cb=20170402074006")
                        .WithColor(Color.Red);
                    break;

                case "mari":
                    embed.WithTitle("Mari Ohara")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/1/14/Sunshine%21%21_infobox_-_Ohara_Mari.png/revision/latest?cb=20170402073947")
                        .WithColor(Color.Purple);
                    break;

                case "kanako":
                case "takatsuki":
                case "takatsuki kanako":
                case "kanako takatsuki":
                case "king":
                case "kinchan":
                    embed.WithTitle("Takatsuki Kanako (King)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/8/8f/Aqours_Club_Profile_Card_-_Takatsuki_Kanako.png/revision/latest/scale-to-width-down/250?cb=20170630121153")
                        .WithColor(Color.Gold);
                    break;

                case "aika":
                    embed.WithTitle("Kobayashi Aika (Aikyan)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/5/5e/Aqours_Club_Profile_Card_-_Kobayashi_Aika.png/revision/latest/scale-to-width-down/250?cb=20170630121151")
                        .WithColor(Color.DarkGrey);
                    break;

                case "ai":
                    embed.WithTitle("Furihata Ai (Furirin)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/a/a8/Aqours_Club_Profile_Card_-_Furihata_Ai.png/revision/latest/scale-to-width-down/250?cb=20170630121150")
                        .WithColor(Color.DarkMagenta);
                    break;

                case "anju":
                    embed.WithTitle("Inami Anju (Anchan)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/7/7e/Aqours_Club_Profile_Card_-_Inami_Anju.png/revision/latest/scale-to-width-down/250?cb=20170630121150")
                        .WithColor(Color.Orange);
                    break;

                case "rikako":
                    embed.WithTitle("Aida Rikako (Rikyako)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/2/2f/Aqours_Club_Profile_Card_-_Aida_Rikako.png/revision/latest/scale-to-width-down/250?cb=20170630121149")
                        .WithColor(Color.Magenta);
                    break;

                case "shuka":
                    embed.WithTitle("Saito Shuka (Shukashuu)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/8/8b/Aqours_Club_Profile_Card_-_Saitou_Shuka.png/revision/latest/scale-to-width-down/250?cb=20170630121152")
                        .WithColor(Color.Blue);
                    break;

                case "arisa":
                    embed.WithTitle("Komiya Arisa (Arisha)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/7/72/Aqours_Club_Profile_Card_-_Komiya_Arisa.png/revision/latest/scale-to-width-down/250?cb=20170630121151")
                        .WithColor(Color.Red);
                    break;

                case "nanaka":
                    embed.WithTitle("Suwa Nanaka (Suwawa)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/1/1b/Aqours_Club_Profile_Card_-_Suwa_Nanaka.png/revision/latest/scale-to-width-down/250?cb=20170630121152")
                        .WithColor(Color.Green);
                    break;

                case "aina":
                    embed.WithTitle("Suzuki Aina (Ainya)")
                        .WithImageUrl("https://vignette.wikia.nocookie.net/love-live/images/a/a0/Aqours_Club_Profile_Card_-_Suzuki_Aina.png/revision/latest/scale-to-width-down/250?cb=20170630121153")
                        .WithColor(Color.Purple);
                    break;
            }
            await ReplyAsync("", false, embed.Build());

        }
    }
}
