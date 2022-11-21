using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeDefaultDimensionEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeDefaultDimensionEntityVocabulary()
        {
            VocabularyName = "Payroll Earning Code Default Dimension Entity";
            KeyPrefix = "commonDataModel.payrollearningcodedefaultdimensionentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeDefaultDimensionEntity";

            AddGroup("PayrollEarningCodeDefaultDimensionEntity Details", group =>
            {
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyInfo = group.Add(new VocabularyKey(nameof(CompanyInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplate = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryCompanyInfoId = group.Add(new VocabularyKey(nameof(CategoryCompanyInfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey CompanyInfo { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey AccountingDistributionTemplate { get; private set; }
        public VocabularyKey AccountingDistributionTemplateId { get; private set; }
        public VocabularyKey CategoryCompanyInfoId { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
    }
}