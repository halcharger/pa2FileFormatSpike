using pa2FileFormatSPike.pa2RecordTypes;

namespace pa2FileFormatSPike.Parsers
{
    /// <summary>
    /// Specification of Type0 record is located here: http://www.cmegroup.com/confluence/display/pubspan/Type+0+Records+-+Standard
    /// </summary>
    class Type0Parser : Pa2Parser<Type0Record>
    {
        protected override void ConfigureFieldDefinitions()
        {
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(2, 6, (r, s) => r.ExchangeComplex = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(8, 8, (r, s) => r.BusinessDate = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(16, 1, (r, s) => r.SettlementOrIntraday = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(17, 2, (r, s) => r.FileIdentifier = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(19, 4, (r, s) => r.BusinessTime = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(23, 8, (r, s) => r.FileCreationDate = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(31, 4, (r, s) => r.FileCreationTime = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(35, 2, (r, s) => r.FileFormat = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(37, 1, (r, s) => r.MarginingIndicator = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(38, 1, (r, s) => r.OverallLimitOptionValueFlag = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(39, 5, (r, s) => r.BusinessFunction = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(50, 1, (r, s) => r.ClearingOrCustomerCode = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(52, 5, (r, s) => r.ClearingOrCustomerAcronymn = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(58, 1, (r, s) => r.AccountTypeCode = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(60, 5, (r, s) => r.AccountTypeAcronym = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(66, 1, (r, s) => r.PerformanceBondClassCode = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(68, 5, (r, s) => r.PerformanceBondClassAcronym = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(74, 1, (r, s) => r.MaintenanceOrInitialCode = s));
            fieldDefinitions.Add(new FieldDefinition<Type0Record>(76, 5, (r, s) => r.MaintenanceOrInitialAcronym = s));
        }
    }
}
