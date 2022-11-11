using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkProcessingPolicyEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkProcessingPolicyEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseWorkProcessingPolicyEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkprocessingpolicyentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkProcessingPolicyEntity";

            AddGroup("WHSWarehouseWorkProcessingPolicyEntity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyDescription = group.Add(new VocabularyKey(nameof(PolicyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyDescription { get; private set; }


    }
}