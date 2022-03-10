using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace tugbot
{
    public class TugCommands : BaseCommandModule
    {
        [Command("hey")]
        public async Task GreetCommand(CommandContext ctx)
        {
            await ctx.RespondAsync("Shut up");
        }
    }
}

//Todo Prefix = !
//Todo setRankColor [#, hsv, rgb]
//Todo setRankName [@name] [new name]
//Todo setServerName [server Name]
//Todo setServerIcon [url, upload]
//Todo Favorites ⭐
//ToDo Shit [user] says 🍞