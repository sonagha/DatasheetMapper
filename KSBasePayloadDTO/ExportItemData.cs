namespace DatasheetService.KSBasePayloadDTO
{
    public class ExportItemData
    {
        public string CustomerItemNumber { get; set; }
        public string IsBt3 { get; set; }
        public string IsConflictFree { get; set; }
        public string ItemText { get; set; }
        public string KKSNR { get; set; }
        public string Name { get; set; }
        public string ObjDescription { get; set; }
        public string OptionalItemText { get; set; }
        public string PositionName { get; set; }
        public string PosNo { get; set; }
        public string Quantity { get; set; }
        public string Version { get; set; }
        public List<Feature> Feature { get; set; }
        public List<ExportMotorCurveData> ExportMotorCurveData { get; set; }
        public List<ExportAccessories> ExportAccessories { get; set; }
        public List<ExportResultPoint> ExportResultPoint { get; set; }
        public List<ExportRequestPoint> ExportRequestPoint { get; set; }
        public Item Item { get; set; }

    }
}
