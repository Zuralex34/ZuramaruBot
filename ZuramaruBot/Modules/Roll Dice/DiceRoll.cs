using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace ZuramaruBot.Modules.Roll_Dice
{
    public class DiceRoll : ModuleBase<SocketCommandContext>
    {
        /// <summary>
        /// C'est une fonction qui va s'occuper de lancer le dé, peu importe le type de dé (2, 4, 6, 12, etc...)
        /// Ca t'évite de devoir refaire le même code 15x juste en changeant 2 chiffres.
        /// Ici c'est une Task async, parce que c'est ce que Discord veut.
        /// </summary>
        /// <param name="MinValue">La valeur minimale du Random. Techniquement tout le temps un, mais si jamais on veut un dé de 4 à 12, on peut.</param>
        /// <param name="MaxValue">La valeur maximale du Random. Donc en fait, ton type de dé. Si le dé c'est un dé de 4, le max sera 4</param>
        /// <returns>Un nombre aléatoire qui sera le résultat du lancé de dé.</returns>
        public async Task InternalDiceRoll(int MinValue, int MaxValue)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(MinValue, MaxValue + 1); //Au lieu de définir directement l'intervalle du Random, on utilise des variables afin d'avoir un intervalle custom.

            var embed = new EmbedBuilder()
            {
                Title = "Lancé de dé " + MaxValue.ToString(),
            };

            if (MaxValue == 1)
                await Context.Channel.SendMessageAsync("Le type de dé doit être au moins 2, sinon il est impossible de jouer !").ConfigureAwait(false);

            /// Si le type de dé est un 4, c'est cette partie du code qui s'en occupe
            if(MaxValue == 4)
            {
                switch (randomNumber)
                {
                    case 4:
                        embed.AddField(efb => efb.WithName($"{randomNumber.ToString()}").WithValue("Echec critique !").WithIsInline(false))
                            .WithColor(Color.Red);
                        break;
                    case 1:
                        embed.AddField(efb => efb.WithName($"{randomNumber.ToString()}").WithValue("Réussite critique !").WithIsInline(false))
                            .WithColor(Color.Green);
                        break;
                    default:
                        embed.AddField(efb => efb.WithName($"{randomNumber.ToString()}").WithValue("").WithIsInline(false))
                            .WithColor(Color.Gold);
                        break;
                }
            }
            
            /// Si le type de dé est un 2, c'est cette partie du code qui s'en occupe
            else if(MaxValue == 2)
            {
                switch (randomNumber)
                {
                    case 1:
                        embed.WithDescription("Pile (1)")
                            .WithColor(Color.Gold);
                        break;
                    default:
                        embed.WithDescription("Face (2)")
                            .WithColor(Color.Gold);
                        break;
                }
            }

            /// Ce code gère tous autres types de dé. Si y'a un FDP qui utilise 3, casse lui les genoux parce que j'ai la flemme de m'en occuper de cette partie
            else
            {
                if(randomNumber > MaxValue - 5)
                {
                    embed.AddField(efb => efb.WithName($"{randomNumber.ToString()}").WithValue("Echec Critique !").WithIsInline(false));
                    embed.WithColor(185, 80, 80);
                }
                else if(randomNumber < MinValue + 5)
                {
                    embed.AddField(efb => efb.WithName($"{randomNumber.ToString()}").WithValue("Reussite Critique !").WithIsInline(false));
                    embed.WithColor(80, 185, 80);
                }
                else
                {
                    embed.WithDescription(randomNumber.ToString());
                    embed.WithColor(Color.Gold);
                }
            }

            await ReplyAsync("", false, embed.Build());
        }


        [Command("dice")]
        public async Task DiceRollCommand([Remainder]int DiceType)
            => await InternalDiceRoll(1, DiceType);
    }


}
