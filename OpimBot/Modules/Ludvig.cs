using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpimBot.Modules {
    public class Ludvig : ModuleBase<SocketCommandContext> {

        Random randomizer = new Random();

        static int counter = 0;

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

        [Command("ludvig.increment")]
        public async Task Incremet() {

            counter++;

            string th = "th";

            if(counter % 10 == 1) {
                th = "st";
            }
            if(counter % 10 == 2) {
                th = "nd";
            }
            if(counter % 10 == 3) {
                th = "rd";
            }
            
            await ReplyAsync($"{Context.User.Mention} is the {counter.ToString()}{th} user to increment");
        }

        [Command("ludvig.dump")]
        public async Task Dump() {
            string dumper = "";
            for(int i = 0; i < counter; i++) {
                dumper += "Aa";
            }

            counter = 0;
            await ReplyAsync(dumper);
        }


    }
}
