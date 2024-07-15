using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using DAL;
using Microsoft.EntityFrameworkCore;
using BLL;

var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddScoped<BLLManager>();*/

/*DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("ClayKefDB");
builder.Services.AddDbContext<ClayKefContext>(opt => opt.UseSqlServer(connString));
builder.Services.AddScoped<ICourseRepo, CourseRepo>();
*/
builder.Services.AddControllers();
DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("ClayKefDB");
builder.Services.AddServices(connString);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
/*builder.Services.AddSwaggerGen();*/
var app = builder.Build();
/*app.UseSwagger();
app.UseSwaggerUI();*/
app.MapControllers();
app.MapGet("/", () => "Hello World!");
app.Run();
