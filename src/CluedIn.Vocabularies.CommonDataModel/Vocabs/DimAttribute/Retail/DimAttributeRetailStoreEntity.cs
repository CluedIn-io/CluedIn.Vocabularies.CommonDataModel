using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRetailStoreEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRetailStoreEntityVocabulary()
        {
            VocabularyName = "DimAttributeRetailStoreEntity";
            KeyPrefix = "commonDataModel.dimattributeretailstoreentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRetailStoreEntity";

            AddGroup("DimAttributeRetailStoreEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}