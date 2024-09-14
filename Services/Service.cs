using DatasheetService.Model;

namespace DatasheetService.Services
{
    public class Service
    {
        ReportDao outputDao = new ReportDao();
        public List<ReportOutputDto> GetReport()
        {          

            return outputDao.GetReport();
        }
        public ReportOutputDto GetReport(string id)
        {
            //ReportDao outputDao = new ReportDao();

            return outputDao.GetReport(id);
        }

        public void AddReport(ReportRequestDTO input)
        {
           // ReportDao outputDao = new ReportDao();
            outputDao.setReport(input);
        }

        public void ExecuteReport(string id)
        {
            outputDao.ExecuteReport(id);
        }

    }

}
