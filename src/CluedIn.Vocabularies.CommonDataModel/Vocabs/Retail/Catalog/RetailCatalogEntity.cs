using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogEntityVocabulary()
        {
            VocabularyName = "RetailCatalogEntity";
            KeyPrefix = "commonDataModel.retailcatalogentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogEntity";

            AddGroup("RetailCatalogEntity Details", group =>
            {
                IsSnapshotEnabled = group.Add(new VocabularyKey(nameof(IsSnapshotEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey(nameof(Owner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPublishedDateTime = group.Add(new VocabularyKey(nameof(LastPublishedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishedEffectiveDate = group.Add(new VocabularyKey(nameof(PublishedEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishedExpirationDate = group.Add(new VocabularyKey(nameof(PublishedExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDateTime = group.Add(new VocabularyKey(nameof(ValidFromDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerPartyNumber = group.Add(new VocabularyKey(nameof(OwnerPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyName = group.Add(new VocabularyKey(nameof(FriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsSnapshotEnabled { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey LastPublishedDateTime { get; private set; }
        public VocabularyKey PublishedEffectiveDate { get; private set; }
        public VocabularyKey PublishedExpirationDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidFromDateTime { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey OwnerPartyNumber { get; private set; }
        public VocabularyKey FriendlyName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Language { get; private set; }


    }
}