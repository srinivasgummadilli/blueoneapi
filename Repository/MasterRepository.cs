using BlueAPI.IRepository;
using BlueAPI.Model;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace BlueAPI.Repository
{
    public class MasterRepository: IMasterRepository
    {
        private readonly DataContext _dataContext;
        public MasterRepository(DataContext dataContext)
        {           
            _dataContext = dataContext;           
        }

        public async Task<List<DEASchedulesModel>> GetDEASchedules()
        {
            try
            {
                List<DEASchedulesModel> results = await _dataContext.DEASchedules.Where(x => x.Status=="Active").ToListAsync();
                return results;
            }
            catch (Exception ex)
            {               
                throw;
            }
        }
    }
}
