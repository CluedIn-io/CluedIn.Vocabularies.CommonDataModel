using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeGroupCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeGroupCodeEntityVocabulary()
        {
            VocabularyName = "Payroll Earning Code Group Code Entity";
            KeyPrefix = "commonDataModel.payrollearningcodegroupcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeGroupCodeEntity";

            AddGroup("PayrollEarningCodeGroupCodeEntity Details", group =>
            {
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroup = group.Add(new VocabularyKey(nameof(EarningCodeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroupId = group.Add(new VocabularyKey(nameof(EarningCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey EarningCodeGroup { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey EarningCodeGroupId { get; private set; }
    }
}