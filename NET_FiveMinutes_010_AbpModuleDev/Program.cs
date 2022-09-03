using Microsoft.AspNetCore.Http.Features;
using NET_FiveMinutes_010_AbpModuleDev;
using Volo.Abp;

var builder = WebApplication.CreateBuilder(args);

////�����������С
//builder.WebHost.ConfigureKestrel((context, options) =>
//{
//    options.Limits.MaxRequestBodySize = int.MaxValue;
//});
//builder.Services.Configure<FormOptions>(options =>
//{
//    options.MultipartBodyLengthLimit = int.MaxValue;
//});

// �������ô���,������ӣ��������ʾ�Ҳ�����������Ĵ���
builder.Services.ReplaceConfiguration(builder.Configuration);

builder.Services.AddApplication<AppModule>(options=>options.UseAutofac());

var app = builder.Build();
app.InitializeApplication();
app.Run();

