using BlueAPI.Model;

namespace BlueAPI.IRepository
{
    public interface IMasterRepository
    {
        Task<List<DEASchedulesModel>> GetDEASchedules();
    }
}
