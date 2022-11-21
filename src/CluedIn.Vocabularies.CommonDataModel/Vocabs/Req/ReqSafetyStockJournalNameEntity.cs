using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqSafetyStockJournalNameEntityVocabulary : SimpleVocabulary
    {
        public ReqSafetyStockJournalNameEntityVocabulary()
        {
            VocabularyName = "Req Safety Stock Journal Name Entity";
            KeyPrefix = "commonDataModel.reqsafetystockjournalnameentity";
            KeySeparator = ".";
            Grouping = "/ReqSafetyStockJournalNameEntity";

            AddGroup("ReqSafetyStockJournalNameEntity Details", group =>
            {
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalDescription = group.Add(new VocabularyKey(nameof(DefaultJournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPrivateUserGroupId = group.Add(new VocabularyKey(nameof(DefaultPrivateUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPostingDeleteLinesByDefault = group.Add(new VocabularyKey(nameof(WillPostingDeleteLinesByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey DefaultJournalDescription { get; private set; }
        public VocabularyKey DefaultPrivateUserGroupId { get; private set; }
        public VocabularyKey WillPostingDeleteLinesByDefault { get; private set; }
    }
}