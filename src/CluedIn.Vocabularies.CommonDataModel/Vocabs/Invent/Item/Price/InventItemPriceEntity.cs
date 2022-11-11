using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemPriceEntityVocabulary : SimpleVocabulary
    {
        public InventItemPriceEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventItemPriceEntity";
            KeyPrefix = "commonDataModel.inventitempriceentity";
            KeySeparator = ".";
            Grouping = "/InventItemPriceEntity";

            AddGroup("Common Data Model InventItemPriceEntity Details", group =>
            {
                CostingVersionId = group.Add(new VocabularyKey(nameof(CostingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceQuantity = group.Add(new VocabularyKey(nameof(PriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceType = group.Add(new VocabularyKey(nameof(PriceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceChargesQuantity = group.Add(new VocabularyKey(nameof(PriceChargesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationNumber = group.Add(new VocabularyKey(nameof(CalculationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPriceIncludingCharges = group.Add(new VocabularyKey(nameof(IsPriceIncludingCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceSiteId = group.Add(new VocabularyKey(nameof(PriceSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCreatedDateTime = group.Add(new VocabularyKey(nameof(PriceCreatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CostingVersionId { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey PriceQuantity { get; private set; }
        public VocabularyKey PriceType { get; private set; }
        public VocabularyKey PriceChargesQuantity { get; private set; }
        public VocabularyKey CalculationNumber { get; private set; }
        public VocabularyKey IsPriceIncludingCharges { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey PriceSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey PriceCreatedDateTime { get; private set; }


    }
}