using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectItemJournalTableEntityVocabulary : SimpleVocabulary
    {
        public ProjectItemJournalTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjectItemJournalTableEntity";
            KeyPrefix = "commonDataModel.projectitemjournaltableentity";
            KeySeparator = ".";
            Grouping = "/ProjectItemJournalTableEntity";

            AddGroup("Common Data Model ProjectItemJournalTableEntity Details", group =>
            {
                BlockUserGroupId = group.Add(new VocabularyKey(nameof(BlockUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLinesDeletedAfterPosting = group.Add(new VocabularyKey(nameof(IsLinesDeletedAfterPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDetailLevel = group.Add(new VocabularyKey(nameof(PostingDetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventLocationId = group.Add(new VocabularyKey(nameof(InventLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventSiteId = group.Add(new VocabularyKey(nameof(InventSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalId = group.Add(new VocabularyKey(nameof(JournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reservation = group.Add(new VocabularyKey(nameof(Reservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BlockUserGroupId { get; private set; }
        public VocabularyKey IsLinesDeletedAfterPosting { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PostingDetailLevel { get; private set; }
        public VocabularyKey InventLocationId { get; private set; }
        public VocabularyKey InventSiteId { get; private set; }
        public VocabularyKey JournalId { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey Reservation { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }


    }
}