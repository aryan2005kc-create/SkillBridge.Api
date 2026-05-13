using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SkillBridge.Api.Entities;

public class SkillBridgeDbContext : DbContext
{
    public SkillBridgeDbContext(DbContextOptions<SkillBridgeDbContext> options) : base(options)

    {
    }
    public DbSet<User> Users { get; set; }


}