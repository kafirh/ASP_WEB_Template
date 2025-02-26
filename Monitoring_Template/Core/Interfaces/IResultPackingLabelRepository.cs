using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Core.Interfaces
{
    public interface IResultPackingLabelRepository
    {
        public Task<ResultPackingLabelsModel?> GetResult(int id);
        public IQueryable<ResultPackingLabelsModel> GetAll();
        public IQueryable<ResultPackingLabelsModel> GetByDate(DateOnly startDate, DateOnly endDate);
    }
}
