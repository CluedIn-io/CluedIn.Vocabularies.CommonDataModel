using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingGroupEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingGroupEntityVocabulary()
        {
            VocabularyName = "InventInventoryCountingGroupEntity";
            KeyPrefix = "commonDataModel.inventinventorycountinggroupentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingGroupEntity";

            AddGroup("InventInventoryCountingGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingJournalInclusionCode = group.Add(new VocabularyKey(nameof(CountingJournalInclusionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingPeriodDays = group.Add(new VocabularyKey(nameof(CountingPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey CountingJournalInclusionCode { get; private set; }
        public VocabularyKey CountingPeriodDays { get; private set; }


    }
}