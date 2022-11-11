using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductDimensionGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductDimensionGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductDimensionGroupEntity";
            KeyPrefix = "commonDataModel.ecoresproductdimensiongroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductDimensionGroupEntity";

            AddGroup("Common Data Model EcoResProductDimensionGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationActive = group.Add(new VocabularyKey(nameof(IsProductConfigurationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseProductConfiguration = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseProductConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseProductConfiguration = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseProductConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationDisplayOrder = group.Add(new VocabularyKey(nameof(ProductConfigurationDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeActive = group.Add(new VocabularyKey(nameof(IsProductSizeActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseProductSize = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseProductSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseProductSize = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseProductSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeDisplayOrder = group.Add(new VocabularyKey(nameof(ProductSizeDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductColorActive = group.Add(new VocabularyKey(nameof(IsProductColorActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseProductColor = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseProductColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseProductColor = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseProductColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorDisplayOrder = group.Add(new VocabularyKey(nameof(ProductColorDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleActive = group.Add(new VocabularyKey(nameof(IsProductStyleActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionActive = group.Add(new VocabularyKey(nameof(IsProductVersionActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseProductStyle = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseProductStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseProductVersion = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseProductVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseProductStyle = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseProductStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseProductVersion = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseProductVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleDisplayOrder = group.Add(new VocabularyKey(nameof(ProductStyleDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionDisplayOrder = group.Add(new VocabularyKey(nameof(ProductVersionDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNomenclatureName = group.Add(new VocabularyKey(nameof(ProductVariantNomenclatureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNomenclatureRecId = group.Add(new VocabularyKey(nameof(ProductVariantNomenclatureRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey IsProductConfigurationActive { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseProductConfiguration { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseProductConfiguration { get; private set; }
        public VocabularyKey ProductConfigurationDisplayOrder { get; private set; }
        public VocabularyKey IsProductSizeActive { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseProductSize { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseProductSize { get; private set; }
        public VocabularyKey ProductSizeDisplayOrder { get; private set; }
        public VocabularyKey IsProductColorActive { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseProductColor { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseProductColor { get; private set; }
        public VocabularyKey ProductColorDisplayOrder { get; private set; }
        public VocabularyKey IsProductStyleActive { get; private set; }
        public VocabularyKey IsProductVersionActive { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseProductStyle { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseProductVersion { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseProductStyle { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseProductVersion { get; private set; }
        public VocabularyKey ProductStyleDisplayOrder { get; private set; }
        public VocabularyKey ProductVersionDisplayOrder { get; private set; }
        public VocabularyKey ProductVariantNomenclatureName { get; private set; }
        public VocabularyKey ProductVariantNomenclatureRecId { get; private set; }


    }
}