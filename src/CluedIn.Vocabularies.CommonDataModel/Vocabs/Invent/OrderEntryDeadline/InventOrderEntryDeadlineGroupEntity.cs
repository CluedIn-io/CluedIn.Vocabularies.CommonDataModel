using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventOrderEntryDeadlineGroupEntityVocabulary : SimpleVocabulary
    {
        public InventOrderEntryDeadlineGroupEntityVocabulary()
        {
            VocabularyName = "Invent Order Entry Deadline Group Entity";
            KeyPrefix = "commonDataModel.inventorderentrydeadlinegroupentity";
            KeySeparator = ".";
            Grouping = "/InventOrderEntryDeadlineGroupEntity";

            AddGroup("InventOrderEntryDeadlineGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}