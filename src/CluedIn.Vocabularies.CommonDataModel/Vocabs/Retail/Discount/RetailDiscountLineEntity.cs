using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountLineEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountLineEntityVocabulary()
        {
            VocabularyName = "RetailDiscountLineEntity";
            KeyPrefix = "commonDataModel.retaildiscountlineentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountLineEntity";

            AddGroup("RetailDiscountLineEntity Details", group =>
            {
                DiscountPercentOrValue = group.Add(new VocabularyKey(nameof(DiscountPercentOrValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchDiscountType = group.Add(new VocabularyKey(nameof(MixAndMatchDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchLineGroup = group.Add(new VocabularyKey(nameof(MixAndMatchLineGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchNumberOfItemsNeeded = group.Add(new VocabularyKey(nameof(MixAndMatchNumberOfItemsNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferDiscountAmount = group.Add(new VocabularyKey(nameof(OfferDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferDiscountMethod = group.Add(new VocabularyKey(nameof(OfferDiscountMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferDiscountPercentage = group.Add(new VocabularyKey(nameof(OfferDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferPrice = group.Add(new VocabularyKey(nameof(OfferPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Color = group.Add(new VocabularyKey(nameof(Color), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Style = group.Add(new VocabularyKey(nameof(Style), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigId = group.Add(new VocabularyKey(nameof(ConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailGroupMemberLine = group.Add(new VocabularyKey(nameof(RetailGroupMemberLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferDiscountMethodN1 = group.Add(new VocabularyKey(nameof(OfferDiscountMethodN1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferPriceInclTaxN1 = group.Add(new VocabularyKey(nameof(OfferPriceInclTaxN1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferPriceN1 = group.Add(new VocabularyKey(nameof(OfferPriceN1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DiscountPercentOrValue { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey OfferId { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
        public VocabularyKey MixAndMatchDiscountType { get; private set; }
        public VocabularyKey MixAndMatchLineGroup { get; private set; }
        public VocabularyKey MixAndMatchNumberOfItemsNeeded { get; private set; }
        public VocabularyKey OfferDiscountAmount { get; private set; }
        public VocabularyKey OfferDiscountMethod { get; private set; }
        public VocabularyKey OfferDiscountPercentage { get; private set; }
        public VocabularyKey OfferPrice { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Color { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey Style { get; private set; }
        public VocabularyKey ConfigId { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey RetailGroupMemberLine { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey OfferDiscountMethodN1 { get; private set; }
        public VocabularyKey OfferPriceInclTaxN1 { get; private set; }
        public VocabularyKey OfferPriceN1 { get; private set; }


    }
}