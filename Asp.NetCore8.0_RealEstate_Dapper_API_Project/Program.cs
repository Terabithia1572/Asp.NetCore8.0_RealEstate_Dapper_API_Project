using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EmployeeRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ServiceRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.StatisticsRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.TestimonialRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.WhoWeAreRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ContactRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Hubs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductRepositories;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.MessageRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository,CategoryRepository>();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();


// Add services to the container.



builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials()
        .AllowAnyOrigin()
        .WithOrigins("*");
    });
});
builder.Services.AddHttpClient();
builder.Services.AddSignalR();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");
//localhost:1234/swagger/category/index
//localhost:1234/signalrhub

app.Run();