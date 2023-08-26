using Microsoft.EntityFrameworkCore;

namespace BlueAPI.Model
{
    public class DataTableDesign
    {
        public void Table_DEASchedules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEASchedulesModel>().ToTable("DEASchedules", "dbo").HasKey(a => a.DEAScheduleID);
        }
    }
}
