using System.Linq.Expressions;
using KpiNew.Context;
using KpiNew.Entities;
using KpiNew.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace KpiNew.Implementation.Repository
{
    // public class KpiItemRepository : BaseRepository<KpiItem>, IKpiItemRepository
    // {
    //     public KpiItemRepository(ApplicationContext context)
    //     {
    //         _context = context;
    //     }

    //     public async Task<KpiItem> Get(Expression<Func<KpiItem, bool>> expression)
    //     {
    //          return await _context.KpiItems
    //               .Include(a => a.Kpis).ThenInclude(e => e.DepartmentKpis)
    //            .ThenInclude(k => k.Department)
    //                .Where(b => b.IsDeleted == false)
    //               .SingleOrDefaultAsync(expression);
    //     }

    //     public async Task<IList<KpiItem>> GetAll()
    //     {
    //           return await _context.KpiItems
    //               .Include(a => a.Kpis).ThenInclude(e => e.DepartmentKpis)
    //            .ThenInclude(k => k.Department)
    //                .Where(b => b.IsDeleted == false)
    //               .ToListAsync();
    //     }

    //     public async Task<KpiItem> GetKpiItemById(int id)
    //     {
    //           return await _context.KpiItems
    //               .Include(a => a.Kpis).ThenInclude(e => e.DepartmentKpis)
    //            .ThenInclude(k => k.Department)
    //                .Where(b => b.IsDeleted == false)
    //               .SingleOrDefaultAsync(a => a.Id == id);
    //     }

    //     public async Task<IList<KpiItem>> GetSelected(IList<int> ids)
    //     {
    //          return await _context.KpiItems
    //               .Include(a => a.Kpis).ThenInclude(e => e.DepartmentKpis)
    //            .ThenInclude(k => k.Department)
    //                .Where(b => b.IsDeleted == false)
    //                .Where(a => ids.Contains(a.Id))
    //               .ToListAsync();
            
    //     }

    //     public async Task<IList<KpiItem>> GetSelected(Expression<Func<KpiItem, bool>> expression)
    //     {
    //            return await _context.KpiItems
    //               .Include(a => a.Kpis).ThenInclude(e => e.DepartmentKpis)
    //            .ThenInclude(k => k.Department)
    //                .Where(b => b.IsDeleted == false)
    //                .Where(expression)
    //               .ToListAsync(); 
    //     }
   //}
}