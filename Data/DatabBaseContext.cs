namespace Commander.Data
{
    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public  DataBaseContext
            (Microsoft.EntityFrameworkCore.DbContextOptions<DataBaseContext> options) : base(options)
        {
        
        }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Command> Commands {get; set;}
    }
}