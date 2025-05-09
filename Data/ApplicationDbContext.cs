using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab4_2.Data;

namespace Lab4_2.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

public DbSet<Lab4_2.Data.VideoGame> VideoGame { get; set; } = default!;
}
