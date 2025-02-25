using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Core.Interfaces
{
    public interface IResultPackingLabelRepository
    {
        public Task<ResultPackingLabelsModel?> GetResult(int id);
        public Task<List<ResultPackingLabelsModel>> GetAll();
    }
}
