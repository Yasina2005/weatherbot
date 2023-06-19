using Telegram.Bot;
using Telegram.Bot.Polling;

var builder = WebApplication.CreateBuilder(args);
//ozgartirdim
builder.Services.AddHostedService<BotBackgroundService>();
builder.Services.AddTransient<IUpdateHandler, UpdateHandler>();
builder.Services.AddSingleton<ITelegramBotClient, TelegramBotClient>(
    p => new TelegramBotClient(builder.Configuration.GetValue("BotApiKey", string.Empty))
);

var app = builder.Build();

app.Run();
