using BlueAPI.IRepository;
using BlueAPI.IService;
using BlueAPI.Model;

namespace BlueAPI.Service
{
    public class MasterService: IMasterService
    {
        private readonly IMasterRepository _iMasterRepository;      
        public MasterService(IMasterRepository iMasterRepository)
        {            
            _iMasterRepository = iMasterRepository;
        }

        public async Task<List<DEASchedulesModel>> GetDEASchedules()
        {
            try
            {
                return await _iMasterRepository.GetDEASchedules();
            }
            catch (Exception ex)
            {                
                throw;
            }
        }
    }
}
