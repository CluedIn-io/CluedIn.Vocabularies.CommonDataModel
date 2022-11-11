using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitOrderEntityVocabulary : SimpleVocabulary
    {
        public RetailKitOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailKitOrderEntity";
            KeyPrefix = "commonDataModel.retailkitorderentity";
            KeySeparator = ".";
            Grouping = "/RetailKitOrderEntity";

            AddGroup("Common Data Model RetailKitOrderEntity Details", group =>
            {
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAssembly = group.Add(new VocabularyKey(nameof(IsAssembly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderSource = group.Add(new VocabularyKey(nameof(OrderSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderType = group.Add(new VocabularyKey(nameof(OrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Kit = group.Add(new VocabularyKey(nameof(Kit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey IsAssembly { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OrderSource { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey Kit { get; private set; }


    }
}