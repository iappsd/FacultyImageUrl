using AutoMapper;
using FacultyImageUrl.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// إضافة خدمات MVC
builder.Services.AddControllers();

// إعداد AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// إعداد سلسلة الاتصال بقاعدة البيانات لاستخدام SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// إعداد خطوط الأنابيب HTTP
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
