using BlueAPI.Model;

namespace BlueAPI.IService
{
    public interface IMasterService
    {
        Task<List<DEASchedulesModel>> GetDEASchedules();
    }
}
