using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) 
        {
            
        }

        //represent command object into our database as dbSet, it's gonna be called Commands 
        public DbSet<Command> Commands { get; set; }
        
        
    }
}