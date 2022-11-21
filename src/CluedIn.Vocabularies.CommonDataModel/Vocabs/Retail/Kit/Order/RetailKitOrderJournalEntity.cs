using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitOrderJournalEntityVocabulary : SimpleVocabulary
    {
        public RetailKitOrderJournalEntityVocabulary()
        {
            VocabularyName = "Retail Kit Order Journal Entity";
            KeyPrefix = "commonDataModel.retailkitorderjournalentity";
            KeySeparator = ".";
            Grouping = "/RetailKitOrderJournalEntity";

            AddGroup("RetailKitOrderJournalEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitConfigId = group.Add(new VocabularyKey(nameof(KitConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistinctProductVariantID = group.Add(new VocabularyKey(nameof(DistinctProductVariantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalId = group.Add(new VocabularyKey(nameof(JournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitOrder = group.Add(new VocabularyKey(nameof(KitOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey KitConfigId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey DistinctProductVariantID { get; private set; }
        public VocabularyKey JournalId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey KitOrder { get; private set; }
    }
}