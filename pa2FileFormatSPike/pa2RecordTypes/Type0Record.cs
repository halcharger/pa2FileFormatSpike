
namespace pa2FileFormatSPike.pa2RecordTypes
{
    class Type0Record : Pa2Record
    {
        public Pa2Type RecordType { get { return Pa2Type.Type0; } }
        public int LineNumber { get; set; }

        public string ExchangeComplex { get; set; }
        public string BusinessDate { get; set; }
        public string SettlementOrIntraday { get; set; }
        public string FileIdentifier { get; set; }
        public string BusinessTime { get; set; }
        public string FileCreationDate { get; set; }
        public string FileCreationTime { get; set; }
        public string FileFormat { get; set; }
        public string MarginingIndicator { get; set; }
        public string OverallLimitOptionValueFlag { get; set; }
        public string BusinessFunction { get; set; }
        public string ClearingOrCustomerCode { get; set; }
        public string ClearingOrCustomerAcronymn { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountTypeAcronym { get; set; }
        public string PerformanceBondClassCode { get; set; }
        public string PerformanceBondClassAcronym { get; set; }
        public string MaintenanceOrInitialCode { get; set; }
        public string MaintenanceOrInitialAcronym { get; set; }
    }
}
