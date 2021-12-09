using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
namespace ConsoleApp16.Modules
{
    public class Addrole : ModuleBase <SocketCommandContext>
    {
        public ulong id_role_start_game = 917493176766447636;
        public ulong id_role_pos1 = 917493177726947408;
        public ulong id_role_pos2 = 917493176766447636;
        public ulong id_role_pos3 = 917493179555659867;
        public ulong id_role_pos4 = 917493180134490174;
        public ulong id_role_pos5 = 917493181476638800;


        [Command("create_channels")]
        public async Task create_channels()
        {
            ulong author_id = 213714057520218112;
            if (Context.User.Id == author_id)
            {
                await Context.Guild.CreateTextChannelAsync("start_game");
                await Context.Guild.CreateTextChannelAsync("1pos");
                await Context.Guild.CreateTextChannelAsync("2pos");
                await Context.Guild.CreateTextChannelAsync("3pos");
                await Context.Guild.CreateTextChannelAsync("4pos");
                await Context.Guild.CreateTextChannelAsync("5pos");
            }
            else
            {
                await ReplyAsync("Тебе такое можно ((((9");
            }
        }
        [Command ("create_roles")]
        public async Task Create_roles()
        {
            ulong author_id = 213714057520218112;
            if (Context.User.Id == author_id)
            {
                Color Color_start_game = new Color(0x0000FF);
                await Context.Guild.CreateRoleAsync("Start_game", null, Color_start_game, false, null);

                Color Color_1pos = new Color(0xFF4500);
                await Context.Guild.CreateRoleAsync("1pos", null, Color_1pos, false, null);

                Color Color_2pos = new Color(0xFFFFFF);
                await Context.Guild.CreateRoleAsync("2pos", null, Color_2pos, false, null);

                Color Color_3pos = new Color(0xFF00FF);
                await Context.Guild.CreateRoleAsync("3pos", null, Color_3pos, false, null);

                Color Color_4pos = new Color(0x00FFFF);
                await Context.Guild.CreateRoleAsync("4pos", null, Color_4pos, false, null);

                Color Color_5pos = new Color(0xFFFF00);
                await Context.Guild.CreateRoleAsync("5pos", null, Color_5pos, false, null);
            }
            else
            {
                await ReplyAsync("Тебе такое нельзя )");
            }
        }
        [Command ("add_role")]
        public async Task AddRole(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(917493176766447636);
            await message1.AddRoleAsync(role);
            await ReplyAsync("Роль успешно добавлена");
        }
        [Command("add_role_pos1")]
        public async Task AddRole_pos1(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(id_role_pos1);
            await message1.AddRoleAsync(role);
            await ReplyAsync("Роль успешно добавлена");
        }
        
        [Command("add_role_pos2")]
        public async Task AddRole_pos2(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(id_role_pos2);
            await message1.AddRoleAsync(role);
            await ReplyAsync("Роль успешно добавлена");
        }
        [Command("add_role_pos3")]
        public async Task AddRole_pos3(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(id_role_pos3);
            await message1.AddRoleAsync(role);
            await ReplyAsync("Роль успешно добавлена");
        }
        [Command("add_role_pos4")]
        public async Task AddRole_4(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(id_role_pos4);
            await message1.AddRoleAsync(role);
            await ReplyAsync("Роль успешно добавлена");
        }
        [Command("add_role_pos5")]
        public async Task AddRole_5(SocketUser message)
        {
            SocketGuildUser message1 = message as SocketGuildUser;
            IRole role = Context.Guild.GetRole(id_role_pos5);
            await message1.AddRoleAsync(role, null);
            await ReplyAsync("Роль успешно добавлена");
        }
    }
}
