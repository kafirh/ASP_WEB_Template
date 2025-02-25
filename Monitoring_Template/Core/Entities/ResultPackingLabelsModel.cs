namespace Monitoring_Template.Core.Entities
{
    public class ResultPackingLabelsModel
    {
        public int Id { get; set; }
        public string? JenisProduk { get; set; }
        public string? ModelCode { get; set; }
        public string? ModelNumber { get; set; }
        public string? GlobalCodeId { get; set; }
        public string? SerialNumber { get; set; }
        public DateOnly ScanningDate { get; set; }
        public TimeOnly ScanningTime { get; set; }
        public int? Location { get; set; }
        public string? Register { get; set; }
        public string? OperatorId { get; set; }
    }
}
