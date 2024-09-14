namespace DatasheetService.KSBasePayloadDTO
{
    public class KSBasePayload
    {
        public string CreationDate { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerLanguage { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerPostCode { get; set; }
        public string CustomerStreet { get; set; }
        public string DocumentNo { get; set; }
        public string DocVersion { get; set; }
        public string IsNonSAPUser { get; set; }
        public string IsOrder { get; set; }
        public string IsWebshop { get; set; }
        public string PoDate { get; set; }
        public string SapdocumentNo { get; set; }
        public string SerializationId { get; set; }
        public string Subject { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public ExportItemData ExportItemData { get; set; }
        public ExportPositionChecklist ExportPositionChecklist { get; set; }
        public ConstantTexts ConstantTexts { get; set; }

    }
}
