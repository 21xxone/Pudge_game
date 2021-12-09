using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
namespace ConsoleApp16.Modules
{
    public class Class2 : ModuleBase<SocketCommandContext>
    {
        [Command ("info_pudge")]
        public async Task Pudge()
        {
            EmbedBuilder builder1 = new EmbedBuilder()
              .WithAuthor($"Pudge", $"https://cdn.discordapp.com/attachments/916007738167943308/916007753313579048/2097419980_preview_SomeAcademicCooter-max-1mb.gif")
              .WithImageUrl("https://cdn.discordapp.com/attachments/916007738167943308/916007753313579048/2097419980_preview_SomeAcademicCooter-max-1mb.gif")
              .AddField("Лор", "На полях Вечной бойни, далеко на юге от Квойджа, тучная фигура упорно трудится под покровом ночи — убирает, а затем расчленяет, потрошит, сгружает в кучи конечности и внутренние органы павших. " +
              "И все это лишь для того, чтобы на следующее утро бойня могла повториться." +
              " В том проклятом мире ничто не разлагается само по себе — мертвецам никогда не суждено вернуться обратно в землю, и не важно, насколько глубока могила.")
              .WithColor(new Color(0xff0000))
              .AddField("Meat Hook", "Способность: направленная на точку" +
              "\nДействует на: врагов / союзников" +
              "\nТип урона: чистый / мгновенное убийство" +
              "\nДальность применения: 1300" +
              "\nМакс.дистанция прохождения: 1300" +
              "\nРадиус захвата: 100" +
              "\nУрон: 150 / 220 / 290 / 360(Талант: 270 / 340 / 410 / 480)");
      


            Embed embed = builder1.Build();
            await ReplyAsync(null, false, embed);
        }
    }
}
