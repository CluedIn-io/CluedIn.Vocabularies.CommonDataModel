using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseClusterProfileSortingEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseClusterProfileSortingEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseClusterProfileSortingEntity";
            KeyPrefix = "commonDataModel.whswarehouseclusterprofilesortingentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseClusterProfileSortingEntity";

            AddGroup("Common Data Model WHSWarehouseClusterProfileSortingEntity Details", group =>
            {
                ClusterSortingMethod = group.Add(new VocabularyKey(nameof(ClusterSortingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClusterProfileId = group.Add(new VocabularyKey(nameof(ClusterProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkLineFieldName = group.Add(new VocabularyKey(nameof(WarehouseWorkLineFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClusterSortingSequence = group.Add(new VocabularyKey(nameof(ClusterSortingSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClusterSortingMethod { get; private set; }
        public VocabularyKey ClusterProfileId { get; private set; }
        public VocabularyKey WarehouseWorkLineFieldName { get; private set; }
        public VocabularyKey ClusterSortingSequence { get; private set; }


    }
}