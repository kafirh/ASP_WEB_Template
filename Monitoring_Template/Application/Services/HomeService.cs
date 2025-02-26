using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Application.DTO;
using Monitoring_Template.Application.Services.Interface;
using Monitoring_Template.Core.Entities;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Application.Services
{
    public class HomeService: IHomeService
    {
        private readonly IResultPackingLabelRepository _labelRepository;
        public HomeService(IResultPackingLabelRepository labelRepository) 
        {
            _labelRepository = labelRepository;
        }
        public async Task<List<ResultPackingLabelsModel>> LoadTabel(HomeRequestDTO request)
        {
            var query = _labelRepository.GetByDate(request.startDate, request.endDate);
            return await query
                .OrderBy(r => r.ScanningDate)
                .ToListAsync();
        }
    }
}
