using Microsoft.EntityFrameworkCore;

namespace ClassTaskUdemyAPI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) :base(options)
        {
            
        }
    }
}
