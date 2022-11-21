using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EUSalesListEntityVocabulary : SimpleVocabulary
    {
        public EUSalesListEntityVocabulary()
        {
            VocabularyName = "EU Sales List Entity";
            KeyPrefix = "commonDataModel.eusaleslistentity";
            KeySeparator = ".";
            Grouping = "/EUSalesListEntity";

            AddGroup("EUSalesListEntity Details", group =>
            {
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DispatchId = group.Add(new VocabularyKey(nameof(DispatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemsValue = group.Add(new VocabularyKey(nameof(ItemsValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicesValue = group.Add(new VocabularyKey(nameof(ServicesValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvestmentValue = group.Add(new VocabularyKey(nameof(InvestmentValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotAssignedValue = group.Add(new VocabularyKey(nameof(NotAssignedValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ListCode = group.Add(new VocabularyKey(nameof(ListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey(nameof(Year), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosingDate = group.Add(new VocabularyKey(nameof(ClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCode = group.Add(new VocabularyKey(nameof(DeliveryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSettlement = group.Add(new VocabularyKey(nameof(IsSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorLog = group.Add(new VocabularyKey(nameof(ErrorLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Corrected = group.Add(new VocabularyKey(nameof(Corrected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionSign = group.Add(new VocabularyKey(nameof(CorrectionSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionPeriod = group.Add(new VocabularyKey(nameof(CorrectionPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionFiscalYear = group.Add(new VocabularyKey(nameof(CorrectionFiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionAmount = group.Add(new VocabularyKey(nameof(CorrectionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedServices = group.Add(new VocabularyKey(nameof(CorrectedServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionSignServices = group.Add(new VocabularyKey(nameof(CorrectionSignServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionPeriodServices = group.Add(new VocabularyKey(nameof(CorrectionPeriodServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionFiscalYearServices = group.Add(new VocabularyKey(nameof(CorrectionFiscalYearServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionAmountServices = group.Add(new VocabularyKey(nameof(CorrectionAmountServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionDeclarationType = group.Add(new VocabularyKey(nameof(CorrectionDeclarationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionMonthOrQuarter = group.Add(new VocabularyKey(nameof(CorrectionMonthOrQuarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionMonthOrQuarterServices = group.Add(new VocabularyKey(nameof(CorrectionMonthOrQuarterServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionReasonWrongAmount = group.Add(new VocabularyKey(nameof(CorrectionReasonWrongAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionReasonWrongPeriod = group.Add(new VocabularyKey(nameof(CorrectionReasonWrongPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionReasonWrongRegNum = group.Add(new VocabularyKey(nameof(CorrectionReasonWrongRegNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalSalesListStatus = group.Add(new VocabularyKey(nameof(OriginalSalesListStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalSalesListDispatchId = group.Add(new VocabularyKey(nameof(OriginalSalesListDispatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalSalesListNumber = group.Add(new VocabularyKey(nameof(OriginalSalesListNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyTaxID = group.Add(new VocabularyKey(nameof(CompanyTaxID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxReportingCurrencyCode = group.Add(new VocabularyKey(nameof(TaxReportingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey DispatchId { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey ItemsValue { get; private set; }
        public VocabularyKey ServicesValue { get; private set; }
        public VocabularyKey InvestmentValue { get; private set; }
        public VocabularyKey NotAssignedValue { get; private set; }
        public VocabularyKey ListCode { get; private set; }
        public VocabularyKey Quarter { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey ClosingDate { get; private set; }
        public VocabularyKey DeliveryCode { get; private set; }
        public VocabularyKey IsSettlement { get; private set; }
        public VocabularyKey ErrorLog { get; private set; }
        public VocabularyKey Corrected { get; private set; }
        public VocabularyKey CorrectionSign { get; private set; }
        public VocabularyKey CorrectionPeriod { get; private set; }
        public VocabularyKey CorrectionFiscalYear { get; private set; }
        public VocabularyKey CorrectionAmount { get; private set; }
        public VocabularyKey CorrectedServices { get; private set; }
        public VocabularyKey CorrectionSignServices { get; private set; }
        public VocabularyKey CorrectionPeriodServices { get; private set; }
        public VocabularyKey CorrectionFiscalYearServices { get; private set; }
        public VocabularyKey CorrectionAmountServices { get; private set; }
        public VocabularyKey CorrectionDeclarationType { get; private set; }
        public VocabularyKey CorrectionMonthOrQuarter { get; private set; }
        public VocabularyKey CorrectionMonthOrQuarterServices { get; private set; }
        public VocabularyKey CorrectionReasonWrongAmount { get; private set; }
        public VocabularyKey CorrectionReasonWrongPeriod { get; private set; }
        public VocabularyKey CorrectionReasonWrongRegNum { get; private set; }
        public VocabularyKey OriginalSalesListStatus { get; private set; }
        public VocabularyKey OriginalSalesListDispatchId { get; private set; }
        public VocabularyKey OriginalSalesListNumber { get; private set; }
        public VocabularyKey CompanyTaxID { get; private set; }
        public VocabularyKey TaxReportingCurrencyCode { get; private set; }
    }
}