using FacultyImageUrl.Entity;
using Microsoft.EntityFrameworkCore;

namespace FacultyImageUrl.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<FacultyMember> FacultyMembers { get; set; } // مجموعة الكيانات لأعضاء هيئة التدريس
    }
}
