using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedProductExternalCodeEntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedProductExternalCodeEntityVocabulary()
        {
            VocabularyName = "EcoResReleasedProductExternalCodeEntity";
            KeyPrefix = "commonDataModel.ecoresreleasedproductexternalcodeentity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedProductExternalCodeEntity";

            AddGroup("EcoResReleasedProductExternalCodeEntity Details", group =>
            {
                ReleasedProductExternalCodeClassId = group.Add(new VocabularyKey(nameof(ReleasedProductExternalCodeClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeRelationTableId = group.Add(new VocabularyKey(nameof(ExtCodeRelationTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeTableTableId = group.Add(new VocabularyKey(nameof(ExtCodeTableTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReleasedProductExternalCodeClassId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey ExtCodeRelationTableId { get; private set; }
        public VocabularyKey ExtCodeTableTableId { get; private set; }


    }
}