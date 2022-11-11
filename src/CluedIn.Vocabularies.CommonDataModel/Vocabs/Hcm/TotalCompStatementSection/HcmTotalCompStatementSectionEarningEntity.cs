using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTotalCompStatementSectionEarningEntityVocabulary : SimpleVocabulary
    {
        public HcmTotalCompStatementSectionEarningEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmTotalCompStatementSectionEarningEntity";
            KeyPrefix = "commonDataModel.hcmtotalcompstatementsectionearningentity";
            KeySeparator = ".";
            Grouping = "/HcmTotalCompStatementSectionEarningEntity";

            AddGroup("Common Data Model HcmTotalCompStatementSectionEarningEntity Details", group =>
            {
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeOrGroupType = group.Add(new VocabularyKey(nameof(EarningCodeOrGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroup = group.Add(new VocabularyKey(nameof(EarningCodeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCompensationStatementSection = group.Add(new VocabularyKey(nameof(TotalCompensationStatementSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementSectionId = group.Add(new VocabularyKey(nameof(StatementSectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableEarningCodeId = group.Add(new VocabularyKey(nameof(NullableEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroupId = group.Add(new VocabularyKey(nameof(EarningCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableEarningCodeGroupId = group.Add(new VocabularyKey(nameof(NullableEarningCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey EarningCodeOrGroupType { get; private set; }
        public VocabularyKey EarningCodeGroup { get; private set; }
        public VocabularyKey TotalCompensationStatementSection { get; private set; }
        public VocabularyKey StatementSectionId { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey NullableEarningCodeId { get; private set; }
        public VocabularyKey EarningCodeGroupId { get; private set; }
        public VocabularyKey NullableEarningCodeGroupId { get; private set; }


    }
}