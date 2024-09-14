namespace DatasheetService.KSBasePayloadDTO
{
    public class ExportPositionChecklist
    {
        public string PositionNumber { get; set; }
        public ExportOptionalDatasheets ExportOptionalDatasheets { get; set; }
        public ExportMandatoryDatasheets ExportMandatoryDatasheets { get; set; }

    }
}
