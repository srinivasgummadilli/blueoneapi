using Microsoft.EntityFrameworkCore;

namespace BlueAPI.Model
{
    public sealed class DataContext : DbContext
    {
        DataTableDesign _TableDesign = new DataTableDesign();
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                    
        }       

        public DbSet<DEASchedulesModel> DEASchedules { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _TableDesign.Table_DEASchedules(modelBuilder);
        }
    }
}
