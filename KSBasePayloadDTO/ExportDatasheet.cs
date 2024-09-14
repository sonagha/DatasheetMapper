namespace DatasheetService.KSBasePayloadDTO
{
    public class ExportDatasheet
    {
        public string Selected { get; set; }
        public ExportDatasheetDetails ExportDataSheet { get; set; }

    }
    public class ExportDatasheetDetails
    {
        public string Name { get; set; }
    }
}
