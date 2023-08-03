using KpiNew.Dtos;
namespace KpiNew.Interface
{
    public interface IKpiItemService
    {
        Task<BaseRespond<KpiItemDto>> AddKpiItemAsync(KpiItemDto model);
        Task<BaseRespond<KpiItemDto>> DeleteKpiItemAsync(int id);
        Task<BaseRespond<KpiItemDto>> GetKpiItemByIdAsync(int id);
        Task<BaseRespond<ICollection<KpiItemDto>>> GetAllKpiItemAsync();
 
    }
}