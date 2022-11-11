using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductAllocationKeyEntityVocabulary : SimpleVocabulary
    {
        public ProductAllocationKeyEntityVocabulary()
        {
            VocabularyName = "ProductAllocationKeyEntity";
            KeyPrefix = "commonDataModel.productallocationkeyentity";
            KeySeparator = ".";
            Grouping = "/ProductAllocationKeyEntity";

            AddGroup("ProductAllocationKeyEntity Details", group =>
            {
                KeyId = group.Add(new VocabularyKey(nameof(KeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyName = group.Add(new VocabularyKey(nameof(KeyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey KeyId { get; private set; }
        public VocabularyKey KeyName { get; private set; }


    }
}