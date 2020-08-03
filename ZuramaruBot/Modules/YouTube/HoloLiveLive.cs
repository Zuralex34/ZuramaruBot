using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace ZuramaruBot.Modules.YouTube
{
    public class HoloLiveLive : ModuleBase
    {
        [Command("hl")]
        public async Task Live()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Utilisation des commandes HoloLive")
                .WithDescription("- °hl live : Liste des lives en cours.\n- °hl (prénom de la vtuber) : Affiche le live en cours si elle est en live.\n  (exemple : °hl pekora)")
                .WithColor(Color.Gold);
            await ReplyAsync("", false, embed.Build());
        }

            /*List<string> Hololive = new List<string>()
            {
                "sora=UCp6993wxpyDPHUpavwDFqgg=🐻 Tokino Sora",
                "roboco=UCDqI2jOz0weumE8s7paEk6g=🤖 Roboco",
                "miko=UC-hM6YJuNYVAmUWxeIr9FeA=🌸 Sakura Miko",
                "suisei=UC5CwaMl1eIgY8h02uZw7u8A=☄️ Hoshimachi Suisei",
                "haato=UC1CfXB_kRs3C-zaeTG3oGyg=❣️ Akai Haato",
                "mel=UCD8HOxPs4Xvsm8H0ZxXGiBw=🌟 Yozora Mel",
                "matsuri=UCQ0UDLQCjY0rmuxCDE38FGg=🏮 Natsuiro Matsuri",
                "rosenthal=UCFTLzh12_nrtzqBPsTCqenA=🍎 Aki Rosenthal",
                "fubuki=UCdn5BQ06XqgXoAxIhbqw5Rg=🌽 Shirakami Fubuki",
                "subaru=UCvzGlP9oQwU--Y0r9id_jnA=🚑 Oozora Subaru",
                "choco=UC1suqwovbL1kzsoaZgFZLKg=💋 Yuzuki Choco",
                "shion=UCXTpFs_3PqI41qX2d9tL2Rw=🌙 = Murasaki Shion",
                "ayame=UC7fk0CB07ly8oSl0aqKkqFg=👿 Nakiri Ayame",
                "aqua=UC1opHUrw8rvnsadT-iGp7Cg=⚓️ Minato Aqua",
                "mio=UCp-5t9SrOQwXMU7iIjQfARg=🌲 Ookami Mio",
                "okayu=UCvaTdHTWBGv3MKj3KVqJVCw=🍙 Nekomata Okayu",
                "korone=UChAnqc_AY5_I3Px5dig3X1Q=🥐 Inugami Korone",
                "pekora=UC1DCedRgGHBdm81E1llLhOQ=👯 Usada Pekora",
                "rushia=UCl_gCybOJRIgOXw6Qb4qJzQ=🦋 Uruha Rushia",
                "flare=UCvInZx9h3jC2JzsIzoOebWg=🔥 Shiranui Flare",
                "noel=UCdyqAaZDKHXg4Ahi7VENThQ=⚔️ Shirogane Noel",
                "marine=UCCzUftO8KOVkV4wQG1vkUvg=🏴‍☠️ Houshou Marine",
                "watame=UCqm3BQLlJfvkTsX_hvm0UmA=🐏 Tsunomaki Watame",
                "towa=UC1uv2Oq6kNxgATlCiez59hw=👾 Tokoyami Towa",
                "coco=UCS9uQI-jC3DE0L4IpXyvr6w=🐉 Kiryu Coco",
                "kanata=UCZlDXzGoo7d44bwdNObFacg=💫 Amane Kanata",
                "luna=UCa9Y57gfeY0Zro_noHRVrnw=🍬 Himemori Luna"
            };

            string live = null;
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                // ApiKey = "AIzaSyB5W8QyWCFmjUfIdeP-KFpz54nqzxl0rNg",
                ApiKey = "AIzaSyDIUJQYusBMFROezHQVsfnzpU5g3_KIVIo",
                ApplicationName = this.GetType().ToString()
            });

            foreach (var channel in Hololive)
            {
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.ChannelId = channel.Split("=")[1];
                searchListRequest.Type = "video";
                searchListRequest.EventType = SearchResource.ListRequest.EventTypeEnum.Live;
                var searchListResponse = await searchListRequest.ExecuteAsync();
                if (searchListResponse.Items.Count == 1)
                {
                    live = live + channel.Split("=")[2] + "\n";
                }
            }
            if (live == null)
            {
                var embed = new EmbedBuilder();

                embed.WithTitle("Live :")
                    .WithDescription("Pas de live en cours")
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                var embed = new EmbedBuilder();

                embed.WithTitle("Live :")
                    .WithDescription(live)
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }*/
    }
}
