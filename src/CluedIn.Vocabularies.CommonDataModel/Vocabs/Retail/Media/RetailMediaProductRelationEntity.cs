using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMediaProductRelationEntityVocabulary : SimpleVocabulary
    {
        public RetailMediaProductRelationEntityVocabulary()
        {
            VocabularyName = "Retail Media Product Relation Entity";
            KeyPrefix = "commonDataModel.retailmediaproductrelationentity";
            KeySeparator = ".";
            Grouping = "/RetailMediaProductRelationEntity";

            AddGroup("RetailMediaProductRelationEntity Details", group =>
            {
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogId = group.Add(new VocabularyKey(nameof(CatalogId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(InternalOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultMedia = group.Add(new VocabularyKey(nameof(IsDefaultMedia), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey CatalogId { get; private set; }
        public VocabularyKey InternalOrganizationPartyNumber { get; private set; }
        public VocabularyKey IsDefaultMedia { get; private set; }
    }
}