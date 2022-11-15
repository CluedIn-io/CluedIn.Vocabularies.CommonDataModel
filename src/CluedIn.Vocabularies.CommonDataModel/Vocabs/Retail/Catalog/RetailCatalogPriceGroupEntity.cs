using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogPriceGroupEntityVocabulary()
        {
            VocabularyName = "Retail Catalog Price Group Entity";
            KeyPrefix = "commonDataModel.retailcatalogpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogPriceGroupEntity";

            AddGroup("RetailCatalogPriceGroupEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceDiscGroup = group.Add(new VocabularyKey(nameof(PriceDiscGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupLegalEntity = group.Add(new VocabularyKey(nameof(PriceGroupLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Catalog = group.Add(new VocabularyKey(nameof(Catalog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey PriceDiscGroup { get; private set; }
        public VocabularyKey PriceGroupId { get; private set; }
        public VocabularyKey PriceGroupLegalEntity { get; private set; }
        public VocabularyKey Catalog { get; private set; }
    }
}