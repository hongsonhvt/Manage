using Microsoft.AspNetCore.Mvc;
using MISA.WEBFresher042023.DEMO.Core.Service;
using MISA.WEBFresher042023.DEMO.Middleware;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;
using MISA.WEBFresher042023.DEMO.Core.Interface.Service;
using MISA.WEBFresher042023.DEMO.Core.MISAException;
///using MISA.WEBFresher042023.DEMO.Infrastructure.Reponsitory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var errors = context.ModelState.Values
                .SelectMany(x => x.Errors);

            return new BadRequestObjectResult(new BaseException()
            {
                ErrorCode = 400,
                UserMessage = "Lỗi nhập liệu người dùng",
                DevMessage = "Lỗi nhập liệu người dùng",
                TraceId = "",
                MoreInfo = "",
                Errors = errors
                //1.03
            }.ToString() ?? "");
        };
    })
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
///builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionMiddleware>();

app.Run();