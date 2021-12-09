using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ConsoleApp16.Modules
{
    public class TestModule : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }
        [Command("test")]
        public async Task testTask()
        {
            await ReplyAsync("Test");
        }
        [Command("purge")]
        public async Task Purge(int amount = 1)
        {
            var messages = await Context.Channel.GetMessagesAsync(amount + 1).FlattenAsync();
            await (Context.Channel as SocketTextChannel).DeleteMessagesAsync(messages);
            await ReplyAsync($"Удалено {amount} сообщений");
        }
        [Command("plus")]
        public async Task Plus([Remainder] string messages)
        {
            string[] messages_2 = messages.Split(' ');
            int number;
            if ((Int32.TryParse(messages_2[0], out number) && Int32.TryParse(messages_2[1], out number)) == false)
            {
                await ReplyAsync("Проверьте правильность ввода");
            }
            else
            {
                int messages_3 = Convert.ToInt32(messages_2[0]) + Convert.ToInt32(messages_2[1]);
                await ReplyAsync($"{messages_3}");
            }
        }
        [Command("minus")]
        public async Task Minus([Remainder] string messages)
        {
            string[] messages_2 = messages.Split(' ');
            int number;
            if ((Int32.TryParse(messages_2[0], out number) && Int32.TryParse(messages_2[1], out number)) == false)
            {
                await ReplyAsync("Проверьте правильность ввода");
            }
            else
            {
                if (messages_2[0] == "1000" && messages_2[1] == "7")
                {
                    await ReplyAsync("Ну давай гуленыш");
                    int messages_zxc = 1000;
                    while (messages_zxc >= 0)
                    {
                        messages_zxc -= 7;
                        await ReplyAsync($"{messages_zxc}");
                    }
                }
                else
                {
                    int messages_3 = Convert.ToInt32(messages_2[0]) - Convert.ToInt32(messages_2[1]);
                    await ReplyAsync($"{messages_3}");
                }
            }
        }
        [Command("devide")]
        public async Task devide([Remainder] string messages)
        {
            string[] messages_2 = messages.Split(' ');
            int number;
            if ((Int32.TryParse(messages_2[0], out number) && Int32.TryParse(messages_2[1], out number)) == false)
            {
                await ReplyAsync("Проверьте правильность ввода");
            }
            else
            {
                double messages_3 = Convert.ToDouble(messages_2[0]) / Convert.ToDouble(messages_2[1]);
                await ReplyAsync($"{messages_3}");
            }
        }
        [Command("multiply")]
        public async Task multiply([Remainder] string messages)
        {
            string[] messages_2 = messages.Split(' ');
            int number;
            if ((Int32.TryParse(messages_2[0], out number) && Int32.TryParse(messages_2[1], out number)) == false)
            {
                await ReplyAsync("Проверьте правильность ввода");
            }
            else
            {
                int messages_3 = Convert.ToInt32(messages_2[0]) * Convert.ToInt32(messages_2[1]);
                await ReplyAsync($"{messages_3}");
            }
        }
        [Command("scream")]
        public async Task scream([Remainder]string messages)
        {
            await ReplyAsync($"{messages.ToUpper()}");
        }
        [Command("destroy")]
        public async Task deleteChannel()
        {
            SocketGuildChannel socketGuildChannel = Context.Channel as SocketGuildChannel;
            await socketGuildChannel.DeleteAsync();
        }
    }
}
