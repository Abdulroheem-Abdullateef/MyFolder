using System.Linq.Expressions;
using KpiNew.Entities;

namespace KpiNew.Interface.Repository
{
    public interface IKpiItemRepository : IRepository<KpiItem>
    {
        public Task<KpiItem> GetKpiItemById(int id);
        public Task<KpiItem> Get(Expression<Func<KpiItem, bool>> expression);
        public Task<IList<KpiItem>> GetSelected(IList<int> ids);
        public Task<IList<KpiItem>> GetSelected(Expression<Func<KpiItem, bool>> expression);
        public Task<IList<KpiItem>> GetAll();
    }
}