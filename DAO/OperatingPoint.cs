using DatasheetService.KSBasePayloadDTO;
using System.Collections.Generic;
using System.Linq;

public class OperatingPoint
{
    public List<CombinedData_OperatingPoint> CombineData(KSBasePayload payload)
    {
        var combinedDataList = new List<CombinedData_OperatingPoint>();

        foreach (var resultPoint in payload.ExportItemData.ExportResultPoint)
        {
            var requestPoint = payload.ExportItemData.ExportRequestPoint.FirstOrDefault(rp => rp.Index == resultPoint.Index);

            if (requestPoint != null)
            {
                var resultDutyPoint = resultPoint.Feature.FirstOrDefault(f => f.TechnicalName == "DMNSNNG_DUTY_PNT")?.Value;
                var requestDutyPoint = requestPoint.Feature.FirstOrDefault(f => f.TechnicalName == "DMNSNNG_DUTY_PNT")?.Value;

                if (resultDutyPoint == requestDutyPoint)
                {
                    var combinedData = new CombinedData_OperatingPoint
                    {
                        Index = resultPoint.Index,
                        DMNSNNG_DUTY_POINT_Result = resultDutyPoint,
                        DMNSNNG_DUTY_POINT_Request = requestDutyPoint,
                        ResultFeatures = resultPoint.Feature,
                        RequestFeatures = requestPoint.Feature
                    };

                    combinedDataList.Add(combinedData);
                }
            }
        }

        return combinedDataList;
    }
}
