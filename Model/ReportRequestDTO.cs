namespace DatasheetService.Model
{
    public class ReportRequestDTO
    {
        public string DatasourcePayload { get; set; }
        public ReportTemplate ReportTemplate { get; set; }
    }
    public class ReportTemplate
    {
        public string TemplateName { get; set; }
        public string TemplateId { get; set; }
    }
}
