using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ConsoleApp16.Pudge_game
{
    public class Posle_vibora_pos : ModuleBase<SocketCommandContext>
    {
        [Command("1_igra")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Igra_na_1_pos()
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
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917457972270071839/download.jpg")
                    .AddField("ну давай..", "у тебя проблемы на линии, против тебя два дальника, ты не добиваешь крипов, твоя 5 позиция фидит, ты решаешь уйти в лес и фармить шмотки, но победишь ли ты только фармя крипов?")
                    .AddField("Команда для продолжения", "1_konec")
                    .WithColor(0xFF4500);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("2_igra")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Igra_na_2_pos()
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
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917822763950043176/5b1934ca7916778b.gif")
                    .AddField("АХАХХА, извините", "Против тебя была квопа, и результат не заставил себя ждать, ты проиграл мид, тебе снесли башню, от тебя просят ганги, но что ты можешь предоставить своей команде?")
                    .WithColor(0xFFFFFF)
                    .AddField("Команда для продолжения", "2_konec");
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("3_igra")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Igra_na_3_pos()
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
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164625386790982/drainpango.jpg")
                    .AddField("Вау", "Вы отлично постояли на линии, вражеская фантомка ничего не получила с линии и ушла в лес, ты говоришь команде, чтобы продолжили за ней гнаться, но тебя не слушают, будет ли это фатальная ошибка?")
                    .WithColor(0xFF00FF)
                    .AddField("Команда для продолжения", "3_konec");
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("4_igra")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Igra_na_4_pos()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917813651900104734))
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917815872255582278/download.jpg")
                    .AddField("Упс..", "Команда вызвана не в том канале")
                    .WithColor(0xFFFFFF); ;
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
            else
            {
                EmbedBuilder builder = new EmbedBuilder()
                    .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164695448428554/40sqxSAkau4.jpg")
                    .AddField("афк пуджа", "ты высматриваешь свою добычу как лев, вражеская гуля так и манит, подловив ее в одном моменте, ты его хукаешь, но это приходит к твоей смерти, твоя тройка не понимает зачем ты это сделал" +
                    "и говорит тебе уйти с линии, ты приходишь на мид, но тебя было видно по вардам, вообщем успеха в игре пока что нет, все надеются что ты разыграешься")
                    .WithColor(0x00FFFF)
                    .AddField("Команда для продолжения", "4_konec");
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
        [Command("5_igra")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Igra_na_5_pos()
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
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917823247066734652/MzVIdDBNQURIdg.gif")
                    .AddField("Закончились мысли", "Ты простоял все время на линии в кустах, со словами ''Сейчас хукну'', но эти слова выби вальшивы, ничего не сделав на линии, вы проигрываете ее, и ты начинаешь бегать по карте," +
                    "пытаясь принести пользу своей команде")
                    .WithColor(0xFFFF00)
                    .AddField("Команда для продолжения", "5_konec");
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
            }
        }
    }
}
