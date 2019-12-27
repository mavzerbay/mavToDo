using MavToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MavToDo.DataAccess.Concrete
{
    public class MavContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=mavzer\mavzerbay;Database=MavToDo;Integrated Security=SSPI");
        }

        public DbSet<ThingsToDo>ThingsToDos  { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}