using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace tugbot
{
    public class TugCommands : BaseCommandModule
    {

        [Command("Test")]
        public async Task Test(CommandContext ctx, params string[] args)
        {
            var members = ctx.Guild.Members.Values.ToList();
            var sb = new StringBuilder();
            sb.Append("UserSpecificClasses: {");
            foreach (var member in members)
            {
                var roles = member.Roles.ToList();
                sb.Append($"\"{member.Id}\": {{");
                for (var i = 0; i < roles.Count; i++)
                {
                    sb.Append($"{i}: \"{roles[i].Id}\",");
                }

                sb.Append("},");
            }
            sb.Append('}');
            var final = sb.ToString();
            await ctx.RespondAsync(final);
        }
        [Command("setRankColor")]
        public async Task SetRankColor(CommandContext ctx)
        {
            await ctx.RespondAsync("Shut up");
        }
        [Command("setRankName")]
        public async Task RankName(CommandContext ctx)
        {
            await ctx.RespondAsync("Shut up");
        }
        [Command("setServerName")]
        public async Task ServerName(CommandContext ctx)
        {
            await ctx.RespondAsync("Shut up");
        }
        [Command("setServerIcon")]
        public async Task ServerIcon(CommandContext ctx)
        {
            await ctx.RespondAsync("Shut up");
        }
    }
}

//Todo setRankColor [#, hsv, rgb]
//Todo setRankName [@name] [new name]
//Todo setServerName [server Name]
//Todo setServerIcon [url, upload]
//Todo Favorites ⭐
//ToDo Shit [user] says 🍞