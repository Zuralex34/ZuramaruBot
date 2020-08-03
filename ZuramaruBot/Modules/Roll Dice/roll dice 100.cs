using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules
{
    public class roll_dice_100 : ModuleBase
    {
        [Command("dice 100")]
        public async Task Dice100()
        {
            Random rng = new Random();
            int numberRng = rng.Next(1, 101);

            var embed = new EmbedBuilder();        
                        
            if (numberRng > 94)
            {
                embed.WithTitle("Lancer dé de 100")
                     .WithDescription(numberRng.ToString() + "\nEchec critique")
                     .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());

            }
            if (numberRng < 6)
            {
                embed.WithTitle("Lancer dé de 100")
                    .WithDescription(numberRng.ToString() + "\nRéussite critique")
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 100")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
        }

        [Command("dice 2")]
        public async Task Dice2()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 3);

            var embed = new EmbedBuilder();
           
            if (numberRng == 1)
            {
                embed.WithTitle("Lancer pièce")
                    .WithDescription(numberRng.ToString() + "\nPile")
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());

            }
            if (numberRng == 2)
            {
                embed.WithTitle("Lancer pièce")
                    .WithDescription(numberRng.ToString() + "\nFace")
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
        }
        [Command("dice 4")]
        public async Task Dice4()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 5);

            var embed = new EmbedBuilder();

            if (numberRng == 4)
            {
                embed.WithTitle("Lancer dé de 4")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng == 1)
            {
                embed.WithTitle("Lancer dé de 4")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng > 1 && numberRng <4)
            {
                embed.WithTitle("Lancer dé de 4")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
        }
        [Command("dice 6")]
        public async Task Dice6()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 7);

            var embed = new EmbedBuilder();

            if (numberRng > 4)
            {
                embed.WithTitle("Lancer dé de 6")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng < 3)
            {
                embed.WithTitle("Lancer dé de 6")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 6")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }

        }
        [Command("dice 8")]
        public async Task Dice8()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 9);

            var embed = new EmbedBuilder();

            if (numberRng > 6)
            {
                embed.WithTitle("Lancer dé de 8")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng < 3)
            {
                embed.WithTitle("Lancer dé de 8")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 8")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }

        }
        [Command("dice 10")]
        public async Task Dice10()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 11);

            var embed = new EmbedBuilder();

            if (numberRng > 6)
            {
                embed.WithTitle("Lancer dé de 10")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng < 4)
            {
                embed.WithTitle("Lancer dé de 10")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 10")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
        }
        [Command("dice 12")]
        public async Task Dice12()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 13);

            var embed = new EmbedBuilder();

            if (numberRng > 9)
            {
                embed.WithTitle("Lancer dé de 12")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng < 5)
            {
                embed.WithTitle("Lancer dé de 12")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 12")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
        }
        [Command("dice 20")]
        public async Task Dice20()
        {
            Random rng = new Random(); ;
            int numberRng = rng.Next(1, 21);

            var embed = new EmbedBuilder();

            if (numberRng > 15)
            {
                embed.WithTitle("Lancer dé de 20")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Green);
                await ReplyAsync("", false, embed.Build());
            }
            if (numberRng < 6)
            {
                embed.WithTitle("Lancer dé de 20")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Red);
                await ReplyAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Lancer dé de 20")
                    .WithDescription(numberRng.ToString())
                    .WithColor(Color.Gold);
                await ReplyAsync("", false, embed.Build());
            }
            
        }

    }

}
