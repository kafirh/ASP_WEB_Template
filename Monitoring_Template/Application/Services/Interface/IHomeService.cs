using Monitoring_Template.Application.DTO;
using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Application.Services.Interface
{
    public interface IHomeService
    {
        Task<List<ResultPackingLabelsModel>> LoadTabel(HomeRequestDTO request);
    }
}
