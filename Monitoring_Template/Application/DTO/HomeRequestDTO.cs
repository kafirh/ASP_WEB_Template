using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Application.DTO
{
    public class HomeRequestDTO
    {
        public DateOnly startDate {  get; set; }
        public DateOnly endDate { get; set; }
    }
}
