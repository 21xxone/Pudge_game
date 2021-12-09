using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;


namespace ConsoleApp16.Modules
{
    public class ViborRoli : ModuleBase<SocketCommandContext>
    {
        public ulong id_role_start_game = 917493176766447636;
        public ulong id_role_pos1 = 917493177726947408;
        public ulong id_role_pos2 = 917493176766447636;
        public ulong id_role_pos3 = 917493176766447636;
        public ulong id_role_pos4 = 917493180134490174;
        public ulong id_role_pos5 = 917493181476638800;

        [Command ("1_pos")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Pos_1()
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
                    .AddField("Так ты выбрал 1 позицию..", "Что тут еще сказать, ты зритель дахака или кто? С самого начала игры на тебя орут твои тиммейты, но ты же не слабый, на характере кидаешь в мут," +
                    " и играешь в свою игру, а к чему это все приведет? ? ?")
                    .AddField("Команда для продолжения","1_igra")
                    .WithColor(0xFF4500);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
                SocketGuildUser user_player = Context.User as SocketGuildUser;
                await user_player.RemoveRoleAsync(id_role_start_game);
                await user_player.RemoveRoleAsync(id_role_pos4); // pos4
                await user_player.RemoveRoleAsync(id_role_pos3); // pos3
                await user_player.RemoveRoleAsync(id_role_pos2); // pos2
                await user_player.RemoveRoleAsync(id_role_pos5); // pos5
            }
                
        }
        [Command("2_pos")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Pos_2()
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
                    .AddField("зхц курсед я твой фанат", "Ого:face_with_monocle:, так ты сломал систему и пикнул сфа? А, не, тут выбора нет)) Возможно ты подписчик стрея, но это не влияет на реакцию твоих тиммейтов," +
                    "бесконечный флуд и визги в микрофон, ты пытаешься рассказать анекдот, но тебя никто не слушает.. К чему этот выбор тебя приведет?")
                    .AddField("Команда для продолжения", "2_igra")
                    .WithColor(0xFFFFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
                SocketGuildUser user_player = Context.User as SocketGuildUser;
                await user_player.RemoveRoleAsync(id_role_start_game);
                await user_player.RemoveRoleAsync(id_role_pos1); // удаление ролей pos1
                await user_player.RemoveRoleAsync(id_role_pos4); // pos4
                await user_player.RemoveRoleAsync(id_role_pos3); // pos3
                await user_player.RemoveRoleAsync(id_role_pos5); // pos5
            }
        }
        [Command("3_pos")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Pos_3()
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
                    .AddField("3 позиция, ура(мейн роль автора)", "Команда думает ты на жетонах, ведь такого персонажа пикнут в сложную линию, еще надо додуматься, но увы не такой уж и плохой выбор, с тобой на линию идет рубик," +
                    "сила на вашей линии присутствует, но что будет дальше? ?")
                    .AddField("Команда для продолжения", "3_igra")
                    .WithColor(0xFF00FF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
                SocketGuildUser user_player = Context.User as SocketGuildUser;
                await user_player.RemoveRoleAsync(id_role_start_game);
                await user_player.RemoveRoleAsync(id_role_pos1); // удаление ролей pos1
                await user_player.RemoveRoleAsync(id_role_pos4); // pos4
                await user_player.RemoveRoleAsync(id_role_pos2); // pos2
                await user_player.RemoveRoleAsync(id_role_pos5); // pos5
            }
        }
        [Command("4_pos")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Pos_4()
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
                    .WithThumbnailUrl("https://cdn.discordapp.com/attachments/916007738167943308/918164695448428554/40sqxSAkau4.jpg")
                    .AddField("4 позиция, мда", "К тебе сильных претензий нет, главное как ты себя покажешь в игре, команда спрашивает у тебя:''Ганги в мид будут?''. На что ты уверенно отвечаешь:''Да.''")
                    .AddField("Команда для продолжения","4_igra")
                    .WithColor(0x00FFFF);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
                SocketGuildUser user_player = Context.User as SocketGuildUser;
                await user_player.RemoveRoleAsync(id_role_start_game);
                await user_player.RemoveRoleAsync(id_role_pos1); // удаление ролей pos1
                await user_player.RemoveRoleAsync(id_role_pos3); // pos3
                await user_player.RemoveRoleAsync(id_role_pos2); // pos2
                await user_player.RemoveRoleAsync(id_role_pos5); // pos5
            } 
        }
        [Command("5_pos")]
        [RequireUserPermission(ChannelPermission.ViewChannel)]
        public async Task Pos_5()
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
                    .AddField("5 поз, хихиххихихихи", "Тут все сразу становится понятно, жетонщик-подпивасник, зашел поиграть в игру, тиммейты много от тебя не ожидают, главное чтобы не руинил")
                    .AddField("Команда для продолжения", "5_igra")
                    .WithColor(0xFFFF00);
                Embed embed = builder.Build();
                await ReplyAsync(embed: embed);
                SocketGuildUser user_player = Context.User as SocketGuildUser;
                await user_player.RemoveRoleAsync(id_role_start_game);
                await user_player.RemoveRoleAsync(id_role_pos1); // удаление ролей pos1
                await user_player.RemoveRoleAsync(id_role_pos4); // pos4
                await user_player.RemoveRoleAsync(id_role_pos3); // pos3
                await user_player.RemoveRoleAsync(id_role_pos2); // pos2
            } 
        }
    }
}
