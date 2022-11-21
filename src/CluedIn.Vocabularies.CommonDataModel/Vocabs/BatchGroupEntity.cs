using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BatchGroupEntityVocabulary : SimpleVocabulary
    {
        public BatchGroupEntityVocabulary()
        {
            VocabularyName = "Batch Group Entity";
            KeyPrefix = "commonDataModel.batchgroupentity";
            KeySeparator = ".";
            Grouping = "/BatchGroupEntity";

            AddGroup("BatchGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServerId = group.Add(new VocabularyKey(nameof(ServerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey ServerId { get; private set; }
    }
}