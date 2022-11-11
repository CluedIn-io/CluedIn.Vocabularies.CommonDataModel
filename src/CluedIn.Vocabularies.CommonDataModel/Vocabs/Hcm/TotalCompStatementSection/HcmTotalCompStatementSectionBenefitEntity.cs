using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTotalCompStatementSectionBenefitEntityVocabulary : SimpleVocabulary
    {
        public HcmTotalCompStatementSectionBenefitEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmTotalCompStatementSectionBenefitEntity";
            KeyPrefix = "commonDataModel.hcmtotalcompstatementsectionbenefitentity";
            KeySeparator = ".";
            Grouping = "/HcmTotalCompStatementSectionBenefitEntity";

            AddGroup("Common Data Model HcmTotalCompStatementSectionBenefitEntity Details", group =>
            {
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementSection = group.Add(new VocabularyKey(nameof(StatementSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementSectionId = group.Add(new VocabularyKey(nameof(StatementSectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey StatementSection { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey StatementSectionId { get; private set; }


    }
}