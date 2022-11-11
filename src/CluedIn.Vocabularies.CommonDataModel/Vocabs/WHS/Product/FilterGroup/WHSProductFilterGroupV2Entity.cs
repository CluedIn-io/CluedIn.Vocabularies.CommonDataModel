using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSProductFilterGroupV2EntityVocabulary : SimpleVocabulary
    {
        public WHSProductFilterGroupV2EntityVocabulary()
        {
            VocabularyName = "WHSProductFilterGroupV2Entity";
            KeyPrefix = "commonDataModel.whsproductfiltergroupv2entity";
            KeySeparator = ".";
            Grouping = "/WHSProductFilterGroupV2Entity";

            AddGroup("WHSProductFilterGroupV2Entity Details", group =>
            {
                FirstFilterGroupId = group.Add(new VocabularyKey(nameof(FirstFilterGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondFilterGroupId = group.Add(new VocabularyKey(nameof(SecondFilterGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FirstFilterGroupId { get; private set; }
        public VocabularyKey SecondFilterGroupId { get; private set; }


    }
}