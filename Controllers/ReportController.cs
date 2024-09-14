using DatasheetService.Model;
using DatasheetService.Services;
using Microsoft.AspNetCore.Mvc;


namespace DatasheetService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : Controller
    {
       
        Service service = new Service();
        

        [HttpGet]
        public List<ReportOutputDto> Get()
        {
           
            return service.GetReport();
        }

        [HttpGet("{id}")]
        public ReportOutputDto Get(string id)
        {
            //Service service = new Service();
            return service.GetReport(id);
        }

        [HttpPost]
        [Consumes("application/json", "application/xml")]
        public ReportOutputDto Post([FromBody] ReportRequestDTO request)
        {
           // Service service = new Service();
            service.AddReport(request);
            service.ExecuteReport(request.ReportTemplate.TemplateId);

            return service.GetReport(request.ReportTemplate.TemplateId);
        }

        //[HttpPost(Name = "test")]
        //[Consumes("application/json", "application/xml")]
        //public ReportOutputDto Post([FromBody] ReportRequestDTO request)
        //{
        //    ReportOutputDto output = new ReportOutputDto();
        //    output.TemplateName = request.ReportTemplate.TemplateName;
        //    output.TemplateId = request.ReportTemplate.TemplateId;
        //    output.TemplateValue = "test";

        //    return output;
        //}
        ////////////////////////////////////////////////////////
        //[HttpGet(Name = "test1")]

        //public List<ReportOutputDto> Get()
        //{
        //    ReportOutputDao outputDao = new ReportOutputDao();

        //    return outputDao.GetReports();
        //}
    }
}