namespace DatasheetService.KSBasePayloadDTO
{
    public class CombinedData_OperatingPoint
    {
            public string Index { get; set; }
            public string DMNSNNG_DUTY_POINT_Result { get; set; }
            public string DMNSNNG_DUTY_POINT_Request { get; set; }
            public List<Feature> ResultFeatures { get; set; }
            public List<Feature> RequestFeatures { get; set; }
        
    }
}
