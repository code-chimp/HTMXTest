using HTMXTest.UI.Models;
using Lib.AspNetCore.ServerSentEvents;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddRazorPages(o => { o.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute()); })
    .AddRazorRuntimeCompilation();

builder.Services.AddServerSentEvents();
builder.Services.AddHostedService<ServerEventsWorker>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapServerSentEvents("/rn-updates");
app.MapRazorPages();

app.Run();