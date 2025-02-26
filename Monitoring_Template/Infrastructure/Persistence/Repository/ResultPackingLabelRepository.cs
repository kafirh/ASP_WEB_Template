using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Core.Entities;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Infrastructure.Persistence.Repository
{
    public class ResultPackingLabelRepository : IResultPackingLabelRepository
    {
        private readonly DatabaseContext _databaseContext;
        public ResultPackingLabelRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public IQueryable<ResultPackingLabelsModel> GetByDate(DateOnly startDate, DateOnly endDate)
        {
            return _databaseContext.Result_Packing_Labels
                .AsNoTracking()
                .Where(r => r.ScanningDate >= startDate && r.ScanningDate <= endDate);
        }

        public async Task<ResultPackingLabelsModel?> GetResult(int id)
        {
            return await _databaseContext.Result_Packing_Labels.
                FirstOrDefaultAsync(x => x.Id == id);
        }

        IQueryable<ResultPackingLabelsModel> IResultPackingLabelRepository.GetAll()
        {
            return _databaseContext.Result_Packing_Labels
                .AsNoTracking();
        }
    }
}
