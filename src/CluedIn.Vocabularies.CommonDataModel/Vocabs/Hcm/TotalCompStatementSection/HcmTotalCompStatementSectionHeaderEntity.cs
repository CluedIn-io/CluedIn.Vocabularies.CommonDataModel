using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTotalCompStatementSectionHeaderEntityVocabulary : SimpleVocabulary
    {
        public HcmTotalCompStatementSectionHeaderEntityVocabulary()
        {
            VocabularyName = "Hcm Total Comp Statement Section Header Entity";
            KeyPrefix = "commonDataModel.hcmtotalcompstatementsectionheaderentity";
            KeySeparator = ".";
            Grouping = "/HcmTotalCompStatementSectionHeaderEntity";

            AddGroup("HcmTotalCompStatementSectionHeaderEntity Details", group =>
            {
                StatementSectionId = group.Add(new VocabularyKey(nameof(StatementSectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementSectionName = group.Add(new VocabularyKey(nameof(StatementSectionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey StatementSectionId { get; private set; }
        public VocabularyKey StatementSectionName { get; private set; }
    }
}