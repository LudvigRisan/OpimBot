using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpimBot.Modules {
    public class Ping : ModuleBase<SocketCommandContext> {

        

        [Command("ping")]
        public async Task pingAsync() {

            await ReplyAsync("Pong!");

        }

        [Command("boop")]
        public async Task boopAsync() {

            await ReplyAsync("Noooooooooo!");

        }

        [Command("bounce")]
        public async Task bounceTaskAsync([Remainder]string message) {

            await ReplyAsync(message);

        }

        [Command("Asshole")]
        public async Task assholeAsync() {
            
            await ReplyAsync($"{Context.User.Mention} is a useless piece of waste!");

        }

        [Command("embed")]
        public async Task EmbedifyAsync() {

            EmbedBuilder embedder = new EmbedBuilder();

            embedder.AddField("Some user:", Context.User.Mention)
                .AddInlineField("Best bot:", Context.Client.CurrentUser.Mention)
                .AddInlineField("Best user:", "<@213297762844934144>");

            await ReplyAsync("", false, embedder.Build());

        }

        

    }
}
