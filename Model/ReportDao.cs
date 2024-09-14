namespace DatasheetService.Model
{
    public class ReportDao
    {
        // Data access object to connect database
        List<ReportOutputDto> output = new List<ReportOutputDto>();
        List<ReportRequestDTO> request = new List<ReportRequestDTO>();
       
        public List<ReportOutputDto> GetReport()
        {
            return output;

        }
        public ReportOutputDto GetReport(string id)
        {
            foreach (ReportOutputDto output in output)
            {
                if (output.TemplateId == id)
                return output;
            }
            return new ReportOutputDto();

        }
        public void setReport(ReportRequestDTO input)
        {
            request.Add(input);
        }

        public void ExecuteReport(string id)
        {
            ReportOutputDto reportOutput = new ReportOutputDto();
            foreach(ReportRequestDTO req in request)
            {
                if (req.ReportTemplate.TemplateId == id)
                {
                    reportOutput.TemplateId = req.ReportTemplate.TemplateId;
                    reportOutput.TemplateName = req.ReportTemplate.TemplateName;
                    //reportOutput.TemplateValue = req.ReportTemplate.
                }

            }
            output.Add(reportOutput);
        }
    }
}
