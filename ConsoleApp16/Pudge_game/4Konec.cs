using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ConsoleApp16.Pudge_game
{
    public class Konec : ModuleBase<SocketCommandContext>
    {
        [Command("1_konec")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Konec_1()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813612607860766))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164782232797204/277ff9310a0cdbb0d498338e063a1eb5.jpg")
                    .AddField("Конец для первой позиции", "ты фармил в лесу почти всю игру, нафармив мом и башер, ты сказал команде пошли драться, но тебя никто не послушал, вы ничего не можете сделать команде противника" +
                    ", что приводит к очевидному проигрышу ((((")
                    .WithColor(0xFF4500);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("2_konec")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Konec_2()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813634728595496))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164682039259146/eMjaTh9ngak.jpg")
                    .AddField("Конец для второй позиции", "Ты приходил на все линии, но тебя там убивали и ты просто фидил, твой кор сломал шмотки, остальные пошли фидить, тебе ничего не остается кроме того как стать в амулет, а конец игры думаю уже понятен")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("3_konec")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Konec_3()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813643536654346))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164782232797204/277ff9310a0cdbb0d498338e063a1eb5.jpg")
                    .AddField("Конец для третьей позиции", "Ты с рубиком пытаешься бегать за фантомкой по лесу, но ее команда всегда приходит, когда замечает вас на вардах, вы просто фидите, а ваша команда вся фармит, ты думаешь раз они бьют крипов" +
                    "у них будут деньги на шмотки, но на 30 минуте у твоего антимага бф и манта, а вражеская фантомка отфидилась, что привело к убийству рошана, и к концу игры")
                    .WithColor(0xFF00FF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("4_konec")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Konec_4()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813651900104734))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164782232797204/277ff9310a0cdbb0d498338e063a1eb5.jpg")
                    .AddField("Конец для четвертой позиции", "Тебя все гонят со своих линий, говорят что ты только мешаешь, ты решаешь бить крипов в лесу, хотя оттуда тоже гонят, но в один момент вражеский мидер ливает(елка у него), вы с командой" +
                    "начинаете радоваться, ведь 5 на 4 точно выиграем, вы пытаетесь собраться всей командой, но противники дают отпор, настолько, что они спустя пару таких раз забирают рошана, вы пытались за него бороться, но это ни к чему не привело, кроме" +
                    "как к проигрышу игры")
                    .WithColor(0x00FFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("5_konec")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Konec_5()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813659659542568))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164782232797204/277ff9310a0cdbb0d498338e063a1eb5.jpg")
                    .AddField("Конец для пятой позиции", "Ну тут прям спидранспидран, твой кор после неудачного твоего хука, начинает орать в войс чат, и грозиться бить шмотки, если ты не уйдешь, но ты на это не обращаешь внимания и пытаешься дальше играть" +
                    "после очередного такого момента, твой кор и правда сломал шмотки, а твой мидер стоит 0 5 на 8 минуте, остальные тиммейты решают встать в амулет, потому что в такое играть не возможно, как мы можем понять, это луз.. (((((-30)))))")
                    .WithColor(0xFFFF00);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
    }
}
