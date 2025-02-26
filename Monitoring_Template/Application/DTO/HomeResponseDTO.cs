using Monitoring_Template.Core.Entities;
using Monitoring_Template.Infrastructure.Persistence.Repository;

namespace Monitoring_Template.Application.DTO
{
    public class HomeResponseDTO
    {
        public IEnumerable<ResultPackingLabelsModel> resultPackingLabelsModels { get; set; }
    }
}
