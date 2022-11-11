using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogInternalOrganizationEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogInternalOrganizationEntityVocabulary()
        {
            VocabularyName = "RetailCatalogInternalOrganizationEntity";
            KeyPrefix = "commonDataModel.retailcataloginternalorganizationentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogInternalOrganizationEntity";

            AddGroup("RetailCatalogInternalOrganizationEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}