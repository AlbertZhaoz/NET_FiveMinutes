using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using NET_FiveMinutes_009_GraphQL.GraphQL.Mutations;
using NET_FiveMinutes_009_GraphQL.GraphQL.Queries;
using NET_FiveMinutes_009_GraphQL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add some configuration
builder.Configuration.AddJsonFile("CfgFiles\\DbConnect.json",true,true);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Tool_LuDbContext>(opt=>
{
    opt.UseSqlServer(builder.Configuration.GetSection("DbConnectStr:SqlServerStr:ConnectStr").Value);
});

//{
//    // 测试数据库连接是否正常
//    var dbtest = builder.Services.BuildServiceProvider().GetRequiredService<Tool_LuDbContext>();

//    var test  = dbtest.ToolLus;

//    dbtest.AddAsync(new Tool_Lu(){Title = "test",TitleLink = "www.test.com",Sort = "[Test]"});
//    dbtest.SaveChangesAsync();
//}

// 增加GraphQL配置
builder.Services
    .AddGraphQLServer()
    .AddQueryType<AlbertQuery>()
    .AddMutationType<AlbertMutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 启用GraphQL中间件
app.MapGraphQL();

app.UseAuthorization();

app.MapControllers();

app.Run();
