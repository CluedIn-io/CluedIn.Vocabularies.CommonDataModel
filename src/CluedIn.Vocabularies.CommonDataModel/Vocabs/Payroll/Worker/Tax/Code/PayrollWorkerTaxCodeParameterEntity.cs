using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerTaxCodeParameterEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerTaxCodeParameterEntityVocabulary()
        {
            VocabularyName = "Payroll Worker Tax Code Parameter Entity";
            KeyPrefix = "commonDataModel.payrollworkertaxcodeparameterentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerTaxCodeParameterEntity";

            AddGroup("PayrollWorkerTaxCodeParameterEntity Details", group =>
            {
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeParameter = group.Add(new VocabularyKey(nameof(TaxCodeParameter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxCode = group.Add(new VocabularyKey(nameof(WorkerTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyInfoId = group.Add(new VocabularyKey(nameof(CompanyInfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeParameterName = group.Add(new VocabularyKey(nameof(TaxCodeParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeParameter_TaxEngineTaxCode = group.Add(new VocabularyKey(nameof(TaxCodeParameter_TaxEngineTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxEngineTaxCode_PayrollTaxCode = group.Add(new VocabularyKey(nameof(TaxEngineTaxCode_PayrollTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxCode_PayrollTaxCode = group.Add(new VocabularyKey(nameof(WorkerTaxCode_PayrollTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxCode_Worker = group.Add(new VocabularyKey(nameof(WorkerTaxCode_Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode_Worker_Code = group.Add(new VocabularyKey(nameof(TaxCode_Worker_Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode_Worker_CountryRegionId = group.Add(new VocabularyKey(nameof(TaxCode_Worker_CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerId = group.Add(new VocabularyKey(nameof(WorkerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey TaxCodeParameter { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey WorkerTaxCode { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey CompanyInfoId { get; private set; }
        public VocabularyKey TaxCodeParameterName { get; private set; }
        public VocabularyKey TaxCodeParameter_TaxEngineTaxCode { get; private set; }
        public VocabularyKey TaxEngineTaxCode_PayrollTaxCode { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey WorkerTaxCode_PayrollTaxCode { get; private set; }
        public VocabularyKey WorkerTaxCode_Worker { get; private set; }
        public VocabularyKey TaxCode_Worker_Code { get; private set; }
        public VocabularyKey TaxCode_Worker_CountryRegionId { get; private set; }
        public VocabularyKey WorkerId { get; private set; }
    }
}