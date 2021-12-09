using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ConsoleApp16.Modules
{
    public class SecondLesson : ModuleBase<SocketCommandContext>
    {
        /*EmbedBuilder builder = new EmbedBuilder()
            .WithAuthor("Pudge", "https://cdn.discordapp.com/attachments/916007738167943308/916007753313579048/2097419980_preview_SomeAcademicCooter-max-1mb.gif")
            .WithDescription("Ты вызвал паджа")
            .WithFooter("")
            .WithColor(new Color(0xB656E5));
        Embed embed = builder.Build();
        await ReplyAsync(null, false, embed);*/
        [Command("info")]
        public async Task UserInfo_a(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            int days_in_discord = Math.Abs(message.CreatedAt.Date.Day - DateTime.Now.Day);
            int months_in_discord = Math.Abs(message.CreatedAt.Date.Month - DateTime.Now.Month);
            int year_in_discord = Math.Abs(message.CreatedAt.Date.Year - DateTime.Now.Year);
            int days_in_server = Math.Abs(message1.JoinedAt.Value.Day - DateTime.Now.Day);
            int months_in_server = Math.Abs(message1.JoinedAt.Value.Month - DateTime.Now.Month);
            int year_in_server = Math.Abs(message1.JoinedAt.Value.Year - DateTime.Now.Year);
            int asjdka = (Math.Abs(months_in_server * 30) - days_in_server + Math.Abs(year_in_server * 365));
            int asjdkaa = (Math.Abs(months_in_discord * 30) - days_in_discord + Math.Abs(year_in_discord * 365));
            EmbedBuilder builder1 = new EmbedBuilder()
                .AddField("Дата создания аккаунта", $"{message.CreatedAt}")
                .WithAuthor($"{message.Username}", $"{message.GetAvatarUrl()}")
                .AddField("Когда зашел на канал", $"{message1.JoinedAt}")
                .AddField("Полное имя пользователя",
                $"{message.Username}#{message.Discriminator}({message1.Nickname})")
                .AddField("Сколько дней в дискорде", $"{asjdkaa}")
                .AddField("Сколько дней на сервере", $"{asjdka}")
                .WithThumbnailUrl($"{message.GetAvatarUrl()}");
            Embed embed = builder1.Build();
            await ReplyAsync(null, false, embed);
        }
        [Command("info")]
        public async Task UserInfo()
        {
            int days_in_discord = Math.Abs(Context.User.CreatedAt.Date.Day - DateTime.Now.Day);
            int months_in_discord = Math.Abs(Context.User.CreatedAt.Date.Month - DateTime.Now.Month);
            int year_in_discord = Math.Abs(Context.User.CreatedAt.Date.Year - DateTime.Now.Year);
            int days_in_server = Math.Abs(Context.Guild.CurrentUser.JoinedAt.Value.Day - DateTime.Now.Day);
            int months_in_server = Math.Abs(Context.Guild.CurrentUser.JoinedAt.Value.Month - DateTime.Now.Month);
            int year_in_server = Math.Abs(Context.Guild.CurrentUser.JoinedAt.Value.Year - DateTime.Now.Year);
            int asjdka = (Math.Abs(months_in_server * 30) - days_in_server + Math.Abs(year_in_server * 365));
            int asjdkaa = (Math.Abs(months_in_discord * 30) - days_in_discord + Math.Abs(year_in_discord * 365));
            EmbedBuilder builder1 = new EmbedBuilder()
                .AddField("Дата создания аккаунта", $"{Context.User.CreatedAt}")
                .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                .AddField("Когда зашел на канал", $"{Context.Guild.CurrentUser.JoinedAt}")
                .AddField("Полное имя пользователя",
                $"{Context.User.Username}#{Context.User.Discriminator}({Context.Guild.CurrentUser.Nickname})")
                .AddField("Сколько дней в дискорде", $"{asjdkaa}")
                .AddField("Сколько дней на сервере", $"{asjdka}")
                .WithThumbnailUrl($"{Context.User.GetAvatarUrl()}");
            Embed embed = builder1.Build();
            await ReplyAsync(null, false, embed);
        }
    }
}
