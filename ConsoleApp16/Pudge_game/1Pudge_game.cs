using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp16.Modules
{
    public class Pudge_game : ModuleBase<SocketCommandContext>
    {
        public ulong id_role_start_game = 917493176766447636;
        public ulong id_role_pos1 = 917493177726947408;
        public ulong id_role_pos2 = 917493176766447636;
        public ulong id_role_pos3 = 917493179555659867;
        public ulong id_role_pos4 = 917493180134490174;
        public ulong id_role_pos5 = 917493181476638800;

        [Command("start")]
        public async Task Start_game()
        {
            SocketGuildUser user_player = Context.User as SocketGuildUser;
            await user_player.RemoveRoleAsync(id_role_pos1); // удаление ролей pos1
            await user_player.RemoveRoleAsync(id_role_pos4); // pos4
            await user_player.RemoveRoleAsync(id_role_pos3); // pos3
            await user_player.RemoveRoleAsync(id_role_pos2); // pos2
            await user_player.RemoveRoleAsync(id_role_pos5); // pos5

            EmbedBuilder builder = new EmbedBuilder()
                .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                .AddField($"Начал игру {Context.User.Username}", "Вам будет предоставлен выбор действий, которые будет делать ваш герой, это повлияет на конечный результат игры (игра очень локальная, так что немногие поймут)")
                .AddField("Предистория", "Ты вернувшись домой, решаешь сыграть на своем любимом герое, запускаешь поиск, спустя 7 минут поиска," +
                " приходит долгожданная зеленая кнопка <<Принять>>, дальнейшее развитие событий зависит только от тебя! Удачи")
                .WithThumbnailUrl(Context.User.GetAvatarUrl())
                .AddField("Команда для продолжения", "<<next + @name>> и получение роли через команду <<add_role + @name (свое имя))>> (Префикс для команд - !)");
            Embed embed = builder.Build();
            await ReplyAsync(embed: embed);

        }
        [Command("next")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task First_Text()
        {
            if (Context.Guild.GetChannel(Context.Channel.Id) != Context.Guild.GetChannel(917812888457064508))
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
                Random number = new Random();
                int value_number = number.Next(1, 10);
                if (value_number % 2 == 0)
                {
                    EmbedBuilder builder = new EmbedBuilder()
                        .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                        .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/917366972180729916/memy-s-among-us-i-mehaniki-na-grani-bagov-o-chem-govorit-reddit-45-dota-2-534ef86.jpg")
                        .AddField("Увы но....", "После кнопки принять, ты зашел в игру, но пуджа забанили, придется еще раз писать Next, ведь играть не на пудже нет смысла");
                    Embed embed = builder.Build();
                    await ReplyAsync(embed: embed);
                    value_number = number.Next(1, 10);
                }
                else
                {
                    
                    EmbedBuilder builder = new EmbedBuilder()
                        .WithAuthor($"{Context.User.Username}", $"{Context.User.GetAvatarUrl()}")
                        .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/916007753313579048/2097419980_preview_SomeAcademicCooter-max-1mb.gif")
                        .AddField("Ты принял игру, а что дальше?", "Происходит загрузвка в матч, ты неприменно этого ожидаешь, видишь черную иконку на пудже (Возможный персонаж для бана), но его не забанили, ты радостный" +
                        "пикаешь его, остается только один вопрос, а на какую роль мне пойти?")
                        .AddField("Команды для выбора роли", "add_role_pos1/2/3/4/5 + @name\n" +
                        "после этого дается доступ в канал, где мы пишем 1/2/3/4/5_pos (в зависимости от выбора)");
                    Embed embed = builder.Build();
                    await ReplyAsync(embed: embed);
                }
            }
        }
    }
}
