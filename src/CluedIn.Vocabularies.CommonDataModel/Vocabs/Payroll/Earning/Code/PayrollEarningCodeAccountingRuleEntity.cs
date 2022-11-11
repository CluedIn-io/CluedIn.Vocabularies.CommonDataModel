using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeAccountingRuleEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeAccountingRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEarningCodeAccountingRuleEntity";
            KeyPrefix = "commonDataModel.payrollearningcodeaccountingruleentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeAccountingRuleEntity";

            AddGroup("Common Data Model PayrollEarningCodeAccountingRuleEntity Details", group =>
            {
                OMOperatingUnit = group.Add(new VocabularyKey(nameof(OMOperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyInfo = group.Add(new VocabularyKey(nameof(CompanyInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OMOperatingUnit { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey CompanyInfo { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DepartmentNumber { get; private set; }


    }
}