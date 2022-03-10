using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;

namespace tugbot
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }
        
        static async Task MainAsync()
        {
            var discord = new DiscordClient(
                new DiscordConfiguration()
                {
                    Token = "Mjk1MTA1NzExOTIxNDMwNTI4.WNYknA.ZUdwjcQY_RwR6TSsl8aANqMAbIM",
                    TokenType = TokenType.Bot
                    //Intents = DiscordIntents.All
                }
            );
            var commands = discord.UseCommandsNext(
                new CommandsNextConfiguration()
                {
                    StringPrefixes = new[] {"!"}
                }
            );

            commands.RegisterCommands<TugCommands>();

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}

