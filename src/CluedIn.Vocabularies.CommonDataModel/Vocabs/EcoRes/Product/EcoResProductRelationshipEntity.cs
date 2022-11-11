using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductRelationshipEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductRelationshipEntityVocabulary()
        {
            VocabularyName = "EcoResProductRelationshipEntity";
            KeyPrefix = "commonDataModel.ecoresproductrelationshipentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductRelationshipEntity";

            AddGroup("EcoResProductRelationshipEntity Details", group =>
            {
                MainProductRecId = group.Add(new VocabularyKey(nameof(MainProductRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedProductRecId = group.Add(new VocabularyKey(nameof(RelatedProductRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipTypeRecId = group.Add(new VocabularyKey(nameof(RelationshipTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainProductNumber = group.Add(new VocabularyKey(nameof(MainProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedProductNumber = group.Add(new VocabularyKey(nameof(RelatedProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductRelationTypeName = group.Add(new VocabularyKey(nameof(ProductRelationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainProductRecId { get; private set; }
        public VocabularyKey RelatedProductRecId { get; private set; }
        public VocabularyKey RelationshipTypeRecId { get; private set; }
        public VocabularyKey MainProductNumber { get; private set; }
        public VocabularyKey RelatedProductNumber { get; private set; }
        public VocabularyKey ProductRelationTypeName { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }


    }
}