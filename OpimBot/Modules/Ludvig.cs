using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpimBot.Modules {
    public class Ludvig : ModuleBase<SocketCommandContext> {

        Random randomizer = new Random();

        [Command("ludvig.rng")]
        public async Task Rng() {

            int randInt = (randomizer.Next() % 100) + 1;

            await ReplyAsync(randInt.ToString());

        }

        [Command("ludvig.rng")]
        public async Task Rng(int max) {

            int randInt = (randomizer.Next() % max) + 1;

            await ReplyAsync(randInt.ToString());

        }

        [Command("ludvig.rng")]
        public async Task Rng(int min, int max) {

            int randInt = (randomizer.Next() % (max - min)) + min;

            await ReplyAsync(randInt.ToString());

        }
    }
}
